using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenServiceWeb_Soap.BusinessMessagge
{
    public class AlmacenServiceResponse: AlmacenActionResponse
    {
        public List<Electrodomesticos> Electrodomesticos { get; set; }

    }
}