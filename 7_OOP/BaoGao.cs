using _8_4TC_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP
{
    internal class BaoGao : BaoTai
    {
        public void TestKeThua()
        {
            Console.WriteLine(ma);
            // Console.WriteLine(ten); // internal - khác Project ko dùng dc
            // Console.WriteLine(soluong); // private
            Console.WriteLine(ngaysx); // protected- kế thừa dùng đc
            Console.WriteLine(giaban); // protected internal - được
        } 
    }
}
