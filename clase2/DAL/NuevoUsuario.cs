using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2.DAL
{
    public class NuevoUsuario
    {
        //Describo los datos/atributos hacer utilizados
        public string Name
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

        //bool = 1 y 0 (sql) true y false (visual)
        public bool Enable
        {
            get; set;
        }
    }
}
