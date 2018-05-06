using System;

namespace Midterm
{
    class Program
    {
        static Boolean keepLooping = true;
        static void Main(string[] args)
        {
            while (keepLooping) { }
            int x = 2;
            while (x < 129)
            {
                Console.WriteLine("[{0}]", x);
                x = x * 2;

            }

            for (x = 49; x > 0; x--)
            {
                if (x == 1)
                {
                    Console.WriteLine("{0}", x);
                }
                else { Console.Write("{0},", x); }
             
            }
            x = 1;
                while  (x<22)
            {
                    Console.Write("{0}   ",x);
                x = x + 2;
            }
            Console.WriteLine();
            int n = 10;
            int i = 8; // initialize
            Console.Write("*");
            while (i < (n-1)) // test condition]
            {
                Console.Write("*");
                i++; // update!
            }
            //The differece is in a do-while you alwways run the code once before you test the while condition. 
            //But a while loop sometimes wont run at all.
            Boolean icyRain=false;
            Boolean tornadoWarning=false;
            if ((icyRain == false) && (tornadoWarning == false))
            {
                Console.WriteLine("Lets go outside!");
            }

            n = 5;
            int count = 0;
            while (n > 0)
            {
                for (i=0; i < count; i++)
                {
                    Console.Write(" ");
                }
                for (i=1;i<n;i++)
                {
                    Console.Write("{0}", i);
                }
                for (;i>0;i--)
                {
                    Console.Write("{0}", i);
                }
                n--;
                count++;
                Console.WriteLine();
            }



        }
    }
}
