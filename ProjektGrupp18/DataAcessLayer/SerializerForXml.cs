using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using ProjektGrupp18.Models;
//using DataAcessLayer.Exceptions;


namespace DataAcessLayer
{
    public class SerializerForXml
    {
        public void Serialize(List<Podcasts> podcastLista)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcasts>));
                using (FileStream outFile = new FileStream("Podcasts.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(outFile, podcastLista);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Något gick fel");
            }
        }

        public List<Podcasts> Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcasts>));
                using (FileStream inFile = new FileStream("Podcasts.xml", FileMode.Open, FileAccess.Read))
                {
                   return (List<Podcasts>)xmlSerializer.Deserialize(inFile);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Något gick fel");
            }
        }
    }
}
