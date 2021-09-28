using System;
using System.Collections.Generic;
using System.Text;

namespace BuatSambal
{
    class Bawang
    {
        private int butir = 0;
        private int satuMenu = 12;

        public Bawang(int butir)
        {
            this.butir = butir;
        }
        public Boolean apaMasih()
        {
            return this.butir >= this.satuMenu;
        }
        public void buatSatuMenu()
        {
            this.butir = this.butir - satuMenu;
        }
        public int getButir()
        {
            return this.butir;
        }
    }
}
