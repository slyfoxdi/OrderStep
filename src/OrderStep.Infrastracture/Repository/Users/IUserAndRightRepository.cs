using OrderStep.Infrastracture.Model;

namespace OrderStep.Infrastracture.Repository.Users
{
    public interface IUserAndRightRepository
    {
        /// <summary>
        /// Загрузка прав клиента
        /// </summary>
        /// <param name="clientCode">id клиента в системе</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<UserAndRightDao>> GetClientRights(int clientCode, CancellationToken cancellationToken);
    }
}
