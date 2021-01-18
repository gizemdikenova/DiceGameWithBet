using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    public class Zar
    {
        //Her zarın ... vardır.
        public int Deger { get; set; } 
        // Her zar ile .... yapılır. Her zar ... yapar. Metot.

        public void At()
        {
            Random random = new Random();
            Deger = random.Next(1, 7);
        }
        
    }
}
