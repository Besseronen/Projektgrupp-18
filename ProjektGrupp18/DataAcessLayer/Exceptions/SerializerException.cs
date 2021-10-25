using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcessLayer.Exceptions
{
    class SerializerException : Exception
    {
        private string fileName;

        public string fileName
        {
            get
            {
                return fileName;
            }
        }

        public SerializerException(string fileName, string message) : base(message)
        {
            fileName = fileName;
        }
    }
}
