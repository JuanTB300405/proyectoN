using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace PROYECTONINJA
{
    public partial class inicio : Form
    {
        basedatos db =new basedatos();
        public inicio()
        {
            InitializeComponent();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciarPP_Click(object sender, EventArgs e)
        {
            Jugador jugador;
            int resp = 0;
            if (txt_nombrejugador.Text!="")
            {
                jugador = new Jugador();
                jugador.Nombre = txt_nombrejugador.Text;
                resp=db.Jugador(jugador);
                if (resp == 1)
                {
                    MessageBox.Show("se guardo", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(db.Mensaje, "confirmacion");
                }

            }
            else
            {
               MessageBox.Show("RELLENE EL NOMBRE","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
