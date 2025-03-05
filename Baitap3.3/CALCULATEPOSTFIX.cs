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

            foreach (var ele in postfix.Split(' ')) // Khi nhập mỗi phần tử phải có khoảng trắng (dấu cách)
            {
                if (double.TryParse(ele, out double num)) // Nếu là số, đẩy vào stack
                {
                    Mystacknumble.Push(num);
                }
                else
                {
                    // Kiểm tra stack có ít nhất 2 phần tử trước khi Pop

                    double right = Convert.ToDouble(Mystacknumble.Pop()); // Pop toán hạng thứ nhất
                    double left = Convert.ToDouble(Mystacknumble.Pop());  // Pop toán hạng thứ hai
                    double result = 0;

                    switch (ele)
                    {
                        case "+":
                            result = left + right;
                            break;
                        case "-":
                            result = left - right;
                            break;
                        case "*":
                            result = left * right;
                            break;
                        case "/":
                            if (right == 0)
                            {
                                throw new DivideByZeroException("Lỗi: Chia cho 0!");
                            }
                            result = left / right;
                            break;                       
                    }
                    Mystacknumble.Push(result);
                }
            }
            return Mystacknumble.Pop().ToString();
        }
    }
}
