using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Manual reverse of a string is to define a string in this case output and input
            // and give them values for output it was (open to astring type)
            string input = "one";
            string output = "";
            //use the for condition to say that a intiger type i is equal to the string i declared input (with predefinded length)
            //that i is greater than or equal to a number and then decrament that i
            for (int i = input.Length - 1; i >= 0; i--)
            {
                //the output is plas or eaul to input array i
                output += input[i];
                Console.WriteLine("{0}" , output);
            }
            
            //second reverse attempt had to define input as 2 since input already used, same with output
            string input2 = "two";
            //called a type char and named it inputarray and then tied it to input2 using the built in to convert it to Char array
            char[] inputarray = input2.ToCharArray();
            //used another built in array.reverse to reverse the inputarray which is actually input2
            Array.Reverse(inputarray);
            string output2 = new string(inputarray);
            Console.WriteLine("{0}" , output2);

            //third attempt to reverse a string using LINQ
            string input3 = "three";
            //string reversal written on one line ToCharArrary().Reverese().ToArray())
            string output3 = new string(input3.ToCharArray().Reverse().ToArray());
            Console.WriteLine("{0}" , output3);
        }
    }
}
