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
            //Console.WriteLine("Nhập điểm số");
            //double grade = Convert.ToDouble(Console.ReadLine());
            //if(grade < 0 || grade > 10)
            //{
            //    Console.WriteLine("Wrong number");
            //}
            //else if (grade < 5 && grade >= 0)
            //{
            //    Console.WriteLine("Chúc mừng bạn đã được trải nghiệm thêm");
            //}
            //else if (grade < 6.5) {
            //    Console.WriteLine("May quá pass với điểm TB");
            //}else if(grade < 8)
            //{
            //    Console.WriteLine("You're quite good grade");
            //}else 
            //{
            //    Console.WriteLine("You're Goodboy");
            //}
            // Khi các điều kiện trong câu lệnh if/else là chặt (không có nhiều hơn
            // 1 trường hợp else) thì chùng ta có thể giản lược đi các điều kiện chặn
            // 
            // Switch - case: Là 1 loại câu lệnh điều kiện nhưng điều kiện sẽ theo
            // các giá trị cụ thể 
            // Nhập tuổi của người yêu và đưa ra dự đoán
            //Console.WriteLine("Enter your's NY's age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //switch (age)
            //{
            //    case 15:
            //    case 16:
            //    case 17:
            //        Console.WriteLine("Opps! Police are watching you");
            //        break; // Lệnh dùng để dừng 1 cấu trúc
            //    case 18:
            //        Console.WriteLine("Happy, everybody cheer with you");
            //        break;
            //    case 60:
            //        Console.WriteLine("Congratulation! You're rich!!!");
            //        break;
            //    default:
            //        Console.WriteLine("No body will");
            //        break;
            //}
            //// Toán tử 3 ngôi
            //// Điều kiện ? Lệnh nếu ĐK đúng : Lệnh nếu ĐK sai;
            //Console.WriteLine(age < 16 ? ("Illegal") : ("You're legal!"));
            // Nhập 3 số, hãy tìm ra số lớn thứ 2 trong 3 số đó
            // Thử tìm 2 số lớn nhất && bé nhất
            // a+b+c-max-min
            Console.WriteLine("Nhập a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int max, min;
            // Tìm max
            if (a >= b && a >= c) max = a;
            else if (b >= c) max = b;
            else max = c;
            // Tìm min
            if (a <= b && a <= c) min = a;
            else if (b <= c) min = b;
            else min = c;
            // Tìm số lớn thứ 2
            Console.WriteLine($"Số lớn thứ 2 là {a + b + c - max - min}");
            // Cách 2 thuần so sánh
            if (a >= b && a <= c || a >= c && a <= b)
            {
                Console.WriteLine($"{a} là số lớn thứ 2");
            }
            else if (b >= c && b <= a || b >= a && b <= c)
            {
                Console.WriteLine($"{b} là số lớn thứ 2");
            }
            else Console.WriteLine($"{c} là số lớn thứ 2");
            // 3 ngôi
            Console.WriteLine("Số lớn thứ 2 nà: " +
                (a >= b && a <= c || a >= c && a <= b ? a : b >= c && b <= a || b >= a && b <= c ? b : c));
            // Số thứ 2 trừ đi số lớn nhất <=0 và trừ đi số nhỏ nhất >=0 
            // Số lớn nhất trừ đi 2 số còn lại >= 0
            // Số nhỏ nhất trừ đi 2 số còn lại <= 0
            Console.WriteLine("Số lớn thứ 2 llà: " +
                ((a - b) * (a - c) <= 0 ? a : (b - a) * (b - c) <= 0 ? b : c));
            // Cách 3 nhưng if-else
            if ((a - b) * (a - c) <= 0) Console.WriteLine($"{a} lớn thứ 2");
            else if ((b - c) * (b - a) <= 0) Console.WriteLine($"{b} lớn thứ 2");
            else Console.WriteLine($"{c} lớn thứ 2");
        }
    }
}