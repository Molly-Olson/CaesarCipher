using System;
using CaesarCipher;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cipher = new Caesar();

            Console.WriteLine("Assignment 1: Caesar Cipher Tests");
            Console.WriteLine("The slow brown cow will become...");
            Console.WriteLine("Ftq exai ndaiz oai.");
            Console.WriteLine("Try it out!");
            Console.WriteLine("");
            Console.WriteLine("Enter your text here.");
            string input = Console.ReadLine();
            Console.WriteLine("Type 'f' to encrypt forward or 'b' to encrypt backward.");
            string choice = Console.ReadLine();

            if (choice == "f")
            {
                string result = cipher.ShiftForward(input);
                Console.WriteLine("Encrypted: " + result);
            }
            else if (choice == "b")
            {
                string result = cipher.ShiftBackward(input);
                Console.WriteLine("Decrypted: " + result);
            }
            else
            {
                Console.WriteLine("Invalid choice hommie, come on now this aint hard y'all!");
            }
        }
    }
}
