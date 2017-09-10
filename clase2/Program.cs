using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using clase2.DAL;


namespace clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear Nuevos Usuario
            ServicioDeUsuarios servicioUsuario = new ServicioDeUsuarios();
            NuevoUsuario nuevoUsuario = new NuevoUsuario();
            nuevoUsuario.Name = "usuario 5";
            nuevoUsuario.Password = "qazwsx";
            nuevoUsuario.Enable = true;
            servicioUsuario.CrearUnNuevoUsuario(nuevoUsuario);

            

            //eliminar usuario
            EliminarUsuario eliminaUsuario = new EliminarUsuario();
            eliminaUsuario.Id = 2;
            servicioUsuario.EliminarUsuario(eliminaUsuario);


            servicioUsuario.ListarTodosLosUsuarios().ForEach(usuario => Console.WriteLine(usuario.Name));
            Console.ReadKey();
        }
    }
}
