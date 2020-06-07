using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife
{
    class EstadoCivil
    {
        private byte idEcivil;
        private string descripcion;

        //getters y setters
        public byte IdEcivil
        {
            get { return this.idEcivil; }
            set { this.idEcivil = value; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }




        public EstadoCivil(byte idEcivil, string descripcion)
        {
            this.idEcivil = idEcivil;
            this.descripcion = descripcion;
        }
    }
}
