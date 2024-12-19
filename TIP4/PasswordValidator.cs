using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TIP4
{
    public class PasswordValidator
    {
        private readonly string[] commonPasswords;

        public PasswordValidator()
        {
            commonPasswords = CommonPasswords.List;
        }

        public bool Validate(string password, out string errorMessage)
        {
            errorMessage = string.Empty;

            // Проверка длины
            if (password.Length < 8 || password.Length > 16)
            {
                errorMessage = "Длина пароля должна быть от 8 до 16 символов.";
                return false;
            }

            // Проверка на специальные символы
            if (!Regex.IsMatch(password, @"[!@#$%^&*]"))
            {
                errorMessage = "Пароль должен содержать хотя бы один специальный символ (!, @, #, $, %, ^, &, *).";
                return false;
            }

            // Проверка на распространенные пароли
            if (commonPasswords.Contains(password))
            {
                errorMessage = "Пароль слишком простой и находится в списке распространенных паролей.";
                return false;
            }

            return true;
        }
    }
}
