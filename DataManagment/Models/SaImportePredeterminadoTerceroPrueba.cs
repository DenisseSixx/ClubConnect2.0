using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaImportePredeterminadoTerceroPrueba
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public decimal CodDetalle { get; set; }

    public decimal CodDependiente { get; set; }

    public string Extra01 { get; set; } = null!;

    public string Extra02 { get; set; } = null!;

    public DateTime FecInicio { get; set; }

    public DateTime FecFin { get; set; }

    public string CodEstado { get; set; } = null!;
}
