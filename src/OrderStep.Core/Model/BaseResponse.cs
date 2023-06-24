namespace OrderStep.Core.Model
{
    public class BaseResponse <T>
    {
        /// <summary>
        /// Сессия
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Http Status
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Ответ
        /// </summary>
        public T Response { get; set; }
    }
}
