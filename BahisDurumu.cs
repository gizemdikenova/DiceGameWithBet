using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarAtmaOyunu
{
    public class BahisDurumu

    {
            public int BahislerinToplami;
        
        public int Bahis
        {
            get
            {
                return BahislerinToplami;
            }
            set
            {
                BahislerinToplami = value;
            }
        }
    }

}
