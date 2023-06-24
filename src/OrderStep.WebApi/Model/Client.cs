namespace OrderStep.WebApi.Model
{
    public class Client
    {
        /// <summary>
        /// Id клиента в системе
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///  Имя
        /// </summary>
        public string FitstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Описание клиента
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Id роли
        /// </summary>
        public int Role { get; set; }
    }
}
