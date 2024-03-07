using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaCodBanco
{
    public string CodEmpresa { get; set; } = null!;

    public decimal CodBanco { get; set; }

    public string DesBanco { get; set; } = null!;

    public string CodEstado { get; set; } = null!;

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<SaMovimientosEnca> SaMovimientosEncas { get; set; } = new List<SaMovimientosEnca>();
}
