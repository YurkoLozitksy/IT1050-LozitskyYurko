using System;

namespace Yurko_Lozitksy_Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; 
            for (a=1; a<10;a=a+2)
                //Loop control variable is a=1
                //Loop terminating conditon is a has to be less then 10 
                //Counter is a+2, to modify it just change what is being added to a
            {
                Console.WriteLine(a); 
            }

           
            for (int i = 30; i < 46; i=i+1) 
            {
                Console.WriteLine(i);
                {
                    if((i % 2)==0)
                    {
                        Console.WriteLine("Number is even");
                    }
                    else if ((i % 2) !=0)
                    {
                        Console.WriteLine("Number is odd");
                    }

                }
            }
            //I have no idea how to do problem number 3
            // 4.) The problem with the statement is that it is saying while i is less then 21
            // write i. i =10 so the program will write 10 continuously
            int g = 10;
            for (g=10; g < 21;g=g+1)
            {
                Console.WriteLine(g);
            }
            // 5.) The problem is the program writes the numbers 1 through 100 and then a single line with the astericks

            for (int i = 0; i < 101; i++)
                Console.WriteLine("{0} \n********",i);
            
            //6.)
            Console.Write("*");
            Console.Write("\n**");
            Console.Write("\n***");
            Console.Write("\n****");
            Console.Write("\n*****");
            Console.Write("\n******");
            Console.Write("\n*******");
            Console.Write("\n********");
            Console.Write("\n*********");
            Console.Write("\n**********");
        }
    }
}
