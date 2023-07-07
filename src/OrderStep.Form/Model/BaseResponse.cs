using OrderStep.Api.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Model
{
    public class BaseResponse<T>
    {
        /// <summary>
        /// Сессия
        /// </summary>
        public string SessionId { get; set; }

        /// <summary>
        /// Http Status
        /// </summary>
        public StatusCode Status { get; set; }

        /// <summary>
        /// Ответ
        /// </summary>
        public T Response { get; set; }

        /// <summary>
        /// Ответ для уведомлялки
        /// </summary>
        public string Message { get; set; }
    }
}
