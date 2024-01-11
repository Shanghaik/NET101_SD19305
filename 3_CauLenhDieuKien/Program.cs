namespace _3_CauLenhDieuKien
{
    // Câu lệnh điều kiện (Condition Statement) là những biểu thức, cấu trúc
    // được xây dựng nhằm xử lý và đưa ra kết quả cho những điều kiện mà
    // kết quả là 1 giá trị boolean (true/false) bao gồm các loại cơ bản là"
    // if/else, switch-case, toán tử 3 ngôi
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sử dụng if-else để in ra học lực thông qua số điểm biết
            // 0-> <5 là tạch, 5 đến <6.5 Trung bình, 6.5 đến dưới 8 Khá, cao
            // hơn là giỏi
            Console.WriteLine("Nhập điểm số");
            double grade = Convert.ToDouble(Console.ReadLine());
            if(grade < 0 || grade > 10)
            {
                Console.WriteLine("Wrong number");
            }
            else if (grade < 5 && grade >= 0)
            {
                Console.WriteLine("Chúc mừng bạn đã được trải nghiệm thêm");
            }
            else if (grade < 6.5) {
                Console.WriteLine("May quá pass với điểm TB");
            }else if(grade < 8)
            {
                Console.WriteLine("You're quite good grade");
            }else 
            {
                Console.WriteLine("You're Goodboy");
            }
            // Khi các điều kiện trong câu lệnh if/else là chặt (không có nhiều hơn
            // 1 trường hợp else) thì chùng ta có thể giản lược đi các điều kiện chặn
        }
    }
}