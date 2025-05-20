using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.EntityLayer.Concrete
{
    public class Hizmet
    {
        public int HizmetId { get; set; }
        public string HizmetAd { get; set; }
        public string HizmetAciklama { get; set; }
        public string HizmetIcon { get; set; }
    }
}
