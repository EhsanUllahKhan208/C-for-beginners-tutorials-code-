﻿using System;

namespace TrainingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Your First Name:");
            String FirstName = Console.ReadLine();
            Console.WriteLine("Please enter Your Last Name:");
            String LastName = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}" , FirstName , LastName);
            //Console.WriteLine("Hello" + UserName);


        }

     
    }
}