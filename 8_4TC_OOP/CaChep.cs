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

    }
}
