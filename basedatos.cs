using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;


namespace PROYECTONINJA
{
    public class basedatos
    {
        string ruta = "Data Source=DESKTOP-S99UIRJ;Initial Catalog=score;Integrated Security=True";
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lectura;
        string mensaje;

        public string Mensaje { get => mensaje; set => mensaje = value; }

        public void conectar()
        {
            try
            {
                conexion = new SqlConnection(ruta);
                conexion.Open();
            }
            catch (Exception e)
            {
                mensaje = e.Message;
            }
        }

        public int Jugador(Jugador jugador)
        {
            int resp = 0;
           
            conectar();
            try
            {
                //la consulta que se hace en sql 
                string Consulta = "insert into jugador (nom,puntaje)" +
                    "values(@nom, @puntaje)";
                //ejecutando el comando con la consulta y la conexion de destino
                comando = new SqlCommand(Consulta, conexion);
                //valores asignados a la consulta
              
                comando.Parameters.AddWithValue("@nom",jugador.Nombre);
                comando.Parameters.AddWithValue("@puntaje",jugador.Puntaje);
              
                resp = comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                mensaje = e.Message;
            }
            conexion.Close();
            return resp;
        }

       

    }
}
