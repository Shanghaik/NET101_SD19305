using _8_4TC_OOP;

namespace _7_OOP
{
    /*
     * OOP là gì? Viết tắt của Object Oriented Programing - Lập trình
     * hướng đối tượng. Đây là phương pháp lập trình sử dụng các đối
     * tượng (object) làm trung tâm để thực hiện triển khai các chương
     * trình. 1 đối đối tượng sẽ có các thành phần sau:
     * - Các thuộc tính - mô tả đối tượng
     * - Các hành động (Thể hiện qua các Method) - Các tương tác
     * - Hàm tạo (Constructor) - Để tạo đối tượng với các thuộc tính nào đó
     * Lớp (Class) là một mô tả để đại diện cho 1 loại đối tượng cụ thể
     * mỗi đối tượng được gọi là 1 instance của class (thể hiện). VD Mỗi sinh
     * viên là 1 thể hiện của class Sinhvien
     * Trong OOP có 4 tính chất (Bao đóng, Kế thừa, Đa hình, Trừu tượng)
     * Chúng ta cần phân biệt được giữa class và file vật lý (.cs) bởi vì 
     * thông thường 1 class sẽ nằm trong 1 file vật lý. Trong 1 file vật lý
     * file .cs có thể có nhiều class nằm trong
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Khai báo đối tượng, nếu chỉ khai báo, đối tượng null
            Sinhvien sv1;
            // sv1.KeHoach(); // Lỗi
            // Khởi tạo đối tượng = constructor không tham số
            Sinhvien sv2 = new Sinhvien();
            // Có thể gọi phương thức hoặc Property thông qua dấu .
            //sv2.KeHoach();
            //// Sử dụng Property (get, set) để thao tác với thuộc tính
            //sv2.Ten = "Lê Văn X"; // Dùng set để gán giá trị
            //sv2.Email = "abc@gmail.com.vn";
            //sv2.Sdt = "0123456789";
            //sv2.XuatThongTin();
            //// Dùng get để lấy giá trị (Cả get và set đều dùng dấu .)
            //Console.WriteLine("Tên sinh viên 2 là: " + sv2.Ten);
            // Dùng Constructor có tham số để đưa ra thông tin
            Sinhvien sv3 = new Sinhvien("PH1234", "QTHT", "Lên Văn Cắp", "111", 18, "a2@gmail.com");
            // Sau khi được khởi tạo, các thuộc tính của đối tượng sẽ mang đúng các giá trị được gán
            sv3.XuatThongTin();
            // Gán 1 đối tượng bằng đối tượng khác
            Sinhvien sv4 = sv3;
            sv4.XuatThongTin();
            // Nếu sửa sv3 thì sv4 có thay đổi theo không?
            sv3.Ten = "Tên đã đổi";
            sv4.XuatThongTin();
            // Class là 1 trong các loại references type (Kiểu tham chiếu)
            // Khi Sinhvien sv4 = sv3; thì bản chất ta chỉ tạo ra 1 biến sv4 trỏ về vùng nhớ lưu
            // thông tin của sv3
            // BaoTai bt = new BaoTai();
            BaoTai bt = new BaoTai();
            Console.WriteLine(bt.ma); // truy cập được
            // Console.WriteLine(bt.ten); 
            // Không dùng được vị internal chỉ trong cùng 1 project
        }
    }
}