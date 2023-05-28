using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTONINJA
{
    public partial class Mapa2 : Form
    {
        plataformas h, i, j;
        List<plataformas> p = new List<plataformas>();
        public Mapa2()
        {
            InitializeComponent();
        }

        private void Mapa2_Load(object sender, EventArgs e)
        {
            generar();

            int x3 = 250;
            int y3 = 250;
            h = new plataformas("pld", x3, y3, 100, 100);
            this.Controls.Add(h.ImagenObjeto);

            int x5 = 650;
            int y5 = 250;
            i = new plataformas("pld", x5, y5, 100, 100);
            this.Controls.Add(i.ImagenObjeto);

            int x8 = 800;
            int y8 = 250;
            j= new plataformas("meta juego", x8, y8, 100, 100);
            this.Controls.Add(j.ImagenObjeto);

        }

       
        private void generar()
        {
            var posiciones = Lecturatxt("mapa2");
            for (int i = 0; i < posiciones.GetLength(0); i++)
            {
                plataformas plataform = new plataformas("suelo bosque", posiciones[i, 0], posiciones[i, 1], 100, 100);
                p.Add(plataform);
                this.Controls.Add(plataform.ImagenObjeto);

            }
        }

        private int[,] Lecturatxt(string nomA)
        {
            var cords = (string)Properties.Resources.ResourceManager.GetObject(nomA);
            string[] veccords = cords.Split('\r');
            int[,] posiciones = new int[veccords.Length, 2];
            for (int i = 0; i < veccords.Length; i++)
            {
                veccords[i] = veccords[i].Trim('\n');
                var C = veccords[i].Split(';');
                posiciones[i, 0] = int.Parse(C[0]);
                posiciones[i, 1] = int.Parse(C[1]);
            }
            return posiciones;
        }

    }
}
