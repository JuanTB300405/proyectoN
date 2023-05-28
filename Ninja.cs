using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONINJA
{
    public class Ninja:ObjGrafico
    {

        int velocidad;
        string dir;
        int estado;
        string nombre;
        int puntaje;
        int vidas;


        public Ninja()
        {
            velocidad = 3;
            dir = "right";
            estado= 1;
            puntaje = 0;
            vidas=3;
            
        }

        public Ninja(string nombre, int x, int y, int w, int h) : base(nombre,x,y,w,h)
        {
            velocidad = 3;
            dir = "right";
            estado = 1; 
            this.nombre = nombre;
            puntaje = 0;
            vidas = 3;

        }

        public void animacion()
        {
            string nombrerec = "";

            switch(estado)
            {
                case 1:
                    estado = 2;
                    break;

                case 2:
                    estado = 1;
                    break;

            }
            nombrerec = nombre+"_"+estado+"_"+dir;

            ImagenObjeto.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombrerec);


        }

        public void moveright()
        {
            dir = "right";
            Posx += velocidad;
            SetPos(Posx, Posy);
        }


        public void moverUp()
        {
            dir = "up";
            Posy-= velocidad+3;
            Posx += velocidad;
            SetPos(Posx, Posy);
        }
        public void moverdown()
        {
            dir = "down";
            Posy += velocidad;
            SetPos(Posx, Posy);
        }


        public void moveleft()
        {
            this.dir = "left";
            Posx -= velocidad;
            SetPos(Posx, Posy);
        }

        public bool evaluarcolisiob(List<ObjGrafico>obje)
        {
            for(int i=0;i<obje.Count;i++)
            {
                if (obje[i].GetRectangle().IntersectsWith(this.GetRectangle()))
                {
                    return true;
                }
            }
            return false;
        }

        public bool evaluarcolisiob(ObjGrafico obje)
        {
            if (obje.GetRectangle().IntersectsWith(this.GetRectangle()))
            {
                return true;
            }

            return false;
        }

        public void rebotar(int velocidad)
        {
            switch (dir)
            {
                case "left":
                    Posx+= velocidad;
                    dir= "right";

                    break;

                case "right":
                    Posx-= velocidad;
                    dir= "left";
                    break;

                case "up":
                    Posy+= velocidad;
                    dir= "down";
                    break;

                case "down":
                    Posy -= velocidad;
                    dir = "up";
                    Console.WriteLine("hola mundo");
                    break;
            }

        }


    }
}
