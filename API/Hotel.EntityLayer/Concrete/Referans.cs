using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.EntityLayer.Concrete
{
    public class Referans
    {
        public int ReferansId { get; set; }
        public string ReferansAd { get; set; }

        public string ReferansUnvan { get; set; }
        public string ReferansAciklama { get; set; }
        public string ReferansImage { get; set; }
    }
}
