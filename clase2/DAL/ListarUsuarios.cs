using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2.DAL
{
    public class ListarUsuarios:NuevoUsuario
    {
        //hereda los otros atributos ya definidos en nuevo usuario
        public int Id
        {
            get; set;
        }
    }
}
