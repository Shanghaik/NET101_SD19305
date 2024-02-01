using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4TC_OOP
{
    internal class CaChep : ConCa
    {
        // Thuộc tính
        double cannang;
        string chungloai;
        // CaChep có 5 thuộc tính bao gồm cả 3 thuộc tính của lớp ConCa
        
        public double Cannang { get => cannang; set => cannang = value; }
        public string Chungloai { get => chungloai; set => chungloai = value; }
        public CaChep()
        {
        }
        public CaChep(double cannang, string chungloai)
        {
            this.cannang = cannang;
            this.chungloai = chungloai;
        }

        public CaChep(string loai, string noisong, string mota, double cannang, string chungloai) : base(loai, noisong, mota)
        {
            this.cannang = cannang;
            this.chungloai = chungloai;
        }
        // base là trỏ tới thành phần của lớp cha, cụ thể ở đây là constructor
        // Generate constructor full thuộc tính (5)
        // Bước 1: Tạo constructor bao gồm các thuộc tính của lớp cha. Ctrl . => Generate... của lớp cha
        // Bước 2: Bôi đen các thuộc tính của lớp con => Ctrl . => add parameter to constructor => chọn
        // Cách 2: Tự mà viết =))
         
        // Kế thừa phương thức
        public void XuatThongTin()
        {
            base.InThongTin();  // base trong trường hợp là trỏ tới phương thức của lớp cha
            Console.WriteLine($"Nặng {cannang}, thuộc chủng loại {chungloai}");
        }
        // Trong C# không có đa kế thừa với class tức là 1 lớp chỉ có thể kế thừa từ duy nhất
        // 1 lớp cha. Tuy nhiên 1 lớp có thể kế thừa từ nhiều interface
        public void An()
        {
            Console.WriteLine("Cá chép ăn chìm");
        }
        public void An(string doan)
        {
            if (doan == "Chay")
            {
                Console.WriteLine("Cá sắp đắc đạo");
            }
            else Console.WriteLine("Con cá phàm tục");
        }
        // CÙng là hành động An của cá chép nhưng với những điều kiện khác nhau thì thể hiện
        // khác nhau => Overload 
        // Điều kiện để overload: Các phương thức cùng class, cùng tên và kiểu trả về, khác
        // tham số truyền vào
        public override void Boi() // ghi đè phương thức Boi của lớp ConCa
        {
            // base.Boi(); // Mặc định sẽ base theo phương thức của lớp cũ
            // Viết lại phần thân để định nghĩa lại hàm
            Console.WriteLine("Cá chép bơi bằng cách quẫy đuôi và vây");
        }

    }
}
