using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_break
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //break 기초
                Console.WriteLine("\n break 기초");

                for (int i = 0; i < 10; i++)
                {
                    if (i == 5) break;

                    Console.WriteLine($" i:{i}");
                }

                int num = 0;
                while (true)
                {
                    if (++num > 10) break;

                    Console.WriteLine($"num : {num}");
                }

                switch (num)
                {
                    case 11:
                        Console.WriteLine($"num : {num}");
                        break;

                    default:
                        break;

                }
            }

            {
                Console.WriteLine($"대문자 소문자 출력 ");

                int numA = 65; //아스키 코드 A
                int length = (90 - numA); // 90에서 numA를 뺏으니 Z
                int SmallAlpha = 97;       //small A 
                int SmallAlphalength = SmallAlpha + length; //small Z를 출력
                                                            // length를 가져오는건 이미어차피 A-Z의 길이를 가져온다                                                        

                for (int i = 0; i <= length; i++) //
                {
                    Console.Write($"{(char)(numA + i)}  ");
                    //numA + i A부터 증가하면서 Z까지 가져옴
                    //char 강제로 형변환
                    for (int j = SmallAlpha; j <= SmallAlphalength; j++)// j가 증가하면서 스몰알파 a~z까지 가져옴
                    {
                        if ((numA + i) == j - 32) //  대문자 A : 65 == (j = 97-32 = 65)
                        {
                            Console.Write($"{(char)j}  ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            {
                //continue 기초
                {
                    Console.WriteLine($" \n continue 기초");

                    int num = 0;

                    for (int i = 0; i < 10; i++)
                    {
                        if (i == 5 || i == 7 || i == 9) // 5 ,7,9 면 계속해 안내려감
                        {
                            continue;

                        }
                        Console.WriteLine("i : " + i);
                    }

                }

                {
                    Console.WriteLine($"\n대문자 소문자 출력 ");

                    int numA = 65; //아스키 코드 A
                    int length = (90 - numA); // 90에서 numA를 뺏으니 Z
                    int SmallAlpha = 97;       //small A 
                    int SmallAlphalength = SmallAlpha + length; //small Z를 출력
                                                                // length를 가져오는건 이미어차피 A-Z의 길이를 가져온다                                                        

                    for (int i = 0; i <= length; i++) //
                    {
                        Console.Write($"{(char)(numA + i)}  ");
                        //numA + i A부터 증가하면서 Z까지 가져옴
                        //char 강제로 형변환
                        for (int j = SmallAlpha; j <= SmallAlphalength; j++)// j가 증가하면서 스몰알파 a~z까지 가져옴
                        {
                            if ((numA + i) == j - 32) //  대문자 A : 65 == (j = 97-32 = 65)
                            {
                                //Console.Write($"{(char)j}  ");
                                Console.Write($"{(char)(numA + i)}  ");
                                continue;
                            }
                            Console.Write($"{(char)j}  ");

                        }
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}