using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace пифагор_блеать
{
    class Program
    {
       /* static int GetCount(int value)
        {
           
            int count = 0;
            for (; value >= 1; count++, value /= 10) ;
            return count;
        }
        static int GetLocalCount(int LocalValue)
        {
            int LocalCount = 0;
            for (; LocalValue >= 1; LocalCount++, LocalValue /= 10) ;
            return LocalCount;
        }
        static string GetSpaces(int count)
        {
            for (; LocalCount < GetCount; GetLocalCount++)
            { Console.Write(" "); }
        }*/
        static void Main(string[] args)
        {


            Console.WriteLine("Lenght from?");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Lenght to?");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Good, height from?");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("To?");
            int y = int.Parse(Console.ReadLine());

            int count = 1;
            int xy = x * y;
            int LocalSpaceCount1 = 0;
            int LocalSpace1 = x;
            int LocalSpaceY = y;
            int LocalSpaceCountY = 0;
            
            for (; LocalSpaceY >= 1; LocalSpaceY /= 10) { LocalSpaceCountY++; }
            for (; LocalSpace1 >= 1; LocalSpace1 /= 10) { LocalSpaceCount1++; }
            for (; xy >= 1; count++, xy /= 10) ;
            for (int fuck = 0; fuck < LocalSpaceCount1; fuck++) { Console.Write(" "); }
            Console.Write("|");
            for (int lenghth = x1 ; lenghth <= x; lenghth++)
            {
                
               
                int LocalCount = 0;
                int LocalShit = lenghth;
                for (; LocalShit >= 1; LocalShit /= 10) { LocalCount++; }
                for (; LocalCount < count; LocalCount++) { Console.Write(" "); }
                Console.Write(lenghth);


            }
            Console.WriteLine();



            for (int i = y1; i <= y; i++)
            {
                
               if (i == y1) 
                {
                    int k = 0;
                    for (; k < LocalSpaceCount1; k++) { Console.Write("-"); }
                    Console.Write("+");
                    for (; k <= count * (x - x1) + LocalSpaceCount1 + count - 1; k++) { Console.Write("-"); }


                    Console.WriteLine(); 
                }

                
                for (int j = x1; j <= x; j++)
                {

                    if (j == x1)
                    {
                        int LocalCount1 = 0;
                        int LocalShit1 = i;
                        
                        for (; LocalShit1 >= 1; LocalShit1 /= 10) { LocalCount1++; }                       
                        for (; LocalCount1 < LocalSpaceCountY; LocalCount1++) { Console.Write(" "); }

                        Console.Write(i);
                        Console.Write("|");
                    }
                    int LocalShit = i * j;
                    int LocalCount = 0;
                    for (; LocalShit >= 1;LocalShit /= 10) { LocalCount++; }
                    for (; LocalCount < count; LocalCount++) { Console.Write(" "); }
                    Console.Write(i*j);
                }
              
                Console.WriteLine();

            }





        }
    }
}
