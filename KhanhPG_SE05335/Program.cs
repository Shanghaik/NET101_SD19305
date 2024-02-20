namespace KhanhPG_SE05335
{
    internal class Program
    {
        static string Menu() // 1.5 phương thức trả về
        {
            Console.WriteLine("1. Nhap DS");
            Console.WriteLine("2. Xuat DS");
            Console.WriteLine("3. Xuat DS ki hoc > 6");
            Console.WriteLine("4. Xoa theo ten");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("6. 6");
            Console.WriteLine("Hay nhap su lua chon cua ban");
            string choose = Console.ReadLine();
            if (choose != "1" && choose != "2" && choose != "3"
                && choose != "4" && choose != "5" && choose != "6")
            {
                Console.WriteLine("Loi roi, hay nhap lai");
                return Menu(); // đệ quy 
            }
            else return choose;
        }
        static void Main(string[] args)
        {
            Services sv = new Services(); // Tạo services
            while (true)
            {
                switch (Menu()) // Nhét thẳng menu vào đây vì nó là 1 hàm trả về giá trị
                {
                    case "1":
                        sv.NhapDS();
                        break;
                    case "2":
                        sv.XuatDS();
                        break;
                    case "3":
                        sv.XuatDSHon6();
                        break;
                    case "4":
                        sv.XoaC2();
                        break;
                    case "5":
                        // return; // Cái này cũng được nhưng nó không hay
                        Environment.Exit(0); // Cái này hay hơn
                        break;
                    case "6":
                        NganhUDPM nudpm = new NganhUDPM();
                        nudpm.Ten = "Ứng dụng";
                        nudpm.Sokihoc = 6;
                        nudpm.Id = 555;
                        nudpm.InThongTin();
                        break;
                    default:
                        Console.WriteLine("SAi sai");
                        break;
                }
            }
            
        }
    }
}