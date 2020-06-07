using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife.Clases
{
    public class ContratoVivienda
    {
        private string numContrato;
        private int codigoPostal;

        public string NumContrato
        {
            get { return this.numContrato; }
            set { this.numContrato = value; }
        }

        public int CodigoPostal
        {
            get { return this.codigoPostal; }
            set { this.codigoPostal = value; }
        }


        public ContratoVivienda(string numContrato, int codigoPostal)
        {
            this.numContrato = numContrato;
            this.codigoPostal = codigoPostal;
        }

    }
}
