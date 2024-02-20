using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4TC_OOP
{
    internal class CaMuc : ConCa
    {
        public override void Boi() // Cũng ghi đè phương thức Boi của lớp cha
        {
            Console.WriteLine("Con mực bơi bằng vây và mồm");
        }
    }
}
