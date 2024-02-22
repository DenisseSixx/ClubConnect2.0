using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodTransaccion
{
    public string CodEmpresa { get; set; } = null!;

    public string CodTransaccion { get; set; } = null!;

    public string DesTransaccion { get; set; } = null!;

    public string CodTipoTransaccion { get; set; } = null!;

    public string CodEstado { get; set; } = null!;

    public virtual SaCodTipoTransaccion SaCodTipoTransaccion { get; set; } = null!;

    public virtual ICollection<SaMovimientosEnca> SaMovimientosEncas { get; set; } = new List<SaMovimientosEnca>();
}
