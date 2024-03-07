using DataManagment;
using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class Appusuario 
{ 
    public string CodTercero { get; set; } = null!;

    public decimal? CodDependiente { get; set; }

    public string CodUsuario { get; set; } = null!;

    public string NomUsuario { get; set; } = null!;

    public string ClaUsuario { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string CodEstusu { get; set; } = null!;
}
