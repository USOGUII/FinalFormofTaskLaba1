using System;
namespace firsttask
{
    class firsttask1
    {
        public static bool IsPalindromic(int l)
        {
            IEnumerable<char> forwards = l.ToString().ToCharArray();
            return forwards.SequenceEqual(forwards.Reverse());
        }
        public int main()
        {
            string EnteranceNumber;
            int Number;
            while (true)
            {
                Console.WriteLine("Enter a (5>)digit-number\n");
                EnteranceNumber = Console.ReadLine();
                var isNumeric = int.TryParse(EnteranceNumber, out _);
                if (isNumeric)
                {
                    if (EnteranceNumber.Length < 5)
                    {
                        Console.WriteLine("This number isn`t 5 more-digit number, try again\n");
                        continue;
                    }
                    else
                    {
                        Number = int.Parse(EnteranceNumber);
                        if (IsPalindromic(Number))
                        {
                            Console.WriteLine("It's a polindrome.\n");
                        }
                        else
                        {
                            Console.WriteLine("Not a palindrome.\n");
                        }
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("This is not a number, try again\n");
                    continue;
                }
            }
            return 0;
        }
    }
}