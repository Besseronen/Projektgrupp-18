using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjektGrupp18.Models
{
    [XmlInclude(typeof(Podcasts))]
    public class Feed
    {

        public Feed(string namn, Kategori kategori, int uppdateringsIntervall, int antalAvsnitt)
        {
            Namn = namn;
            UppdateringsIntervall = uppdateringsIntervall;
            AntalAvsnitt = antalAvsnitt;
        }

        public string Namn { get; set; }
        public int UppdateringsIntervall { get; set; }
        public int AntalAvsnitt { get; set; }
        public string Kategori { get; set; }

        public virtual void a()
        {

        }

    }
}
