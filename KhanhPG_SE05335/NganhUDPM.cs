using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhPG_SE05335
{
    internal class NganhUDPM : Nganhhoc
    {
        string khauhieu = "Hoc nua hoc mai";
        public NganhUDPM()
        {

        }
        public NganhUDPM(int id, string ten, int sokihoc, string khauhieu) : base(id, ten, sokihoc)
        {
            this.khauhieu = khauhieu;
        }
        public void InThongTin()
        {
            base.InThongTin(); // kế thừa phương thức
            Console.WriteLine("Chung toi ho khau hieu: "+khauhieu);
        }
    }
}
