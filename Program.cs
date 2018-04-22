using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            Console.WriteLine("The name in index 2 is {0}",names [2]);
            Console.WriteLine("The name in the last index is {0}", names[4]);


            string[] months=new string[12];
            months[0] = "Jan";
            months[1] = "Feb";
            months[2] = "Mar";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "Sept";
            months[9] = "Oct";
            months[10] = "Nov";
            months[11] = "Dec";
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Index {0} is {1}", i, months[i]);
            }

            string[] Season = new string[4];

            Season[0] = "Spring";
            Season[1] = "Summer";
            Season[2] = "Fall";
            Season[3] = "Winter";


            for (int i=0; i < 4; i++)
            {
                Console.WriteLine("Index {0} is {1}", i, Season[i]);
            }
               











            int[] integers = new int[1000];

            Random random = new Random();
            int randomNumber;
            for (int i = 0; i < 1000; i++)
            {
                randomNumber = random.Next(0, 100);  // place this line in the loop
                integers[i] = randomNumber;
            }
            foreach(int element in integers)
            {
                Console.WriteLine("Next Element {0}", element);
            }
        }
    }
}
