using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid03_OpenClosed.After
{
    public class Kare : Sekil
    {
        private int v;

        public Kare(int v)
        {
            this.v = v;
        }

        public int Kenar(int kenar)
        {
            Kenar = kenar;
        }
        public override double AlanHesapla()
        {
            throw new NotImplementedException();
        }
    }
}
