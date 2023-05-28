using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONINJA
{
    public class bala:ObjGrafico
    {
        int velocidad = 2;
        public bala() { }


        public bala(string nombre, int x, int y, int w, int h) : base(nombre, x, y, w, h)
        {
          
        }

        public void disparo()
        {
            
           this.Posx -= velocidad+20;
          SetPos(this.Posx,this.Posy);
            
            
        }

       

    }
}
