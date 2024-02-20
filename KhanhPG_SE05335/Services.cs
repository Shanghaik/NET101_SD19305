using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhPG_SE05335
{
    internal class Services
    {
        List<Nganhhoc> list = new List<Nganhhoc>(); // cho ở đây luôn nếu sợ quên
        public Services()
        {
            list = new List<Nganhhoc>(); // Khởi tạo trong constructor
        }
        // Các phương thức chức năng
        public void NhapDS() // 1.5
        {
            Console.WriteLine("Ban muon nhap bao nhieu nganh?");
            int soluong = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < soluong; i++)
            {
                // tạo đối tượng và thêm vào List
                Nganhhoc nh = new Nganhhoc();
                Console.WriteLine("Nhap id: ");
                nh.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhap ten");
                nh.Ten = Console.ReadLine();
                Console.WriteLine("Nhap so ki");
                nh.Sokihoc = Convert.ToInt32(Console.ReadLine());
                // Thêm vào List
                list.Add(nh);
            }
            Console.WriteLine("Ban muon nhap tiep khong? Nhap Y neu tiep tuc, con lai la khong");
            string choose = Console.ReadLine();
            if (choose == "Y") NhapDS(); // Gọi lại chính hàm này để nhập tiếp
            else return; // Dòng này có cho nó đẹp thôi =)))), return để kết thúc lệnh
        }
        // Xuất danh sách
        public void XuatDS() // 1
        {
            if (list.Count == 0) // Kiểm tra xem List có rỗng hay không?
            {
                Console.WriteLine("List dang rong, hay nhap vao di");
                NhapDS(); // Nhập
                XuatDS(); // Nhập xong thì xuất
            }
            foreach (var item in list) // var là từ khóa xác định 1 biến có thể chứa mọi kiểu dữ liệu
            {
                item.InThongTin();
            }
        }
        // Xuất kì học > 6
        public void XuatDSHon6() // 1
        {
            if (list.Count == 0) // Kiểm tra xem List có rỗng hay không?
            {
                Console.WriteLine("List dang rong, hay nhap vao di");
                NhapDS(); // Nhập
                XuatDSHon6(); // Nhập xong thì xuất
            }
            foreach (var item in list) // var là từ khóa xác định 1 biến có thể chứa mọi kiểu dữ liệu
            {
                if (item.Sokihoc > 6) item.InThongTin(); // Kiểm tra điều kiện và in ra
            }
        }
        // Xóa cách 1 với for
        public void XoaC1()
        {
            Console.WriteLine("Nhap ten ban can xoa");
            string ten = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Ten == ten) { 
                    list.RemoveAt(i); 
                    i--; // i-- để cập nhật vị trí cần check khi xóa
                }
            }
            XuatDS();
        }
        public void XoaC2()
        {
            Console.WriteLine("Nhap ten ban can xoa");
            string ten = Console.ReadLine();
            foreach (var item in list.ToList())// list và list.ToList() là 2 đối tượng khác nhau
            {
                // list.ToList() dừng để đối chiếu khi cần xóa
                // list mới là đối tượng đang được trỏ đến
                if (item.Ten == ten) list.Remove(item);
            } // khi duyệt foreach, thì list không thể bị thay đối => nếu khong sẽ lỗi
            XuatDS();
        }
    }
}
