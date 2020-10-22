using System;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID code");             
            string userID = Console.ReadLine();
            if (Validate(userID))
            {
                Console.WriteLine("Welcome!");
                HelloUser(userID);
                
            }
            else
            {
                Console.WriteLine("Wrong format. Try again!");
            }

        }
        public static bool Validate(string idCode)
        {

            if (idCode.Length == 11)

            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format; {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public static void HelloUser(string idCode)
        {
            int firstNum = Int32.Parse(idCode[0].ToString());
            if (firstNum == 1 || firstNum == 3 || firstNum == 5)
            {
                Console.WriteLine("Hello sir!");
            }
            else if (firstNum == 2 || firstNum == 4 || firstNum == 6)
            {
                Console.WriteLine("Hello, Madam!");
            }


        }
       
        public static bool validate(string CreditCardNumber)
        { Console.WriteLine("Enter your Credit Card number");
            string CDNumber = Console.ReadLine();
            if (validate(CDNumber))
            {
                Console.WriteLine("Welcome!");
                HelloUser(CDNumber);

            }
            else
            {
                Console.WriteLine("Wrong format. Try again!");
            }
            if (CreditCardNumber.Length == 16)

            {
                try
                {
                    long.Parse(CreditCardNumber);
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Wrong format; {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }

        }



    }
}
