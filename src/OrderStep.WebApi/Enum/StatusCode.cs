using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Core.Enum
{
    public enum StatusCode
    {
        /// <summary>
        /// Операция прошла успешно
        /// </summary>
        Success = 0,
        
        /// <summary>
        /// Неудачная авторизация
        /// </summary>
        FailedAuthentification = 100,
        
        /// <summary>
        /// Неизвестная ошибка
        /// </summary>
        Unknown = 500,
        
    }
}
