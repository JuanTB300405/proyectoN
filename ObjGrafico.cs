using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PROYECTONINJA
{
    public class ObjGrafico
    {
        int posx;
        int posy;
        PictureBox imagenObjeto;
        string nombreRecurso;

        public int Posx { get => posx; set => posx = value; }
        public int Posy { get => posy; set => posy = value; }
        public PictureBox ImagenObjeto { get => imagenObjeto; set => imagenObjeto = value; }

      
        public ObjGrafico() { }
        public ObjGrafico(string nombre, int x, int y, int w, int h)
        {
            this.nombreRecurso = nombre;
            this.posy = y;
            this.posx = x;
            this.imagenObjeto = new PictureBox();
            this.imagenObjeto.Size = new Size(w, h);
            this.imagenObjeto.Location = new Point(x, y);
            this.imagenObjeto.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombre);
            this.imagenObjeto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.imagenObjeto.BackColor = Color.Transparent;

        }

        public void SetPos(int x, int y)
        {
            this.posy = y;
            this.posx = x;
            this.imagenObjeto.Location = new Point(x, y);
        }

        public Rectangle GetRectangle()
        {
            return imagenObjeto.Bounds;

        }

    }

}

