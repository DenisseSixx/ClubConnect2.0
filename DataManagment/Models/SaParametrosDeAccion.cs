using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaParametrosDeAccion
{
    public string Accion { get; set; } = null!;

    public string Parametro { get; set; } = null!;

    public string Valor { get; set; } = null!;

    public string? Commentario { get; set; }

    public DateTime FechaModificacion { get; set; }

    public string CodUsuario { get; set; } = null!;
}
