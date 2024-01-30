using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4TC_OOP
{
    /* Tính đóng gói (bao đóng) thể hiện khả năng truy cập đến các
     * thành phần trong đối tượng. Thể hiện qua Access Modifier
     * Các loại access modifier sau:
     * private: Chỉ có thể truy cập trong class chứa nó
     * public: Truy cập được ở mọi nơi, gọi được mọi lúc
     * internal: Truy cập được trong phạm vi assembly (project)
     * protected: Truy cập được trong class chứa nó và các class kế thừa
     * protected internal = protected + internal (Vừa có thể truy cập được
     * trong cùng 1 assembly, vừa có thể truy cập được trong class con)
     */
    public class BaoTai
    {
        // Thuộc tính
        public string ma = "ma";
        private int soluong = 1;
        internal string ten = "abc";
        protected DateTime ngaysx = DateTime.Now;
        protected internal int giaban = 100;

        //public string Ma { get => ma; set => ma = value; }
        //public int Soluong { get => soluong; set => soluong = value; }
        //public string Ten { get => ten; set => ten = value; }
        //public DateTime Ngaysx { get => ngaysx; set => ngaysx = value; }
        //public int Giaban { get => giaban; set => giaban = value; }

        // constructor
        public BaoTai() // Nếu không tạo ctr không tham số thì compiler sẽ tự tạo cho
        {
        }
    }
}
