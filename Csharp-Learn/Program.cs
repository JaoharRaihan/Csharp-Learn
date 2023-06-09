using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Singleline Comment
            /*
             * Multiline comment
             */
            //int Raihan = 35; //Integer Variable
            /* Data types in C#;
             * Integer - int Raihan;--  4 bytes
             * Long - long Raihan;-- 8 bytes
             * Floating point number - float that;-- 2 bytes
             * Double - double Raihan; -- 8 bytes
             * Character - Char a='A';-- 2 bytes
             * Boolean - bool is Great =true;-- 1bit
             * String inp="Raihan";-- 2 bytes per character
             */
            //string inp = Console.ReadLine();
            //Console.WriteLine(inp);
            /*
            Console.WriteLine("How are You?");
            Console.WriteLine("Good"+Raihan);
            Console.WriteLine("Ok");
            */
           //DATA TYPE EXAMPLE
           //int S = 33;
           // float A = 33F;
           // double R = 33D;
           // String inp = "Love";
           // Char I = 'U';
           // bool isGreat= true;
            /*
            Console.WriteLine(S);
            Console.WriteLine(A);
            Console.WriteLine(R);
            Console.WriteLine(inp);
            Console.WriteLine(I);
            Console.WriteLine(isGreat);
            */


            //Type Casting
            //There are two types of type casting
            //1. Implicit Casting
            //Char to int to long to float to double
            //2. Explicit Casting
            // int x=(int) 3.5;
            //double x1=(double) 3.5;
            //Console.WriteLine(x1);
            // X = 3;
            // Y = 4;
            // Z = 'Y';
            // varr = Convert.ToInt32(3.55);
            //.ToDouble
            //.ToString
            // sx = "Random String";

            //.WriteLine(X);
            //.WriteLine(Y);
            //.WriteLine(Z);

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hey " + name);
            Console.WriteLine("Do you like anyone?");
            string Quention = Console.ReadLine(); 
            Console.WriteLine("Nice! You deserve someone better than me" +( Convert.ToInt32(Quention) + 4));
            Console.ReadLine();
            
        }
    }
}
