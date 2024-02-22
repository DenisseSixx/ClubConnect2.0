using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaCodCobro
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCobro { get; set; } = null!;

    public string DesCobro { get; set; } = null!;

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<SaCliente> SaClientes { get; set; } = new List<SaCliente>();
}
