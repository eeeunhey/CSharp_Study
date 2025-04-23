using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_array
{
    class Program
    {
        static void Main(string[] args)
        {

            //배열의 기초 //  
            {
                Console.WriteLine("배열의 기초");

                int[] arrays = new int[10];
                // 배열 저장할 형식  (int, string) 변수선언이름 = 
                // new 형식

                for (int i = 0; i < arrays.Length; i++)
                {
                    Console.WriteLine($"[{i}] : {arrays[i]} ");
                }

            }


            // 배열의 선언방법
            {
                Console.WriteLine("배열의 선언 방법");

                int[] array1 = { 0, 1, 2, 4 };
                int[] array2 = new int[] { 0, 1, 2, 4 };
                int[] array3;
                array3 = new int[] { 0, 1, 2, 3 };
                //array3 = { 0, 1, 2, 3 }; 에러남


                for(int i = 0; i<array1.Length; i++)
                {
                    Console.Write($"array1 [{i}] : {array1[i]}\n");
                }

                for (int i = 0; i < array2.Length; i++)
                {
                    Console.Write($"\narray2 [{i}] : {array2[i]}");
                }
                    Console.WriteLine();
                for (int i = 0; i < array3.Length; i++)
                {
                    Console.Write($"\narray3 [{i}] : {array3[i]}");
                }
            }
            Console.WriteLine();
            //배열의 지원되는 함수
            {
                Console.WriteLine("\n배열에서 지원되는 함수");

                int[] numbers = { 50, 36, 99, 67 };

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Numbers [{i}] : {numbers[i]}");
                }
            }

            // 배열의 복사
            {
                Console.WriteLine("배열의 복사 기능");

                int[] Copynum;
                Copynum = numbers.

            }
            }

        }
    }
}
