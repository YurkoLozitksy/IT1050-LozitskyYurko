using System;

namespace IT1050_Lab_3__LozitskyYurko
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.)The if-selection statement and the while repetition statement are similar because
            //they both perform an action based on whether a condition is true or false.
            //They are different because in a single selection statement the action is only performed once.
            //In the while repletion statement the action is repeated until the condition becomes false. 



            int speedLimit = 35;
            int speed = 42;

            if (speed>speedLimit)
            { Console.WriteLine("SLOW NOW");
            }
            
            int istrue = 14;
            if (istrue < 15)
                Console.WriteLine("It is true!");
            else
                Console.WriteLine("It is false!");


            int isfalse = 16;
            if (isfalse < 15)
                Console.WriteLine("It is true!");
            else
                Console.WriteLine("It is false!");

            Console .WriteLine( "Enter Temperature in Fahrenheit: " );
            double fahrenheit = Convert .ToDouble( Console .ReadLine());
            double celsius = (fahrenheit - 32d) * 5.0 / 9.0;
            Console .WriteLine( "The Temperature in Celsius is:{0} " , celsius);
             if (celsius < 40)
                Console .WriteLine( "It is COLD" );
            else
                Console .WriteLine( "It is HOT" );
            Console.ReadLine();

            int g = 1;
            while (g < 11)
            {
                Console.WriteLine(g);
                g=g + 1;
            }

            int e = 60;
            while (e>19)
            {
                Console.WriteLine(e);
                e = e - 1;
            }
            int f = 10;
            while (f<21)
            {
                Console.WriteLine(f);
                f = f + 1; 
            }

                
          

        }
    }
}
