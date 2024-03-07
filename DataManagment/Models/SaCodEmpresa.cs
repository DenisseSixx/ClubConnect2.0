using System;
using System.Collections.Generic;

namespace DataManagment.Models;

public partial class SaCodEmpresa
{
    public string CodEmpresa { get; set; } = null!;

    public string DesEmpresa { get; set; } = null!;

    public string Nomser1 { get; set; } = null!;

    public string Nomser2 { get; set; } = null!;

    public string Nomser3 { get; set; } = null!;

    public string Basser1 { get; set; } = null!;

    public string Basser2 { get; set; } = null!;

    public string Basser3 { get; set; } = null!;

    public string Ususer1 { get; set; } = null!;

    public string Ususer2 { get; set; } = null!;

    public string Ususer3 { get; set; } = null!;

    public string Passer1 { get; set; } = null!;

    public string Passer2 { get; set; } = null!;

    public string Passer3 { get; set; } = null!;

    public string Versis { get; set; } = null!;

    public virtual ICollection<SaCliente> SaClientes { get; set; } = new List<SaCliente>();

    public virtual ICollection<SaCodBanco> SaCodBancos { get; set; } = new List<SaCodBanco>();

    public virtual ICollection<SaCodCalculo> SaCodCalculos { get; set; } = new List<SaCodCalculo>();

    public virtual ICollection<SaCodCobro> SaCodCobros { get; set; } = new List<SaCodCobro>();

    public virtual ICollection<SaCodEstusu> SaCodEstusus { get; set; } = new List<SaCodEstusu>();

    public virtual ICollection<SaCodGrupoPar> SaCodGrupoPars { get; set; } = new List<SaCodGrupoPar>();

    public virtual ICollection<SaCodGrupoSer> SaCodGrupoSers { get; set; } = new List<SaCodGrupoSer>();

    public virtual ICollection<SaCodGrupoUsu> SaCodGrupoUsus { get; set; } = new List<SaCodGrupoUsu>();

    public virtual ICollection<SaCodOpcion> SaCodOpcions { get; set; } = new List<SaCodOpcion>();

    public virtual ICollection<SaCodSucursal> SaCodSucursals { get; set; } = new List<SaCodSucursal>();

    public virtual ICollection<SaCodTipoCompra> SaCodTipoCompras { get; set; } = new List<SaCodTipoCompra>();

    public virtual ICollection<SaCodTipoMantenimiento> SaCodTipoMantenimientos { get; set; } = new List<SaCodTipoMantenimiento>();

    public virtual ICollection<SaCodTipoMembresium> SaCodTipoMembresia { get; set; } = new List<SaCodTipoMembresium>();

    public virtual ICollection<SaCodTipoTransaccion> SaCodTipoTransaccions { get; set; } = new List<SaCodTipoTransaccion>();

    public virtual ICollection<SaCodTipo> SaCodTipos { get; set; } = new List<SaCodTipo>();

    public virtual ICollection<SaDocumento> SaDocumentos { get; set; } = new List<SaDocumento>();

    public virtual ICollection<SaTercero> SaTerceros { get; set; } = new List<SaTercero>();

    public virtual ICollection<SaUsuario> SaUsuarios { get; set; } = new List<SaUsuario>();
}
