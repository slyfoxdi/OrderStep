using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using OrderStep.Core.Enum;
using OrderStep.Core.Exceptions;
using OrderStep.Core.Helper;
using OrderStep.Core.Model;
using OrderStep.Infrastracture.Repository.Credentials;
using OrderStep.Infrastracture.Repository.Users;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Domain.Service
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly ICredentialRepository _credentialRepository;
        private readonly IUserRepository _userRepository;
        private readonly IUserAndRightRepository _userAndRightRepository;

        public AuthentificationService(ICredentialRepository credentialRepository, IUserRepository userRepository,
            IUserAndRightRepository userAndRightRepository)
        {
            _credentialRepository = credentialRepository;
            _userRepository = userRepository;
            _userAndRightRepository = userAndRightRepository;
        }

        public async Task<BaseResponse<Client>> AuthentificationUser(string login, string password, CancellationToken cancellationToken)
        {
            try
            {
                var credentialId = await _credentialRepository.GetUserIdByAuthentification(login, password, cancellationToken);
                var user = await _userRepository.GetUserById(credentialId, cancellationToken);
                var userAndRight = await _userAndRightRepository.GetClientRights(credentialId, cancellationToken);

                if (credentialId > 0)
                {
                    var result = new BaseResponse<Client>
                    {
                        Response = new Client()
                        {
                            Id = credentialId,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Rights = userAndRight.Select(x => new UserAndRight()
                            {
                                Access = (AccessType)x.Right.Id,
                                Action = (ActionType)x.Action.Id
                            }).ToList(),
                            AccessToken = Token(credentialId, login)
                        },
                        Message = "Успешная авторизация",
                        Status = StatusCode.Success
                    };

                    return result;
                }

                return new BaseResponse<Client>()
                {
                    Message = "Неверный логин и\\или пароль!",
                    Status = StatusCode.FailedAuthentification
                };
            }
            catch (InfrastractureException ex)
            {
                return new BaseResponse<Client>()
                {
                    Message = "Не удалось авторизоваться, попробуйте позже!",
                    Status = StatusCode.ServerError
                };
            }
        }

        /// <summary>
        /// Получение токена
        /// </summary>
        /// <param name="credentialId"></param>
        /// <param name="login"></param>
        /// <returns></returns>
        private string Token(int credentialId, string login)
        {
            var identity = GetIdentity(credentialId, login);

            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                    issuer: AuthOptions.ISSUER,
                    audience: AuthOptions.AUDIENCE,
                    notBefore: now,
                    claims: identity.Claims,
                    expires: now.Add(TimeSpan.FromMinutes(AuthOptions.LIFETIME)),
                    signingCredentials: new SigningCredentials(AuthOptions.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));
           
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return encodedJwt;
        }

        private ClaimsIdentity GetIdentity(int credentialId, string login)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, login),
                new Claim("CredentialId", credentialId.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(
                    claims, 
                    "Token", 
                    ClaimsIdentity.DefaultNameClaimType,
                    ClaimsIdentity.DefaultRoleClaimType
                );

            return claimsIdentity;
        }
    }
}
