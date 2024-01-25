using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP
{
    internal class Sinhvien
    {
        // Khai báo các thuộc tính
        private string maSv; // Mặc định là private
        string chuyennganh = "UDPM"; // đây cũng là gán gí trị mặc định
        string ten;
        string sdt;
        int tuoi;
        string email;
        // Các property Bôi đen tất cả các thuộc tính -> Ctrl . (căn trôn chấm)
        // Chọn Encapsulate Field and use Property
        // get - lấy giá trị của thuộc tính, set - gán giá trị cho thuộc tính
        public string MaSv { get => maSv; set => maSv = value; }
        public string Chuyennganh { get => chuyennganh; set => chuyennganh = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Email { get => email; set => email = value; }
        // Constructor - Dùng để tạo ra các thuộc tính cho đối tượng, có 2 loại là không tham số
        // và có tham số
        // Không tham số gõ CTOR tab tab
        public Sinhvien() // Tạo ra các thuộc tính có giá trị mặc định - được quy ước nếu không được định nghĩa
        {
            this.tuoi = 18; // Gán giá trị mặc định
            this.chuyennganh = "TMDT"; // Giá trị trong constructor sẽ được ưu tiên
        }
        // Constructor có tham số dùng để gán các giá trị được truyền vào cho các thuộc tính
        public Sinhvien(string maSv, string chuyennganh, string ten, string sdt, int tuoi, string email)
        {
            this.maSv = maSv; // this là bản thân của class
            this.chuyennganh = chuyennganh;
            this.ten = ten; // cần phân biệt được cái nào là param và cái nào là thuộc tính
            this.sdt = sdt; // this.sdt là thuộc tính còn sdt ở vế bên phải là giá trị của tham số
            this.tuoi = tuoi;
            this.email = email;
        }
        // Constructor có tham số
        // Cách 1: Bôi đen thuộc tính cần tạo, Ctrl ., Chọn generate constructor ....
        // Cách 2: Ấn vào màn hình, ctrl ., Generate constructor => Chọn các thuộc tính -> OK
        
        // Các phương thức của đối tượng (method) - thể hiện các hành động của đối tượng
        // Phương thức có cấu tạo giống hệt các function nhưng nó phải đi kèm với class
        public void XuatThongTin()
        {
            Console.WriteLine($"Tôi là: {ten}, học ngành : {chuyennganh}");
            Console.WriteLine($"Tôi có mã: {maSv}, tôi : {Tuoi} tuổi");
            Console.WriteLine($"Liên hệ với tôi qua SĐT: {sdt}, email : {Email}");
        }
        // Khi chúng ta sử dụng Tuoi thay vì tuoi thì về bản chất Tuoi vẫn được trỏ về tuoi
        // 2 cách dùng này như nhau và đều cho ra 1 giá trị
        public void KeHoach()
        {
            Console.WriteLine($"Tôi sẽ ra trường lúc {tuoi+2} tuổi");
            Console.WriteLine($"Tôi sẽ làm đúng chuyên ngành là : {chuyennganh}");
        }
    }
}
