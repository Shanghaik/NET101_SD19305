namespace _6_Ham_Function
{
    /*
     * Hàm-function là một tập hợp những đoạn code được sử dụng đê
     * thực hiện những nhiệm vụ nào đó.
     * Hàm sẽ nằm bên ngoài hàm Main và nằm trong class
     * Hàm có thể gọi được nhiều lần thông qua Tên
     * Hàm có các thành phần chính bao gồm: Tên, kiểu trả về và tham
     * số truyền vào - Chữ kí hàm
     * Tên hàm sẽ được viết hoa các chữ cái đầu của mỗi từ
     * Kiểu trả về có thể là int, string, double,... hoặc không trả 
     * về void
     * Tham số - Parameter là những gì được truyền vào cho phép sử dụng
     * ngay trong phần thân hàm
     */
    internal class Program
    {
        // 1. Không trả về - không tham số
        static void NhapXuat()
        {
            Console.WriteLine("Nhập tên của bạn");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhập tuổi");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập giới tính");
            string gioitinh = Console.ReadLine();
            if (tuoi >= 14) Console.WriteLine($"Công dân {ten} đã đủ tuổi chịu TNHS");
            else Console.WriteLine($"Công dân {ten} chưa đủ tuổi chịu TNHS");
            if (tuoi >= 20 && gioitinh == "Nam" || tuoi >= 18 && gioitinh == "Nu")
            {
                Console.WriteLine($"{gioitinh} công dân {ten} đã có thể đăng ký kết hôn");
            }
            else
            {
                Console.WriteLine($"{gioitinh} công dân {ten} chưa thể đăng ký kết hôn");
            }
        }
        //  Hàm không trả về có tham số - tính tổng của 2 số
        static void TinhToan(int a, int b) // a và b là tham số Parameter
        {
            Console.WriteLine($"Tổng của 2 số {a} và {b} là {a + b}");
            Console.WriteLine($"Hiệu của 2 số {a} và {b} là {a - b}");
            Console.WriteLine($"Tích của 2 số {a} và {b} là {a * b}");
            if (b == 0)
            {
                Console.WriteLine("Không thể chia cho 0");
            }
            else
                Console.WriteLine($"Thương của 2 số {a} và {b} là {a * 1.0 / b}");
        }
        // Có trả về - không tham số
        static int TinhTongMang()
        {
            Console.WriteLine("Nhập kích thước của mảng");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size]; // Khởi tạo mảng có kích thước đã nhập
            int tong = 0;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Nhập phần tử thứ {i + 1}"); // Mảng bắt đầu từ 0
                arr[i] = Convert.ToInt32(Console.ReadLine());
                tong += arr[i]; // Nhập xong cộng nó vào tổng luôn
            }
            return tong;
        }
        // Có trả về có truyền vào
        static string NhatKyYeuThuong(int soluongnyc)
        {
            if (soluongnyc == 0) return "Chúc mừng thí chủ chưa vướng bụi trần ai";
            string ketqua = "";
            Console.WriteLine("Nhập tên các NYC");
            for (int i = 0; i < soluongnyc; i++)
            {
                Console.WriteLine("Nhập tên NYC");
                string ten = Console.ReadLine();
                ketqua += ten + " ";
            }
            return "Bạn đã từng hẹn hò với những người sau: " + ketqua;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            // NhapXuat();
            // TinhToan(5, 10); // 5 và 10 là đối số (Argument)
            // Khi được gọi lại, hàm trả về được sử dụng như giá trị
            // Console.WriteLine(TinhTongMang());
            Console.WriteLine(NhatKyYeuThuong(0));
        }
    }

}