//Question
//Accept any number from user and return the factors of that number
//If user enters number 10 then factors will be 

using System;
namespace Challenges { 
    class Demo {

        static void Main()
        {
            Console.WriteLine("Enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("factors of a " + num);
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
}
}