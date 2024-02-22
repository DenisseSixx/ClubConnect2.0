using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Appautorizaciond
{
    public string CodTercero { get; set; } = null!;

    public decimal CodDependiente { get; set; }

    public bool? CodAutorizacion { get; set; }
}
