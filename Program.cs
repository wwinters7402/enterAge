using System;

namespace enterAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());

            while(age < 18)
            {

                Console.WriteLine("Keep entering an age. You have not reached the legal age yet. ");
                age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("You have reached the legal age.");

            }
        }
    }

