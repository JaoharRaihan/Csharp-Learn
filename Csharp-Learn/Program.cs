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
            //**USER INPUT //
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //Co//nsole.WriteLine("Hey " + name);
            //Console.WriteLine("Do you like anyone?");
            //string Quention = Console.ReadLine(); 
            //Console.WriteLine("Nice! You deserve someone better than me" +( Convert.ToInt32(Quention) + 4));
            /*operators in C#
             1.Arithmatic operations
             2.Assigment operators
             3.Logical operators
             4.Comparison operators
            */
            //1.Arithmatic operations
            //int s = 33;
            //int r = 35;
            //Console.WriteLine("The value of s + r is:"+(s+r));
            //Console.WriteLine("The value of s - r is:" +(s-r));
            //Console.WriteLine("The value of s * r is:" +(s*r));
            //Console.WriteLine("The value of s / r is:" +(s/r));

            //2.Assigment operators
            //int s = 33;
            //int R = s;
            //R -= 33;
            //R+=33;
            //R *= 33;
            //R /= 33;
            // Console.WriteLine(R);

            //Logical Operators 
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);
            //
            //Console.WriteLine(false || true);
            //Console.WriteLine(true || true);
            //Console.WriteLine(false || false);
            //Console.WriteLine(!false); Console.WriteLine(!true); 

            //4.Comparison operators
            //Console.WriteLine(324 > 555);
            //Console.WriteLine(324 <= 555);
            //Console.WriteLine(324 >= 555);
            //Console.WriteLine(324 != 555);


            //MATH

            //int s = Math.Max(193, 33);
            //int a = Math.Min(193, 33);
            //double r = Math.Sqrt(33);
            //double R = Math.Abs(35);
            //Console.WriteLine(s);
            //Console.WriteLine(a);
            //Console.WriteLine(r);
            //Console.WriteLine(R);
            //string hello = "Hello world this is Raihan";
            //Console.WriteLine(hello.Length);
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello.ToLower());
            //Console.WriteLine(hello + "You are Nice!");
            //Console.WriteLine(String.Concat(hello , "You are Nice!"));


            //String
            
            Console.WriteLine("Enter her name");
            String name = Console.ReadLine();
            Console.WriteLine("ONE WORD TO DEDICATE HER");
            string Fuckingthought = Console.ReadLine();
            Console.WriteLine($"Her name is {name}.I wish she will get {Fuckingthought} ");
            



            //String hello = "Hello world this is Raihan";
            //String hello = "Hello \"world \"this is Raihan"; //--   " W "
            //String hello = "Hello world \n this is Raihan";    //--   NEW LINE
            //String hello = "Hello world \t this is Raihan";    //--   FOR    SPACE
            //Console.WriteLine(hello[1]);
            //Console.WriteLine(hello.IndexOf("is"));
            //Console.WriteLine(hello.Substring(3));
            //Console.WriteLine(hello);

            Console.ReadLine();


        }
    }
}
