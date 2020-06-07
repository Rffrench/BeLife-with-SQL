using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeLife
{
    class Plan
    {
        private byte idPlan;
        private string nombre;
        private int primabase;
        private int polizactual;


        //getters y setters
        public byte IdPlan
        {
            get { return this.idPlan; }
            set { this.idPlan = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int PrimaBase
        {
            get { return this.primabase; }
            set { this.primabase = value; }
        }
        public int PolizaActual
        {
            get { return this.polizactual; }
            set { this.polizactual = value; }
        }


        public static List<Plan> planes = new List<Plan>();




        public Plan(byte idPlan, string nombre, int primabase, int polizactual)
        {
            this.idPlan = idPlan;
            this.nombre = nombre;
            this.primabase = primabase;
            this.polizactual = polizactual;
        }


    }
}
/***
 *      ######   ##########    # #                              #####     #               #        ######### 
 *                        #    # #     ########## #########    #     #    #    ########## #   ###          # 
 *    ##########         #     # #             #  #       #    #     #    ##           #  ####             # 
 *         #     ########      # #   #        #   #       #     #####     # #         #   #        ########  
 *         #         ##       #  #  #      # #    #       #    #     #    #  #     # #    #               #  
 *        #        ##        #   # #        #     #########    #     #    #         #     #               #  
 *      ##       ##         #    ##          #                  #####     #          #     ####### ########  
 *           ｌ ｏ ｓ　 ｓ ｕ ｐ ｅ ｒ　 ８　 ｔ ｅ ａ ｍ　 だ佳ツが                                                                                                 
 */
