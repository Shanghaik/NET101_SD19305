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
            sv2.KeHoach();
            // Sử dụng Property (get, set) để thao tác với thuộc tính
            sv2.Ten = "Lê Văn X"; // Dùng set để gán giá trị
            sv2.Email = "abc@gmail.com.vn";
            sv2.Sdt = "0123456789";
            sv2.XuatThongTin();
            // Dùng get để lấy giá trị (Cả get và set đều dùng dấu .)
            Console.WriteLine("Tên sinh viên 2 là: " + sv2.Ten);
        }
    }
}