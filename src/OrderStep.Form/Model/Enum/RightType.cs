using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Model.Enum
{
    public enum RightType
    {
        /// <summary>
        /// Нет доступа
        /// </summary>
        Disable = 1,

        /// <summary>
        /// Только просмотр
        /// </summary>
        OnlyView = 2,

        /// <summary>
        /// Редактирование
        /// </summary>
        Edit = 3,

        /// <summary>
        /// Полные права
        /// </summary>
        Full = 4
    }
}
