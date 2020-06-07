using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Clases
{
    public class ContratoVehiculo
    {

        private string numContrato;
        private string patente;

        public string NumContrato
        {
            get { return this.numContrato; }
            set { this.numContrato = value; }
        }

        public string Patente
        {
            get { return this.patente; }
            set { this.patente = value; }
        }


        public ContratoVehiculo(string numContrato, string patente)
        {
            this.numContrato = numContrato;
            this.patente = patente;
        }
    }
}
