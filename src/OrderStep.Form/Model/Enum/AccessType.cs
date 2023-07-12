using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Model.Enum
{
    public enum AccessType
    {
        /// <summary>
        /// Нет доступа
        /// </summary>
        None = 1,

        /// <summary>
        /// Только показ
        /// </summary>
        OnlyView = 2,

        /// <summary>
        /// Только редактирование
        /// </summary>
        OnlyEdit = 3,

        /// <summary>
        /// Полные
        /// </summary>
        Full = 4
    }
}
