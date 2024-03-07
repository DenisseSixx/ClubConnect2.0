using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaCliente
{
    public string CodEmpresa { get; set; } = null!;

    public string CodCliente { get; set; } = null!;

    public string NomCliente { get; set; } = null!;

    public string NumCuenta { get; set; } = null!;

    public string CodProducto { get; set; } = null!;

    public string Extra01 { get; set; } = null!;

    public string Extra02 { get; set; } = null!;

    public string Tercero01 { get; set; } = null!;

    public string Tercero02 { get; set; } = null!;

    public string CodBusca { get; set; } = null!;

    public string CodCobro { get; set; } = null!;

    public decimal Monto { get; set; }

    public string CodEstado { get; set; } = null!;

    public string CodOperacion { get; set; } = null!;

    public decimal LonExtra01 { get; set; }

    public decimal LonExtra02 { get; set; }

    public string CodDeshabilitarImp { get; set; } = null!;

    public virtual SaCodEmpresa CodEmpresaNavigation { get; set; } = null!;

    public virtual SaCodCobro SaCodCobro { get; set; } = null!;

    public virtual ICollection<SaDestinatario> SaDestinatarios { get; set; } = new List<SaDestinatario>();

    public virtual ICollection<SaImporte> SaImportes { get; set; } = new List<SaImporte>();

    public virtual ICollection<SaTercero> SaTerceros { get; set; } = new List<SaTercero>();
}
