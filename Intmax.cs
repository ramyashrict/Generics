﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
  public class Intmax
    {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter the FirstNumber");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the SecondNumber");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the ThirdNumber");
                int num3 = Convert.ToInt32(Console.ReadLine());

                int val = IntMax.MaxNumber(num1, num2, num3);
                System.Console.WriteLine("Heights Number is " + val);
            }
        }
    }

