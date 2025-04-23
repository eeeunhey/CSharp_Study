using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_for
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.별찍기 7개
            //2줄바꿈하면서 별 출력
            //3.별줄이기
            //4. 중앙으로 옮기기

            for (int i = 0; i < 5; i++)
            {
                for(int k=0; k<i; k++)
                {
                    Console.Write(" ");
                }
                int mi = 7 - (i * 2);
                for (int j = 0; j < mi; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int j =1; j<5; j++)
            {
                
                for(int k=0; k<(4-j); k++)
                {
                    Console.Write(" ");
                }
                int pl = 2 * j - 1;
                for (int i=0; i<pl; i++)
                {
                     Console.Write("*");
                 }
                Console.WriteLine();
            }
        }
    }
}
