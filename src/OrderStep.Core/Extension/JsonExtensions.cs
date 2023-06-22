using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OrderStep.Core.Extension
{
    public static class JsonExtensions
    {
        private static readonly JsonSerializerOptions DefaultOptionsToLog = new()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        public static string ToJsonLog<TValue>(this TValue value, JsonSerializerOptions options = null)
        {
            return JsonSerializer.Serialize(value, options ?? DefaultOptionsToLog);
        }
    }
}
