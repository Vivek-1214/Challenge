//Question
//Accept any number from user and return the factors of that number
//If user enters number 10 then factors will be 

using System;
namespace Challenges { 
    class Demo {

        static void Main()
        {
            // Factorials();
            //odd();
            //prime();
            //Table();
            DecimalToBinary();
            }
        static void Factorials()
        {
            Console.WriteLine("Please Enter start of limit");
            int startOfLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter end limit");
            int endOfLimit = Convert.ToInt32(Console.ReadLine());

          
           // Console.WriteLine($"factors of a {num} =");
            for (int j = startOfLimit; j <= endOfLimit; j++)
            {
                int fact = 1, i = 1;

                for (i = 1; i <= j; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine(fact);
            }
        }
            static void odd()
            {
                Console.WriteLine("Enter any number :");
                int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("odd numbers are : ");
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i+" ");
                }
            }
            }
        static void prime()
        {
            Console.WriteLine("Enter start of limit :");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the limit :");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("prime numbers are :");
           
            for (int j = start; j <= limit; j++)
            {
                int count = 0;
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        count++;
                    }
                }

                if (count <= 2)
                {
                    Console.Write(j+" ");
                }
            }
          
           

        }

        static void Table()
        {
            Console.WriteLine("Please Enter start of limit");
            int startOfLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter endOfLimit");
            int endOfLimit = Convert.ToInt32(Console.ReadLine());

            for (int j = startOfLimit; j <= endOfLimit; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int tab = j * i;
                    Console.Write(tab+" ");
                }
                Console.WriteLine();
            }
           
        }

        static void DecimalToBinary()
        {
            Console.WriteLine("Please Enter Decimal number");
            int num1 = Convert.ToInt32(Console.ReadLine());  //13

            int rem = 0; 
           
            int[] arr = new int[10];  //IndexOutOfRangeException//
            int i = 0;
            while ( num1 != 0)
            {
                rem = num1 % 2;
                num1  =num1 / 2;

               arr[i++]= rem;
               
            }
             Array.Reverse(arr);
            try
            {
                for (int j = 0; j <= arr.Length; j++)
                {
                    Console.Write(arr[j] + " ");
                }
            }
            catch(IndexOutOfRangeException ex)
            {

            }
        }
     }
}
