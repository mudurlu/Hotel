using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.EntityLayer.Concrete
{
    internal class Oda
    {
        public int OdaId { get; set; }

        public string OdaNo { get; set; }
        public string OdaKapakFoto { get; set; }
        public int Fiyat { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }

        public string YatakSayisi { get; set; }
        public string BanyoSayisi { get; set; }
        public string Wifi { get; set; }

    }
}
