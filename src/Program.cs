﻿using System;

namespace Main;
class Program
{
    static void Main(string[] args)
    {
        for(var i = 0; i < 100; i++)
        {
            var output = "";

            if(i % (3 * 5) == 0) 
            {
                output = "FizzBuzz";
            }
            else if(i % 3 == 0)
            {
                output = "Fizz";
            }
            else if(i % 5 == 0)
            {
                output = "Buzz";
            }
            else
            {
                output = i.ToString();
            }

            Console.WriteLine(output);
        }

        /*for(var i = 0; i < 100; i++)
        {
            string response = (i % 15 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString());
            Console.WriteLine(response);
        }*/
    }
}