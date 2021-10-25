using System;
using System.Collections.Generic;
using System.Text;
using ProjektGrupp18.Models;
using DataAcessLayer;

namespace BusinessLayer.Controllers
{
    class FeedController
    {
        SerializerForXml serializer;        
    }

    public FeedController()
    {
        serializer = new SerializerForXml();
    }

}
