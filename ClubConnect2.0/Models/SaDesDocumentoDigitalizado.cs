﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class SaDesDocumentoDigitalizado
{
    public string CodEmpresa { get; set; } = null!;

    public decimal CodTipoDocumento { get; set; }

    public string DesTipoDocumento { get; set; } = null!;

    public string CodEstado { get; set; } = null!;
}
