using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagment.Models
{
    public class ExpedienteIntermediaria
    {
        public int CodArchivo { get; set; }
        public string CodEmpresa { get; set; }
        public string CodCliente { get; set; }
        public string CodTercero { get; set; }
        public string CodDependiente { get; set; }
        public int CodTipodocumento { get; set; }
        public string NomDocumento { get; set; }
        public string Documento { get; set; }
        public string ExtDocumento { get; set; }
        public DateTime Fecha { get; set; }
        public string CodEstusu { get; set; }

    }
}
