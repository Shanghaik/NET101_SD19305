namespace _5_Luyentap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 1:
            // double sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Please enter a number");
            //    double x = Convert.ToDouble(Console.ReadLine());
            //    sum += x;
            //    if (x != Math.Floor(x)) break; // x != (int)x;
            //    // Nếu x khác với giá trị nguyên (phần nguyên) của x
            //    // thì nó là số thập phân
            //}
            //Console.WriteLine("Sum of the input number is: " + sum);
            // Bài 2
            //do
            //{
            //    Console.WriteLine("Please choose");
            //    Console.WriteLine("a. Input");
            //    Console.WriteLine("b. Output");
            //    Console.WriteLine("c. Calculate");
            //    Console.WriteLine("d. Exit");
            //    string choose = Console.ReadLine();
            //    if (choose == "a") Console.WriteLine("You've choosen input");
            //    else if (choose == "b") Console.WriteLine("You've choosen ouput");
            //    else if (choose == "c") Console.WriteLine("You've choosen calculate");
            //    else if (choose == "d")
            //    {
            //        Console.WriteLine("You've choosen input");
            //        break;
            //    }
            //    else Console.WriteLine("Wrong!!! Please re-enter");
            //} while (true);
            // Bài 3
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter z");
            double z = Convert.ToDouble(Console.ReadLine());
            if (x * y <= 0 || y * z <= 0 || x * z <= 0)
            {
                Console.WriteLine("Wrong, the input is not for a triangle");
            }
            else if (x + y <= z || x + z <= y || y + z <= x)
            {
                Console.WriteLine("Wrong, the input is not for a triangle");
            }
            else
            {
                if (x * x == y * y + z * z || y * y == x * x + z * z || z * z == x * x + y * y)
                {
                    Console.WriteLine("Right Triangle");
                }
                else if (x * x > y * y + z * z || y * y > x * x + z * z || z * z > x * x + y * y)
                {
                    Console.WriteLine("Obtuse triangle");
                }
                else Console.WriteLine("pointed triangle");
            }
        }
    }
}