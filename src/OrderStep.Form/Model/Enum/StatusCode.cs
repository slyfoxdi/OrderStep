﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStep.Api.Model.Enum
{
    public enum StatusCode
    {
        /// <summary>
        /// Операция прошла успешно
        /// </summary>
        Success = 0,

        /// <summary>
        /// Ошибка сохранения
        /// </summary>
        FailedSaveOrder = 10,

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
