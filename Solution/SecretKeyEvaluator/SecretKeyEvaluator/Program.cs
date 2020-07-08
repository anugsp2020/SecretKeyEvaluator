using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretKeyEvaluator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter secret key1");
            string inputStr1 = Console.ReadLine();
            Console.WriteLine("Enter secret key2");
            string inputStr2 = Console.ReadLine();
            bool result1 = StringHelper.IsValidSecretKey1(inputStr1);
            bool result2 = StringHelper.IsValidSecretKey2(inputStr2);

            if (result1&&result2)
            {
                Console.WriteLine("Valid Key");
            }
            else
            {
                Console.WriteLine("Not a Valid Key");
            }
        }
    }
}
