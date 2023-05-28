using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTONINJA
{
    public class Jugador
    {
        int cod_jug=000;
        string nombre;
        int puntaje=000;

        public Jugador() { }
        public Jugador( string nombre)
        {
           
            this.nombre = nombre;
           
        }

        public int Cod_jug { get => cod_jug; set => cod_jug = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntaje { get => puntaje; set=> puntaje = value; }

        
    }
}
