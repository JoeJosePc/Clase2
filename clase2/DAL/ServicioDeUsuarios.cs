using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data; // para el uso de sql agrego las galerias
//using System.Data.SqlClient; //sql
//using System.Configuration; // para usar el configureManager en el ConectionString

namespace clase2.DAL
{
    public class ServicioDeUsuarios
    {
        //agrego el metodo de conexion para no repetirlo
        private SqlConnection iniciarConexion()
        {
            SqlConnection conection = new SqlConnection();
            conection.ConnectionString = ConfigurationManager.ConnectionStrings["Tienda"].ConnectionString;
            return conection;
        }

        //agrero el servicio de crear nuevo usuario
        /// <summary>
        /// 6+6+66565656
        /// </summary>
        /// <param name="usuario"></param>
        public void CrearUnNuevoUsuario(NuevoUsuario usuario)
        {
            SqlConnection conection = this.iniciarConexion();
            SqlCommand comando = new SqlCommand("NuevoUsuario", conection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@Name", usuario.Name));
            comando.Parameters.Add(new SqlParameter("@Password", usuario.Password));
            comando.Parameters.Add(new SqlParameter("@Enable", usuario.Enable));
            conection.Open();
            comando.ExecuteNonQuery();
            conection.Close();
        }

        //agrego servicio de listar usuarios
        public List<ListarUsuarios> ListarTodosLosUsuarios()
        {
            SqlConnection conection = this.iniciarConexion();
            SqlCommand comando = new SqlCommand("ListarUsuario", conection);
            comando.CommandType = CommandType.StoredProcedure;
            conection.Open();
            SqlDataReader LectorDeDatos = comando.ExecuteReader();
            List<ListarUsuarios> usuarios = new List<ListarUsuarios>();
            while (LectorDeDatos.Read())
            {
                ListarUsuarios usuario = new ListarUsuarios();
                usuario.Id = (int)LectorDeDatos.GetInt32(0);
                usuario.Name = LectorDeDatos.GetString(1);
                usuario.Password = LectorDeDatos.GetString(2);
                usuario.Enable = LectorDeDatos.GetBoolean(3);
                usuarios.Add(usuario);
            }
            conection.Close();
            return usuarios;
        }

        //agrero el servicio de eliminar usuario
        /// <summary>
        /// 544599595959
        /// </summary>
        /// <param name="usuario"></param>
        public void EliminarUsuario(EliminarUsuario usuario)
        {
            SqlConnection conection = this.iniciarConexion();
            SqlCommand comando = new SqlCommand("BorrarUsuario", conection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@Id", usuario.Id));
            conection.Open();
            comando.ExecuteNonQuery();
            conection.Close();
        }
    }
}
