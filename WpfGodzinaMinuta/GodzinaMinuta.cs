using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGodzinaMinuta
{
    class GodzinaMinuta
    {
        int godzina;
        int minuta;

        public GodzinaMinuta(int godzina, int minuta)
        {
            this.godzina = godzina % 12;
            this.minuta = minuta % 60;

        }

        public double KatStopnie
        {
            get
            {
                return ObliczKatStopnie();
            }
        }

        public double KatRadiany
        {
            get
            {
                return Math.Round(ObliczKatStopnie() * Math.PI / 180, 2);
            }
        }


        double ObliczKatStopnie()
        {
            double kat;
            double kat_minuta;
            double kat_godzina;

            kat_minuta = ((double)minuta / 60) * 360;

            kat_godzina = ((double)godzina / 12) * 360;

            kat = kat_minuta - kat_godzina;
            kat = Math.Abs(kat);

            if (kat > 180)
            {

                kat = 360 - kat;
            }
            return kat;

        }
    }
}
