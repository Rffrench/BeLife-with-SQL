using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife
{
    class Sexo
    {
        private byte idSexo;// 1= Masculino     2= Femenino
        private string descripcion;

        
        //getters y setters
        public byte IdSexo
        {
            get { return this.idSexo; }
            set { this.idSexo = value; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }





        public Sexo(byte idSexo, string descripcion)
        {
            this.idSexo = idSexo;
            this.descripcion = descripcion;
        }
    }
}
