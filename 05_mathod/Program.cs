using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_mathod
{
    class Program
    {
        // 파라미터 x 리턴x
        // 파라미터 o 리턴x
        // 파라미터 o 리턴o
        // 파라미터 x 리턴o
        // main 안에서 돌리기 위해서 메인 밖에 함수 선언
        //static main 안에 돌아감 void 리턴 결과가 없다
        // 파라미터는 입력값 printHello ()

        static void PrintHello() // 파라미터 x 리턴x
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("Hello");
        }

        static void PrintValue(int x) // 파라미터 o 리턴x
        {
            Console.WriteLine($"PrintValue : {x} ");
        }

        static void Sum(int x, int y) // 파라미터 o 리턴o
        {
            Console.WriteLine($"PrintValue : {x} + {y}  = {x + y} ");
        }

        static int GetMaxInt() // void가 아닌 리턴형식을 적음 // 파라미터 x 리턴o
        {
            return int.MaxValue;
        }

        static int ReturnSum(int x, int y) //파라미터 o, 리턴 o
        {
            int total = x + y;
            return total; //대입연산자 내보냄

        }

        struct SSudent
        {
            int _id;
            string _name;

            public SSudent(int id, string name)
            {
                _id = id;
                _name = name;

            }

            public int GetId()
            {
                return _id;
            }

            public string GetName()
            {
                return _name;
            }

            public void SetID(int id)
            {
                _id = id;
            }

            public void SetName(string name)
            {
                _name = name;

            }

            public void PrintDate()
            {
                Console.WriteLine($"id : {_id}   name : {_name}");
            }
        }

        static void Main(string[] args)
        {
            PrintHello();
            //위에 있는 함수 호출

            PrintValue(10);
            //int 형으로 입력값 

            Sum(10, 100);

            int maxValue = GetMaxInt();
            Console.WriteLine($"maxValue : {maxValue}"); // 함수에서 

            int sumValue = ReturnSum(10, 100);
            Console.WriteLine($"sumValue : {sumValue}");

            SSudent[] Students = new SSudent[3];

            foreach (var item in Students)
            {
                item.PrintDate();
            }

            Students[0].SetID(0);
            Students[0].SetName("aa");

            Students[1] = new SSudent(1, "bb");
            Students[2] = new SSudent(1, "cc");

            foreach (var item in Students)
            {
                item.PrintDate();
            }

        }
    }
}


