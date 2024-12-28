using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Utils
{
    internal class GradUtil
    {
        public static List<Mesto> Gradovi { get; set; } = new List<Mesto>()
        {
            new Mesto
            {
                Ptt = 11000,
                Naziv = "Beograd"
            },
            new Mesto
            {
                Ptt = 21000,
                Naziv = "Novi Sad"
            },
            new Mesto
            {
                Ptt = 18000,
                Naziv = "Nis"
            },
        };
    }
}
