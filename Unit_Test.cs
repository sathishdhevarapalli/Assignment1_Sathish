using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment1_Sathish
{
    class Unit_Test
    {
        static void Main11(string[] args)
        {
            string[,] paths = new string[,] { { "London", "New York" }, { "New York", "Tampa" },
                                        { "Delhi", "London" } };
            string destination = DestCity(paths);
            Console.WriteLine("Q6");
            Console.WriteLine("Destination city is " + destination);

        }
        private static string DestCity(string[,] paths)
        {
            try
            {
                         return "";


            }
            catch (Exception)
            {

                throw;
            }


        }


    }
}
