using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaDocumentoDigitalizado
{
    public string CodEmpresa { get; set; } = null!;

    public string CodTercero { get; set; } = null!;

    public decimal CodTipoDocumento { get; set; }

    public decimal? CodDependiente { get; set; }

    public byte[]? Frente { get; set; }

    public byte[]? Reverso { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string CodUsuario { get; set; } = null!;

    public string CodSucursal { get; set; } = null!;
}
