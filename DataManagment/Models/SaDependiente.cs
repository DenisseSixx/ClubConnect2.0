using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaDependiente
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public decimal CodDependiente { get; set; }

    public string Nombre { get; set; } = null!;

    public DateTime FecNacimiento { get; set; }

    public string CodCredencial { get; set; } = null!;

    public decimal? LimiteCredito { get; set; }

    public decimal? SaldoCredito { get; set; }

    public string CodEstado { get; set; } = null!;

    public virtual ICollection<Expediente> Expedientes { get; set; } = new List<Expediente>();

    //public virtual SaTercero SaTercero { get; set; } = null!;
}
