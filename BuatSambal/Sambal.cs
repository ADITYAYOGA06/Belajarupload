using System;
using System.Collections.Generic;
using System.Text;

namespace BuatSambal
{
    class Sambal
    {
        private Bawang Butirbawang;
        private Cabai Bijicabai;
        private Garam Beratgaram;

        public Sambal(Bawang bawang, Cabai cabai, Garam garam)
        {
            this.Butirbawang = bawang;
            this.Bijicabai = cabai;
            this.Beratgaram = garam;
        }

        public String buatSambal()
        {
            if (!this.Butirbawang.apaMasih())
            {
                return "Maaf, bawangnya tidak cukup";
            }
            if (!this.Bijicabai.apaMasih())
            {
                return "Maaf, cabainya tidak cukup";
            }
            if (!this.Beratgaram.apaMasih())
            {
                return "Maaf, garamnya tidak cukup";
            }

            this.Beratgaram.buatSatuKali();
            this.Bijicabai.buatSatuMangkuk();
            this.Butirbawang.buatSatuMenu();
            return "Yesss, sambal sudah jadi";
        }

        public String checkTersedia()
        {
            return $"Cabai : {this.Bijicabai.getBiji()}, Garam : {this.Beratgaram.getBerat()}, Bawang : {this.Butirbawang.getButir()}";
        }
    }
}
