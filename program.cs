using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Player
    {
        public string name = "Liza";
        private int health = 49;
        public int Gethealth(){
            return health;
        }
        public void Sethealth(int h){
            health = h;
        }
    }
    class Program
    {
        // static void greet(string name){
        //     Console.WriteLine("Good morning " + name);
        // // }
        // static float average(int a, int b, int c){
        //     float sum = a + b + c;
        //     return sum /3;
        // }
        // static float average(int a, int b){
        //     float sum = a+b;
        //     return sum /2;
        // }
        static void Main(string[] args)
        {
            // single line comment
            /* multi line comment
            */

            // int a = 37;

            // ********** for input ************
            // string imp = Console.ReadLine();
            // Console.WriteLine(imp);
            // Console.WriteLine("Hello " + a);

            // ************** Data Type Example **************
            // int a = 34;
            // float b = 34.4F; // it is required to add F in float in c#
            // double c = 34.4D; // it is not required to add D in double in c#
            // bool isgreat = true;
            // char d = 'r';
            // string e = "This is a string";

            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(isgreat);
            // Console.WriteLine(d);
            // Console.WriteLine(e);

            // ************* Type Casting **************
            // There are two type of type casting
            // 1. Implicit Casting --->
            // char to int to long to float to double
            // int a = 37;
            // double b = a;
            // int c = 'y';
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // 2. Explicit Casting --->
            // int x = (int)3.4;
            // Console.WriteLine(x);

            // *************** Type Casting Method ************
            // float a = Convert.ToInt32(3.55);
            // Console.WriteLine(a);

            // ************** Taking User input ************ 
            // Console.WriteLine("Enter your name ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Hello " + name);

            // Console.WriteLine("How many candies do you want?");
            // string can = Console.ReadLine();
            // Console.WriteLine("You will get 4 more candies: " + (Convert.ToInt32(can) + 4));

            /* ************** Operators in c# **************
            1. Arithmetic Operators
            2. Assignment Operators
            3. Comparison Operators
            4. Logical Operators
            */
            // 1. --->
            // int a = 45;
            // int b = 25;
            // Console.WriteLine("The value of a + b is: " + (a + b));

            // 2. --->
            // int a = 4;
            // int b = a;
            // b += 4;
            // Console.WriteLine(b);

            // 3. --->
            // Console.WriteLine(344 >= 255); // <=, <, >, ==, !=

            // 4. --->
            // Console.WriteLine(true && false);
            // Console.WriteLine(true && true);
            // Console.WriteLine(false && false);

            // Console.WriteLine(true || false);
            // Console.WriteLine(true || true);
            // Console.WriteLine(false || false);

            // Console.WriteLine(!true);
            // Console.WriteLine(!false);

            // ************** Math Class ************
            // int a = Math.Max(34, 355);
            // int a = Math.Min(34, 355);
            // double a = Math.Sqrt(32);
            // int a = Math.Abs(-34);
            // Console.WriteLine(a);

            // ******************* String Methods ***************
            // string hello = "Hello world this is liza";
            // Console.WriteLine(hello.Length);
            // Console.WriteLine(hello.ToUpper());
            // Console.WriteLine(hello.ToLower());
            // Console.WriteLine(hello + " You are nice.");
            // Console.WriteLine(string.Concat(hello, " You are nice."));
            // Console.WriteLine(hello[0]);
            // Console.WriteLine(hello.IndexOf("is"));
            // Console.WriteLine(hello.Substring(5));

            // *************** string interpolation **************
            // string name = Console.ReadLine();
            // string candies = Console.ReadLine();
            // Console.WriteLine($"Your namr is {name}. You will get {candies} candies.");

            // ************* If Else Statements *****************
            // Console.WriteLine("Enter your age");
            // string agestr = Console.ReadLine();
            // int age = Convert.ToInt32(agestr);
            // if (age < 2){
            //     Console.WriteLine("You are just born");
            // }
            // else if (age < 10){
            //     Console.WriteLine("Please finish your high school first");
            // }
            // else if (age < 18){
            //     Console.WriteLine("you are below 18");
            // }
            // else if (age < 75){
            //     Console.WriteLine("You can drive");
            // }
            // else{
            //     Console.WriteLine("You can not drive");
            // }

            //*********** Switch Case ************
            // Console.WriteLine("Enter your age");
            // string agestr = Console.ReadLine();
            // int age = Convert.ToInt32(agestr);
            // switch (age){
            //     case 18:
            //         Console.WriteLine("Please wait one more year");
            //         break;
            //     case 20:
            //         Console.WriteLine("You are 20");
            //         break;
            //     default:
            //         Console.WriteLine("Enjoy!");
            //         break;
            // }

            /* ************* Loops in c# **************
            1. While Loop 
            2. Do While Loop
            3. For Loop
            */
            // 1. --->
            // int i = 0;
            // while (i<5){
            //     Console.WriteLine(i+1);
            //     i++;
            // } 

            // 2. --->
            // do{
            //     Console.WriteLine(i+1);
            //     i++;
            // }while (i>5);

            // 3. ---> (*******break****** and ******* continue ********)
            // for(int i = 0; i<5; i++)
            // {
            //     if(i==0){
            //     continue;
            //     }
            //     Console.WriteLine(i+1);
            //     break;
            // }

            // *********** Functions and methods *****************
            // greet("liza");
            // Console.WriteLine(average(2,6,8));
            // float temp = average(9,3,0);
            // Console.WriteLine(temp);
            // Console.WriteLine(average(3,3,3));
            // Console.WriteLine(average(2,5));

            // ******** OOPs Classes and Objects *********
            Player tommy = new Player();
            // Console.WriteLine(tommy.health);
            tommy.Sethealth(57);
            Console.WriteLine(tommy.Gethealth());

            Console.ReadLine();
        }
    }
}