using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaDetallePagoMixto
{
    public int IdMixto { get; set; }

    public int? CodMovimiento { get; set; }

    public decimal? MontoTotal { get; set; }

    public decimal? Efectivo { get; set; }

    public decimal? Banco { get; set; }

    public decimal? Cheque { get; set; }

    public decimal? Tarjeta { get; set; }

    public decimal? Deposito { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public string? UsuarioCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public string? UsuarioActualizacion { get; set; }
}
