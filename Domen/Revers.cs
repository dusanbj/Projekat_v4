using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Revers
    {
        public long Id { get; set; }
        public DateTime Datum { get; set; }
        public Zaposleni Zaposleni { get; set; }
        public Klijent Klijent { get; set; }
        public List<StavkaReversa> Stavke { get; set; }
    }
}
