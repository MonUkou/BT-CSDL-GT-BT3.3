using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Timing t = new Timing();
            
            int n = 1000000;
            Console.WriteLine("Mời bạn nhập biểu thức Postfix: ");
            string postfix = postfix = Console.ReadLine();
            double result = 0;

            t.StartTime();
            for (int i = 0; i < n; i++)
            {
                result = Convert.ToDouble(CALCULATEPOSTFIX.CalculatePostfix(postfix));
            }
            t.StopTime();

            Console.WriteLine("Kết quả của biểu thức Postfix là: " + result);
            Console.WriteLine("Thời gian thực thi là: " + t.Result().TotalMilliseconds + " ms");
        }
    }
}
