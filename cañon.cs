using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONINJA
{
    public class cañon:ObjGrafico
    {
        int estado;
        string nombre;
       

        public cañon() { }


        public cañon (string nombre, int x, int y, int w, int h) : base(nombre, x, y, w, h)
        {
            this.nombre= nombre;
            this.estado = 1;
            
        }

     

        public void animacion()
        {
            int dispara;
            string nombrerec = "";

            switch (estado)
            {
                case 1:
                    estado = 2;
                    
                    break;

                case 2:
                    estado = 1;
                    break;

            }
            nombrerec = nombre + "_" + estado;

            ImagenObjeto.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombrerec);
           

        }


    }
}
