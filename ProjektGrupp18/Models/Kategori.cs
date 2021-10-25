using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektGrupp18.Models
{
    public class Kategori
    {
        string namn;
        int antalPodcasts;

        
        public Kategori(string namn )
        {
            antalPodcasts = 0;
            Namn = namn; 
        }

        public string Namn { get; set; }
        public int AntalPodcasts { get; set; }

        

    }
}
