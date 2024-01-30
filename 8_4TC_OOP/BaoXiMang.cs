using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4TC_OOP
{
    public class BaoXiMang : BaoTai // : thể hiện sự kế thừa
    {
        // Khi kế thừa, tất cả các thành phần của lớp cha sẽ được lớp
        // con dùng lại bao gồm thuộc tính, constructor, method
        string hangSX; 
        // BaoXiMang sẽ có 6 thuộc tính bao gồm 5 thuộc tính của BaoTai
        // và 1 của chính nó
        public void Test()
        {
            Console.WriteLine(ma);
            Console.WriteLine(ten);
            Console.WriteLine(giaban);
            Console.WriteLine(ngaysx); 
            // Dùng được vị protected có thể sử dụng được ở class kế thừa 
        }
    }
}
