using System;
using System.Collections.Generic;

namespace DataManagment.Models;
public partial class SaFotografium
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public decimal CodDependiente { get; set; }

    public byte[] Fotografia { get; set; } = null!;

    public virtual SaTercero SaTercero { get; set; } = null!;
}
