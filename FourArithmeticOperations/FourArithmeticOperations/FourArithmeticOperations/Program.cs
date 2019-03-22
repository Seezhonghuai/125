using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourArithmeticOperations
{
    class Program
    {    
        static void Main(string[] args)
        {
            Console.WriteLine("随机生成10道四则运算");
            Console.ReadLine();
            Random number = new Random(); //实例化一个随机数           
            string[] op = new string[] { "＋", "－", "*", "÷" };//定义一个符号数组a
            for (int i = 0; i < 10; i++)
            {
                int num1 = number.Next(1, 10);//随机一个10以内的数。
                int num2 = number.Next(1, 10);//随机一个10以内的数。
                int opnext = number.Next(0, 4);//随机抽取一个 "＋", "－", "*", "÷" 符号题目呀
                int num3 = number.Next(2, 10);
                int s = 0;
                s = Math.Abs(s);//绝对值函数
                if (num1 < num2)//如果左边的数小于右边的数就置换过来，避免负数的出现。
                {
                    num2 = num3;
                    num1 = num2;
                }
                switch (opnext)
                {
                    case 0:
                        s = num1 + num2;
                        break;
                    case 1:
                        s = num1 - num2;
                        break;
                    case 2:
                        s = num1 * num2;
                        break;
                    case 3:
                        s = num1 / num2;
                        break;
                }
                Console.WriteLine(num1 + op[opnext] + num2 + "=" + s);//输出公式
            }
            Console.ReadKey();

        }
    }


}

