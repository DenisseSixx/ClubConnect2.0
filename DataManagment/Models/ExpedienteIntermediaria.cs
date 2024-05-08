

namespace DataManagment.Models
{
    public class ExpedienteIntermediaria
    {
        public int CodArchivo { get; set; }
        public string CodEmpresa { get; set; } = null!;
        public string CodCliente { get; set; } = null!;
        public string CodTercero { get; set; } = null!;
        public int CodDependiente { get; set; }  
        public int CodTipodocumento { get; set; }
        public string NomDocumento { get; set; } = null!;
        public byte[] Documento { get; set; } = null!;
        public string ExtDocumento { get; set; } = null!;
        public DateTime? Fecha { get; set; }
        public string CodEstusu { get; set; } = null!;
    }
}

