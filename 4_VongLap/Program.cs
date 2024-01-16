namespace _4_VongLap
{
    /*
     * Vòng lặp (loop) là một cấu trúc các câu lệnh mà thông qua đó
     * cho phép chúng ta thực thi một khối lệnh nhiều lần lặp đi lặp
     * lại theo một điều kiện nào đó mà không phải viết lại
     * Các loại vòng lặp quen thuộc: for, while, do-while, foreach
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // For
            // Dùng for để in ra các số nguyên âm lẻ từ 0 đến -100
            //int i = 0;
            //for (i = 0; i >= -100; )
            //{
            //    i--;
            //    if (i % 2 != 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //while (i >= -100)
            //{
            //    i--;
            //    if (i % 2 != 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            // Sử dụng vòng lặp, kiểm tra số nguyên tố
            // Số nguyên tố là số nguyên dương không có ước tự nhiên khác 1
            // và chính nó
            //Console.Write("Nhập vào 1 số: ");
            //int number = int.Parse(Console.ReadLine());
            //bool IsPrime = true; // Tạo ra 1 biến bool để kiểm tra
            //if (number < 2)
            //{
            //    Console.WriteLine(number +" Không Là số nguyên tố");
            //}
            //for (int i = 2; i*i <= number; i++)// tương đương với i<= SQRT(number)
            //{
            //    if (number % i == 0)
            //    {
            //        Console.WriteLine(number + " Không Là số nguyên tố");
            //        IsPrime = !IsPrime;
            //        break;
            //    }
            //}
            //if (IsPrime)
            //{
            //    Console.Write($"{number} la so nguyen to.");
            //}
            //Console.ReadKey();
            // Sử dụng vòng lặp while để in ra số chính phương từ 1 đến 1000000
            //int x = 0, y = 0;
            //while (x <= 1000000)
            //{
            //    if (Math.Round(Math.Sqrt(x), 0) * Math.Sqrt(x) == x)
            //    { // có thể thay Math.Round = Math.Floor
            //        Console.WriteLine(x + " Là số chính phương!");
            //    }
            //    x++;
            //}
            //while (x <= Math.Sqrt(1000000))
            //{
            //    Console.WriteLine(x*x);
            //}
            // Do-while (khác while ở chỗ sẽ chạy lệnh lặp 1 lần bất chấp điều kiện)
            // Chạy thử 1 lần trước => Check điều kiện sau
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }; // Khởi tạo
            double[] arr2 = new double[10]; // Khai báo mảng có 10 phần tử
            DateTime[]arr3 = new DateTime[10];
            // Vòng lặp foreach cho phép chúng ta truy xuất từ 1 tập hợp nào đó
            // toàn bộ các phần tử
            // Các loại cơ bản hay dùng: array, list, string,...
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }
            // var là 1 từ khóa đánh dấu 1 biến có thể nhận được mọi kiểu dữ liệu
        }
    }
}