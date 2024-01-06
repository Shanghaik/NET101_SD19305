namespace _2_Bien_KieuDulieu_NhapXuat
{
    // Khái niệm
    /*
     * Biến là gì? Biến được tạo ra để lưu trữ các gì trị với 
     * 1 kiểu dữ liệu nào đó. Kiểu dữ liệu cho phép chúng ta xác
     * định loại dữ liệu mà biến đó sử dụng, có một số loại kiểu dữ
     * liệu phổ biến như: int, long, short, float, double, string,...
     * Giới hạn của dữ liệu: 
     * int: int32 - 32 bit có miền giá trị từ -2^31 đến 2^31-1
     * long: int64 - 64 bit có miền giá trị từ -2^63 đến 2^63
     * Nhập xuất dữ liệu: Trong nnlt C#, dữ liệu có thể được nhập 
     * vào từ bàn phím của chương trình thông qua phương thức 
     * Console.ReadLine() phương thức này trả về 1 chuỗi (string)
     * Cú pháp để in dữ liệu ra màn hình là Console.WriteLine()
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xác định đầu ra là Unicode
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Xác định đầu vào là Unicode
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //Console.WriteLine("Hãy nhập tên của người yêu cũ");
            //string tenNYC = Console.ReadLine();
            //Console.WriteLine(tenNYC);
            //Console.WriteLine("Hãy nhập tiếp xem sao");
            //int z = Console.Read();
            //Console.Write(Convert.ToChar(z));
            // Ép kiểu và nhập dữ liệu
            // Ép kiểu được sinh ra để chuyển đổi dữ liệu từ kiểu này
            // sang kiểu khác để phù hợp với mục đích lập trình
            // Ép kiểu tường minh/trực tiếp là khi chúng ta sử dụng các
            // hàm, phương thức để thực hiện ép kiểu
            int x; // Khai báo biến x kiểu int
            int y = 10; // Khởi tạo biến y có giá trị là int 10
            Console.WriteLine("Hãy nhập dữ liệu");
            //string dulieunhap = Console.ReadLine();
            //x = int.Parse(dulieunhap); // Nếu dữ liệu null -> Lỗi
            //x = Convert.ToInt32(dulieunhap);// Null -> 0
            //Console.WriteLine(x);
            // Nhập tên, tuổi, nhập cân nặng của bạn trai người yêu cũ
            Console.WriteLine("Hãy nhập tên của bạn trai NYC");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhập tuổi của bạn trai NYC");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập cân nặng của bạn trai NYC");
            double can = Convert.ToDouble(Console.ReadLine());
            // float t = 1.6F;
            // Cách 1 sử dụng dấu + 
            Console.WriteLine("Tên: " + ten + " Tuổi: " + tuoi + " Nặng: " + can);
            // Format code: Ctrl K D, comment Ctrl K C, bỏ comment Ctrl K U
            // Dulicate Code: Ctrl D, Xóa toàn bộ Code Ctrl A Delete
            // Ép kiểu Ngầm được chương trình tự động ép từ kiểu dữ liệu có phạm vi
            // biểu diễn nhở hơn sang kiểu dữ liệu có phạm vi biểu diễn lớn hơn
            // Cách 2 sử dụng các dấu {} và số
            Console.WriteLine("Tên: {0} Tuổi: {1} Nặng: {2}", ten, tuoi, can);
            // Cách 3 sử dụng $ để nhúng thẳng biến vào string
            Console.WriteLine($"Tên: {ten}, Tuổi: {tuoi}, cân nặng: {can}");
        }
    }
}