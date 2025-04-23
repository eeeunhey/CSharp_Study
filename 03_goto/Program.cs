using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            //switch 에서 goto문 
            {
                switch(num)
                {
                    case 10:
                        Console.WriteLine($"goto num : {num}");
                        break;

                    case 100:
                        goto case 10;
                        // case 10으로 감

                    default:
                        break;
                }

            }

            //for문 에서 goto문
            //특정 식별지를 지정하면 그쪽으로 보낸다
            {
                for(int i =0; i<100; i++ )
                {
                    Console.WriteLine($"i : {i}");

                    if( i == 10)
                    {
                        goto Finish;
                    }
                }

            Finish:
                Console.WriteLine("\n i : GOTO Finish :");
            }
        }
    }
}
