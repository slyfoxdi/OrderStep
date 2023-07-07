using OrderStep.Core.Enum;
using OrderStep.Core.Exceptions;
using OrderStep.Core.Model;
using OrderStep.Infrastracture.Repository.Credential;
using OrderStep.Infrastracture.Repository.User;
using System;
using System.Collections.Generic;
using System.Linq;
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
                var userId = await _credentialRepository.GetUserIdByAuthentification(login, password, cancellationToken);
                var user = await _userRepository.GetUserById(userId, cancellationToken);
                var userAndRight = await _userAndRightRepository.GetClientRights(userId, cancellationToken);

                var result = new BaseResponse<Client>
                {
                    Response = new Client()
                    {
                        Id = userId,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                    },
                    Message = "Успешная авторизация",
                    Status = StatusCode.Success
                };

                return result;
            }
            catch (InfrastractureException ex)
            {
                return new BaseResponse<Client>()
                {
                    Message = ex.Message,
                    Status = StatusCode.FailedAuthentification
                };
            }
        }
    }
}
