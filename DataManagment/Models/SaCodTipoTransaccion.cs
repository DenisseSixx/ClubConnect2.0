using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaCodTipoTransaccion
{
    public string CodEmpresa { get; set; } = null!;

    public string CodTipoTransaccion { get; set; } = null!;

    public string DesTipoTransaccion { get; set; } = null!;

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<SaCodTransaccion> SaCodTransaccions { get; set; } = new List<SaCodTransaccion>();
}
