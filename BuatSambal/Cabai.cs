using System;
using System.Collections.Generic;
using System.Text;

namespace BuatSambal
{
    class Cabai
    {
        private int biji = 0;
        private int satuMangkuk = 15;

        public Cabai(int biji)
        {
            this.biji = biji;
        }
        public Boolean apaMasih()
        {
            return this.biji >= this.satuMangkuk;
        }
        public void buatSatuMangkuk()
        {
            this.biji = this.biji - satuMangkuk;
        }
        public int getBiji()
        {
            return this.biji;
        }

    }
}
