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



            int x = 35;
            int y = 30;
            int count = 1;
            int xy = x * y;
            int LocalSpaceCount1 = 0;
            int LocalSpace1 = x;
      
            for(; LocalSpace1 >= 1; LocalSpace1 /= 10) { LocalSpaceCount1++; }
            for (; xy >= 1; count++, xy /= 10) ;
            for (int fuck = 0; fuck <= LocalSpaceCount1; fuck++) { Console.Write(" "); }
           
            for (int lenghth = 1; lenghth <= x; lenghth++)
            {
                
               
                int LocalCount = 0;
                int LocalShit = lenghth;
                

                for (; LocalShit >= 1; LocalShit /= 10) { LocalCount++; }
                for (; LocalCount < count; LocalCount++) { Console.Write(" "); }
                Console.Write(lenghth);


            }
            Console.WriteLine();



            for (int i = 1; i <= y; i++)
            {
                if (i == 1) { for (int k = 0; k <= count* x+LocalSpaceCount1; k++) { Console.Write("_"); } Console.WriteLine(); }

                for (int j = 1; j <= x; j++)
                {

                    if (j == 1)
                    {
                        Console.Write(i);
                        int LocalCount1 = 0;
                        int LocalShit1 = i;
                        int LocalSpace = x;
                        int LocalSpaceCount = 0;

                        for (; LocalShit1 >= 1; LocalShit1 /= 10) { LocalCount1++; }
                        for (; LocalSpace >= 1; LocalSpace /= 10) { LocalSpaceCount++; }
                        for (; LocalCount1 < LocalSpaceCount; LocalCount1++) { Console.Write(" "); }

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
