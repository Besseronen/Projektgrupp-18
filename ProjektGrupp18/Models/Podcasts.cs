using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektGrupp18.Models
{
    public class Podcasts : Feed 
    {
        public Podcasts(string namn, Kategori kategori, int uppdateringsIntervall, int antalAvsnitt) : 
            base (namn, kategori, uppdateringsIntervall, antalAvsnitt)
        {

        }

    }
}
