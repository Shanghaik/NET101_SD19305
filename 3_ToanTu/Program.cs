using System.Runtime.Intrinsics.X86;

namespace _3_ToanTu
{
    /*
     * Trong lập trình, toán tử là các kí hiệu được sử dụng để
     * đánh dấu các phép tính, biểu thức mà thông qua đó chương
     * trình có thể biên dịch và chạy được. Toán tử là thành phần
     * thiết yêu bắt buộc phải có với mọi ngôn ngữ lập trình.
     * Có nhiều cách để chúng ta phân loại toán tử. 
     * Chúng ta có thể phân loại theo chức năng:
     * - Số học (Những toán tử được dùng để tính toán)
     * - Logic (&& || !) thực hiện các nguyên lí logic
     * - Quan hệ (Thể hiện quan hệ giữa các mệnh đề)
     * - Gán (=, +=, -=, *=, /=) gán giá trị
     * ...
     * Cũng có thể phân loại theo ngôi
     * - 1 ngôi: Khi toán tử tác động trực tiếp tới chủ thể duy nhất (++, --,..)
     * - 2 ngôi: Khi toán tử tác động trực tiếp tới 2 chủ thể (+ - * /,...)
     * - 3 ngôi: Khi toán tử tác động tới 3 chủ thể ( ? : )
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xác định đầu ra là Unicode
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            // Xác định đầu vào là Unicode
            Console.InputEncoding = System.Text.Encoding.Unicode;
            // 1. Khai báo 2 biến a và b kiểu số nguyên và thực hiện việc tính các phép
            // +, -, *, / hai số đó cho nhau (kết quả phải chính xác)
            //Console.WriteLine("Nhập số a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Nhập số b:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{a}+{b}={a + b}");
            //Console.WriteLine($"{a}-{b}={a - b}");
            //Console.WriteLine($"{a}*{b}={a * b}");
            //Console.WriteLine($"{a}/{b}={a * 1.0 / b}");
            // Khi ta thực hiện phép toán a * 1.0 thì bản chất kết quả thu được
            // là một số thực (ép kiểu ngầm), kết quả a * 1.0 / b cũng vậy
            // 2. Thực hiện các phép toán ++, --, *=, /=
            // với 2 biến x, y kiểu double
            Console.WriteLine("Nhập x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập y");
            double y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Tăng x lên 1 đơn vị " + x++);
            //Console.WriteLine("Giảm y đi 1 đơn vị " + y--);
            Console.WriteLine("Tăng x lên 1 đơn vị "+ ++x);
            Console.WriteLine("Giảm y đi 1 đơn vị " + --y);
            Console.WriteLine($"x và y sau khi tăng/giảm là: {x}, {y}");
            // Lưu ý: Phép y-- hoặc x++ sẽ thực hiện việc thay đổi giá trị
            // của x và y sau khi câu lệnh chứa biểu thức này đã được thực thi
            // Còn phéo --y/++x sẽ thực hiệc tăng giá trị trước khi thực thi câu
            // lệnh in. Khi các câu lệnh này được viết song song thì ưu tiên việc
            // thực thi ++x và --y trước x++ và y--
            // Console.WriteLine($"{x++},{++x},{--x},{x--},{--x}"); // Làm quen/mở rộng
            // Gán x = x/y
            Console.WriteLine($"{x} sau khi tăng {y} lần là {x *= y}");
            // 3. Thực hiện phép tính a ^ b với hàm Pow sau đó thực hiên phép
            // tính căn bậc b của a với hàm pow
            Console.WriteLine("Nhập a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{a}^{b}={Math.Pow(a, b)}");
            // ÁP dụng công thức căn bậc b của a = a^(1/b)
            Console.WriteLine($"Căn bậc {b} của {a}={Math.Pow(a, 1/b)}");
            // Tính logarit với hàm log
            Console.WriteLine(Math.Log(6));
            Console.WriteLine(Math.Log10(1000));
            Console.WriteLine(Math.Log2(8));

        }
    }
}