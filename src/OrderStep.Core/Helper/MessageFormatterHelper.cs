using OrderStep.Core.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace OrderStep.Core.Helper
{
    public static class MessageFormatterHelper
    {

        public static string Format(string title, string message, params object[] args)
        {
            try
            {
                var builder = new StringBuilder().AppendLine(!string.IsNullOrWhiteSpace(title)
                    ? $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss.ffff}] {title}"
                    : $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss.ffff}]");

                if(!string.IsNullOrWhiteSpace(message))
                {
                    builder.AppendLine(message);
                }

                if(args is { Length: > 0 })
                {
                    builder.AppendLine(args.ToJsonLog());
                }

                return builder.ToString();
            }
            catch (Exception ex)
            {
                return $"Ошибка в {nameof(MessageFormatterHelper)}{NewLine}{ex.Message}";
            }
        }

        public static string ToUpperFirstLetter(string word)
        {
            try
            {
                if(string.IsNullOrEmpty(word) || word.Length < 2)
                {
                    return word;
                }

                var result = char.ToUpper(word[0]) + word[1..].ToLower();

                return result;
            }
            catch (Exception ex)
            {
                return $"Ошибка в {nameof(MessageFormatterHelper)}{NewLine}{ex.Message}";
            }
        }
    }
}
