﻿namespace _8_4TC_OOP
{
    /*
     * OOP có 4 tính chất cơ bản
     * 1. Đóng gói: Thể hiện khả năng truy cập đến các 
     * thành phần trong Class. VD: Khi đóng cửa lớp (private) thì
     * sinh viên bên ngoài không thể vào được, cổng trường luôn
     * mở (public) thì ai cũng có thể vào được
     * 2. Kế thừa: Thể hiện khả năng sử dụng lại các tành phần
     * của các lớp đã được xây dựng. VD: Kế thừa lại khả năng chém
     * gió của thầy Dũng =))
     * 3. Đa hình: Các thể hiện khác nhau của cùng 1 hành động (hành vi)
     * trong các trường hợp khác nhau giữa các đối tượng khác nhau hoặc
     * cùng 1 đối tượng nhưng trong các điều kiện khác nhau.
     * VD: cùng là chạy bộ tập thể dục nhưng bạn A thì chạy nhanh, B thì
     * chạy rất nhanh, C thì chạy chậm
     * Bạn A, khi chạy ra chợ mua rau sẽ khác bạn A khi bị bố đuổi về từ
     * quán net
     * 4. Trừu tượng: Khả năng trừu tượng hóa các thành phần của 1 lớp
     * để làm khuôn mẫu cho các lớp khác. VD: Lớp Cá có các hành động Bơi
     * Ăn, các hành động này trừu tượng và không thể xác định rõ khi chưa
     * biết chính xác đó là cá gì?
     * 
     */

    internal class Program
    {
        /*
        public string ma = "ma";
        private int soluong = 1;
        internal string ten = "abc";
        protected DateTime ngaysx = DateTime.Now ;
        protected internal int giaban = 100;
         */
        static void Main(string[] args)
        {
            //BaoTai bt = new BaoTai();
            //Console.WriteLine(bt.ma);
            ////Console.WriteLine(bt.soluong); // Lỗi vì là private
            //Console.WriteLine(bt.ten);
            ////Console.WriteLine(bt.ngaysx); // Lỗi vì protected
            //Console.WriteLine(bt.giaban); 
            ConCa conca = new ConCa();
            ConCa conca2 = new CaChep();
            // CaChep chep1 = new ConCa(); // Lỗi
            // Có thể tạo ra đối tượng của lớp cha bằng constructor của lớp con nhưng
            // điều ngược lại là không thể
            // Vì constructor của lớp CaChep có tối đa 5 thuộc tínhcòn ConCa chỉ có 3
            // Không thể tạo được 1 đối tượng có 5 thuộc tính bởi constructor mà chỉ
            // có thể khởi tạo 3 thuộc tính
            CaChep cachep = new CaChep();
            cachep.InThongTin(); // Vẫn gọi InThongTin của lớp ConCa vì nó kế thừa
            cachep.XuatThongTin(); 
        }
    }
}