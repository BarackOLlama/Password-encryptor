using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_encryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the password you wish to encrypt to receive the hashed version and its corresponding salt.");
            Console.WriteLine("Enter an empty line or write \"exit\" to exit the application.");
            while (true)
            {
                string input = Console.ReadLine();

                if (! string.IsNullOrEmpty(input))
                {
                    if (input.Trim().ToLower() == "exit")
                    {
                        return;
                    }

                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    string hashedPW = BCrypt.Net.BCrypt.HashPassword(input, salt);

                    Console.WriteLine("Password:");
                    Console.WriteLine(hashedPW);
                    Console.WriteLine("Salt:");
                    Console.WriteLine(salt);
                }
                else
                {
                    return;
                }
            }

        }
    }
}
