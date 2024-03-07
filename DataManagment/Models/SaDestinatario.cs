using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaDestinatario
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public decimal CodDestinatario { get; set; }

    public string NomDestinatario { get; set; } = null!;

    public string CorDestinatario { get; set; } = null!;

    public virtual SaCliente SaCliente { get; set; } = null!;
}
