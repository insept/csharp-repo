﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2___Reverse
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.Write("What's your name? ");
                var name = Console.ReadLine();

                var array = new char[name.Length];
                for (var i = name.Length; i > 0; i--)
                    array[name.Length - i] = name[i - 1]; //(if name is 5 letters) Run1: array[0] = name[4]

                var reversed = new string(array);
                Console.WriteLine("Reversed name: " + reversed);
            }


        }
    }
}
