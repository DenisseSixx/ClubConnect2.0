using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaImporte
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public decimal CodImporte { get; set; }

    public string DesImporte { get; set; } = null!;

    public string CodTipo { get; set; } = null!;

    public string CodSubtipo { get; set; } = null!;

    public DateTime FecInicio { get; set; }

    public DateTime FecFin { get; set; }

    public decimal Monto { get; set; }

    public string CodEstado { get; set; } = null!;

    public string Extra01 { get; set; } = null!;

    public string Extra02 { get; set; } = null!;

    public decimal? CodConcepto { get; set; }

    public decimal? PorIva { get; set; }

    public string? TipoCobro { get; set; }

    public virtual SaCliente SaCliente { get; set; } = null!;

    public virtual ICollection<SaCodExtra01> SaCodExtra01s { get; set; } = new List<SaCodExtra01>();

    public virtual SaCodSubtipo SaCodSubtipo { get; set; } = null!;

    public virtual ICollection<SaImporteBonificacion> SaImporteBonificacions { get; set; } = new List<SaImporteBonificacion>();

    public virtual ICollection<SaImportePredeterminadoImporte> SaImportePredeterminadoImportes { get; set; } = new List<SaImportePredeterminadoImporte>();

    public virtual ICollection<SaImporteTerceroBitacora> SaImporteTerceroBitacoras { get; set; } = new List<SaImporteTerceroBitacora>();

    public virtual ICollection<SaImporteTercero> SaImporteTerceros { get; set; } = new List<SaImporteTercero>();

    public virtual ICollection<SaLugare> SaLugares { get; set; } = new List<SaLugare>();
}
