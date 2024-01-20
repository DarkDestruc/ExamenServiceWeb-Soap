using ExamenServiceWeb_Soap.BusinessMessagge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace ExamenServiceWeb_Soap.BusinessActions
{
    public static class AlmacenElectrodManager
    {

        private static List<Electrodomesticos> GetElectrodomesticos()
        {
            return new List<Electrodomesticos>()
            {
            new Electrodomesticos()
            {
            IdProduct = 1,
            NameProduct = "Cocinas"
            },

            new Electrodomesticos()
            {
            IdProduct = 2,
            NameProduct = "Neveras"
            },

            new Electrodomesticos()
            {
            IdProduct = 3,
            NameProduct = "Lavadoras"
            },

            new Electrodomesticos()
            {
            IdProduct = 4,
            NameProduct = "Televisores"
            },

            };

       /* public static AlmacenActionResponse GettAllElectrodomest()
        {
            var electrodomest = GetElectrodomest();

            return new AlmacenServiceResponse
            {

                ActionSuccess = true,
                Electrodomest = electrodomest
             };*/



        
        }
    }
}