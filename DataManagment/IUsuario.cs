using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagment
{
    public interface IUsuario
    {
        public string CodTercero { get; set; } 

        public decimal? CodDependiente { get; set; }

        public string CodUsuario { get; set; }

        public string NomUsuario { get; set; } 

        public string ClaUsuario { get; set; }

        public string Nombre { get; set; }

        public string CodEstusu { get; set; } 
    }
}

