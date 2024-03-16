using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagment.Models
{
    public partial class EstadoCuentaItem
    {

        public DateTime CodPeriodo { get; set; }
        public decimal CodImporte { get; set; }
        public string CodTipo { get; set; }
        public string CodSubtipo { get; set; }
        public string Titulo { get; set; }
        public string DesImporte { get; set; }
        public decimal MontoOriginal { get; set; }
        public decimal MonAdeudoAnterior { get; set; }
        public decimal MonAdeudoAnteriorSinRecargo { get; set; }
        public decimal Recargo { get; set; }
        public decimal MonAbono { get; set; }
        public decimal Bonificacion { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal MonSubtotalAdeudo { get; set; }
        public decimal PorIva { get; set; }
        public decimal MonIvaAdeudo { get; set; }
        public decimal MonTotalAdeudo { get; set; }
        public decimal AFavorAplicado { get; set; }
        public decimal CobradoAplicado { get; set; }
    }
}

