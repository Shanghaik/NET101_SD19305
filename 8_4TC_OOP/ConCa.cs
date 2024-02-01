using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4TC_OOP
{
    internal class ConCa
    {
        string loai;
        string noisong;
        string mota;
        public string Loai { get => loai; set => loai = value; }
        public string Noisong { get => noisong; set => noisong = value; }
        public string Mota { get => mota; set => mota = value; }
        public ConCa()
        {
        }
        public ConCa(string loai, string noisong, string mota)
        {
            this.loai = loai;
            this.noisong = noisong;
            this.mota = mota;
        }
        public void InThongTin()
        {
            Console.WriteLine($"Cá này thuộc loài: {loai}, sống tại {noisong}, đặc điểm {mota}");
        }
        // Tính đa hình: Là tính chất thể hiện sự khác nhau giữa cùng 1 hành động (phương thức)
        // của các đối tượng khác nhau hay cùng 1 đối tượng nhưng khác trạng thái
        public virtual void Boi() // từ khóa virtual đánh dấu 1 phương thức có thể bị ghi đè
        {
            Console.WriteLine("Con cá bơi trong nước");
        }
    
    }
}
