using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    public class BakiyeDurumu
    {

        public int Tutar { get; set; }

        public BakiyeDurumu(int value)
        {
            Tutar = value;
        }

        public int AzalanBakiye(int value)
        {
            if (Tutar > 0)
            {
                return Tutar = Tutar - value;
            }
            else
            {
                return 0;
            }


        }
        public int ArtanBakiye(int value)
        {
            return Tutar = Tutar + value;

        }

    }
}
