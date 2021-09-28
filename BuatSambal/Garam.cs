using System;
using System.Collections.Generic;
using System.Text;

namespace BuatSambal
{
    class Garam
    {
        private int berat = 0;
        private int satuSambal = 10;

        public Garam(int berat)
        {
            this.berat = berat;
        }
        public Boolean apaMasih()
        {
            return this.berat >= this.satuSambal;
        }
        public void buatSatuKali()
        {
            this.berat = this.berat - satuSambal;
        }
        public int getBerat()
        {
            return this.berat;
        }
    }
}
