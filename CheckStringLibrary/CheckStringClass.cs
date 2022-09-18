using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckStringLibrary
{
    public class CheckStringClass
    {
        /// <summary>
        /// Метод, который определяет, что строка состоит только из цифр
        /// </summary>
        /// <param name="textString">
        /// входящая строка
        /// </param>
        /// <returns>
        /// Метод возвращает true, если входная строка содержит только цифры.
        /// </returns>
        public static bool OnlyDigits(string textString)
        {
            
            if (String.IsNullOrEmpty(textString))//проверка на пустую строку
            {
                return false;
            }
            if (!textString.All (x => Char.IsDigit(x)))//дословно.... если не символы - цифры
            {
                return false;
            }
            return true;
       
        }

    }
}
