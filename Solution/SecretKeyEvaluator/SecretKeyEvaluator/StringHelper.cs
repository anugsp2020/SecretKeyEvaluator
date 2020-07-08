using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretKeyEvaluator
{
    public class StringHelper
    {
        public static bool IsValidSecretKey1(string inputStr)
        {
            bool isAphabetsOnly = true;
            bool isUnique = true;


            for (int i = 0; i < inputStr.Length; i++)
            {
                if (!char.IsLetter(inputStr[i]))
                {
                    isAphabetsOnly = false;
                    break;
                }
            }

            for (int i = 0; i < inputStr.Length; i++)
            {
                for (int j = i + 1; j < inputStr.Length; j++)
                {
                    if (inputStr[i] == inputStr[j])
                    {
                        isUnique = false;
                    }
                }
                if (!isUnique)
                {
                    break;
                }
            }

            if (isAphabetsOnly && isUnique)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsValidSecretKey2(string inputStr)
        {
            bool isValidString = true;

            if (inputStr.Length < 4)
            {
                isValidString = false;
            }
            else
            {
                string numbers = inputStr.Substring(inputStr.Length - 3, 3);
                int number = 0;
                if (!char.IsLetter(inputStr[0]))
                {
                    isValidString = false;
                }
                else
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] == '0')
                        {
                            isValidString = false;
                            break;
                        }

                    }
                    if (!int.TryParse(numbers, out number))
                    {
                        isValidString = false;
                    }
                }
            }
            return isValidString;
        }
    }
}
