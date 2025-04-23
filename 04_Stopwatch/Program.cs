using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //원하는 결과 (시간)을 측정한다

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            int i = 0;
            for ( ; i<int.MaxValue; i++ )
            {
                if (i== 50000000)
                {
                    break;
                }
                //Console.WriteLine($"{i} ");
            }

            Console.WriteLine($"{i} ");

            if(sw.IsRunning)
            {
                sw.Stop();

                Console.WriteLine($"time : {sw.ElapsedMilliseconds.ToString()} ms");
                Console.WriteLine($"time : {sw.Elapsed.ToString()}");
                Console.WriteLine($"time : {0 : hh\\:mm\\:ss}",sw.Elapsed);
            }
        }
    }
}
