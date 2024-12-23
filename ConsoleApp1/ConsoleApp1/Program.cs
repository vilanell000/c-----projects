// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharpFundamentals
{
    public enum Visitfrom
    {
        socail = 1,
        friends = 2,
        staff = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var source = Visitfrom.socail;

            switch (source)
            {
                case Visitfrom.socail:
                    Console.WriteLine("aloha~");
                    break;

                case Visitfrom.friends:
                    Console.WriteLine("hi bestie~");
                    break;

                case Visitfrom.staff:
                    Console.WriteLine(" hello ");
                    break;

                default:
                    Console.WriteLine("welcome");
                    break;
            }
        }
    }
}