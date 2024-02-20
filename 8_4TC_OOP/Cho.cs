using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4TC_OOP
{
    internal abstract class Cho // Lớp abstract là lớp trừu tượng
    {
        /*
         * Khi 1 lớp được đánh dấu là trừu tượng thì chúng ta đang nói tới việc lớp đó
         * chứa các thành phần trừu tượng (không rõ ràng) cà cần định nghĩa ở các lớp
         * kế thừa từ nó để có thể được sử dụng
         * Class abstract là trừu tượng nhbuwng không hoàn toàn vì nó vẫn có thể chứa 
         * các thành phần không trừu tượng
         */
        public void In()
        {
            Console.WriteLine("thích thì in ra thôi");
        }
        public abstract void ThongBao(); // Phương thức abstract không có phần thân
        // khi cần sử dụng bắt buộc phải được override lại
    }
}
