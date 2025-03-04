using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3._3
{
    class CALCULATEPOSTFIX
    {
        public static string CalculatePostfix(string postfix)
        {
            CREATESTACK.MyStack Mystacknumble = new CREATESTACK.MyStack();
            foreach (string ele in postfix.Select(c => c.ToString()))
            {
                if (double.TryParse(ele, out double num)) // Kiểm tra nếu là số
                {
                    Mystacknumble.Push(num);
                }
                else 
                {
                    double num1 = (double)Mystacknumble.Pop(); // số bên phải
                    double num2 = (double)Mystacknumble.Pop(); // số bên trái
                    double result = 0;
                    switch (ele)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                    }
                    Mystacknumble.Push(result);
                }
            }
            return Mystacknumble.Pop().ToString();
        }
    }
}
