namespace PROYECTONINJA
{
    public partial class Form1 : Form
    {
        plataformas h, i, j;
        cañon k;
        List<ObjGrafico> p = new List<ObjGrafico>();
        Ninja prub;
        bala b,n;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generar();

            prub = new Ninja("ninja", 1, 250, 100, 100);
            this.Controls.Add(prub.ImagenObjeto);

            int x8 = 400;
            int y8 = 250;
            h = new plataformas("pl", x8, y8, 100, 100);
            this.Controls.Add(h.ImagenObjeto);
            p.Add(h);

            int x9 = 300;
            int y9 = 250;
            i = new plataformas("pl", x9, y9, 100, 100);
            this.Controls.Add(i.ImagenObjeto);
            p.Add(i);


            int x10 = 800;
            int y10 = 250;
            j = new plataformas("meta juego", x10, y10, 100, 100);
            this.Controls.Add(j.ImagenObjeto);
            p.Add(h);


            int x11 = 400;
            int y11 = 185;
            k = new cañon("cañon", x11, y11, 100, 100);
            this.Controls.Add(k.ImagenObjeto);
            p.Add(k);

            n = new bala("bala", 400, 185, 50, 50);
            this.Controls.Add(n.ImagenObjeto);




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prub.animacion();
            k.animacion();
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
            n.disparo();    
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            c = char.ToUpper(c);
            if (c == 'D')
            {
                if (prub.evaluarcolisiob(p))
                {

                    prub.rebotar(3);
                }
                prub.moveright();
            }
            else
            {
                if (c == 'A')
                {
                    if (prub.evaluarcolisiob(p))
                    {

                        prub.rebotar(3);
                    }
                    prub.moveleft();
                }
                else
                {
                    if (c == 'W')
                    {
                        if (prub.evaluarcolisiob(p))
                        {

                            prub.rebotar(3);
                        }
                        prub.moverUp();
                        prub.moverdown();
                    }
                    else
                    {
                        if (c == 'S')
                        {
                            if (prub.evaluarcolisiob(p))
                            {

                                prub.rebotar(3);
                            }

                            prub.moverdown();
                        }
                    }
                   
                }
            }
        }

        private void generar()
        {
            var posiciones = Lecturatxt("mapa");
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