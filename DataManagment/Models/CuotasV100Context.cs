using System;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

//namespace WebApplication1.Models;
namespace DataManagment.Models;
public partial class CuotasV100Context : DbContext

{
    private DbConnection coneccion;
    public CuotasV100Context()
    {
    
    coneccion = new SqlConnection("Server=DLUGO_PC\\SQL_DLUGO_2K22;Database=cuotas_v100;UID=sa;PWD=Usuario1;TrustServerCertificate=True;");
}

    public CuotasV100Context(DbContextOptions<CuotasV100Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Appautorizaciond> Appautorizacionds { get; set; }

    public virtual DbSet<Appautorizaciont> Appautorizacionts { get; set; }
    public virtual DbSet<Applogin> Applogin { get; set; }

    public virtual DbSet<Apprespuestaautenticacion> Apprespuestaautenticacion { get; set; }
    public virtual DbSet<Appusuario> Appusuarios { get; set; }

    public virtual DbSet<Etipodocumento> Etipodocumentos { get; set; }

    public virtual DbSet<Expediente> Expedientes { get; set; }

    public virtual DbSet<ExpedienteIntermediaria> ExpedienteIntermediaria { get; set; }

    public virtual DbSet<Expedientetercero> Expedienteterceros { get; set; }

    public virtual DbSet<SaBiometriaCopium> SaBiometriaCopia { get; set; }

    public virtual DbSet<SaBiometrium> SaBiometria { get; set; }

    public virtual DbSet<SaBitacoraGeneracion> SaBitacoraGeneracions { get; set; }

    public virtual DbSet<SaBitacoraImporteTercero> SaBitacoraImporteTerceros { get; set; }

    public virtual DbSet<SaCargosTransMembresium> SaCargosTransMembresia { get; set; }

    public virtual DbSet<SaCliente> SaClientes { get; set; }

    public virtual DbSet<SaCodAcceso> SaCodAccesos { get; set; }

    public virtual DbSet<SaCodBanco> SaCodBancos { get; set; }

    public virtual DbSet<SaCodBitacoraMembresium> SaCodBitacoraMembresia { get; set; }

    public virtual DbSet<SaCodCaja> SaCodCajas { get; set; }

    public virtual DbSet<SaCodCalculo> SaCodCalculos { get; set; }

    public virtual DbSet<SaCodCobro> SaCodCobros { get; set; }

    public virtual DbSet<SaCodEmpresa> SaCodEmpresas { get; set; }

    public virtual DbSet<SaCodEstcer> SaCodEstcers { get; set; }

    public virtual DbSet<SaCodEstusu> SaCodEstusus { get; set; }

    public virtual DbSet<SaCodExtra01> SaCodExtra01s { get; set; }

    public virtual DbSet<SaCodGrupoPar> SaCodGrupoPars { get; set; }

    public virtual DbSet<SaCodGrupoSer> SaCodGrupoSers { get; set; }

    public virtual DbSet<SaCodGrupoUsu> SaCodGrupoUsus { get; set; }

    public virtual DbSet<SaCodOpcion> SaCodOpcions { get; set; }

    public virtual DbSet<SaCodReg> SaCodRegs { get; set; }

    public virtual DbSet<SaCodRelacionMembresiaCompraMantenimiento> SaCodRelacionMembresiaCompraMantenimientos { get; set; }

    public virtual DbSet<SaCodSubtipo> SaCodSubtipos { get; set; }

    public virtual DbSet<SaCodSucursal> SaCodSucursals { get; set; }

    public virtual DbSet<SaCodTipo> SaCodTipos { get; set; }

    public virtual DbSet<SaCodTipoCompra> SaCodTipoCompras { get; set; }

    public virtual DbSet<SaCodTipoMantenimiento> SaCodTipoMantenimientos { get; set; }

    public virtual DbSet<SaCodTipoMembresium> SaCodTipoMembresia { get; set; }

    public virtual DbSet<SaCodTipoTransaccion> SaCodTipoTransaccions { get; set; }

    public virtual DbSet<SaCodTransMembresium> SaCodTransMembresia { get; set; }

    public virtual DbSet<SaCodTransaccion> SaCodTransaccions { get; set; }

    public virtual DbSet<SaCodTransaccionBitacora> SaCodTransaccionBitacoras { get; set; }

    public virtual DbSet<SaCodTransaccionMembresium> SaCodTransaccionMembresia { get; set; }

    public virtual DbSet<SaConsumo> SaConsumos { get; set; }

    public virtual DbSet<SaDependiente> SaDependientes { get; set; }

    public virtual DbSet<SaDesDocumentoDigitalizado> SaDesDocumentoDigitalizados { get; set; }

    public virtual DbSet<SaDestinatario> SaDestinatarios { get; set; }

    public virtual DbSet<SaDetallePagoMixto> SaDetallePagoMixtos { get; set; }

    public virtual DbSet<SaDocumento> SaDocumentos { get; set; }

    public virtual DbSet<SaDocumentoDigitalizado> SaDocumentoDigitalizados { get; set; }

    public virtual DbSet<SaExcepcionesImporte> SaExcepcionesImportes { get; set; }

    public virtual DbSet<SaFotografium> SaFotografia { get; set; }

    public virtual DbSet<SaImporte> SaImportes { get; set; }

    public virtual DbSet<SaImporteArchivoTercero> SaImporteArchivoTerceros { get; set; }

    public virtual DbSet<SaImporteBonificacion> SaImporteBonificacions { get; set; }

    public virtual DbSet<SaImportePredeterminadoImporte> SaImportePredeterminadoImportes { get; set; }

    public virtual DbSet<SaImportePredeterminadoImportePrueba> SaImportePredeterminadoImportePruebas { get; set; }

    public virtual DbSet<SaImportePredeterminadoTercero> SaImportePredeterminadoTerceros { get; set; }

    public virtual DbSet<SaImportePredeterminadoTerceroPrueba> SaImportePredeterminadoTerceroPruebas { get; set; }

    public virtual DbSet<SaImporteTercero> SaImporteTerceros { get; set; }

    public virtual DbSet<SaImporteTerceroBitacora> SaImporteTerceroBitacoras { get; set; }

    public virtual DbSet<SaImporteTerceroPrueba> SaImporteTerceroPruebas { get; set; }

    public virtual DbSet<SaLugare> SaLugares { get; set; }

    public virtual DbSet<SaMovimientosDetum> SaMovimientosDeta { get; set; }

    public virtual DbSet<SaMovimientosEnca> SaMovimientosEncas { get; set; }

    public virtual DbSet<SaParametro> SaParametros { get; set; }

    public virtual DbSet<SaParametrosDeAccion> SaParametrosDeAccions { get; set; }

    public virtual DbSet<SaPlazoPagoMembresium> SaPlazoPagoMembresia { get; set; }

    public virtual DbSet<SaSeguridad> SaSeguridads { get; set; }

    public virtual DbSet<SaSerie> SaSeries { get; set; }

    public virtual DbSet<SaTercero> SaTerceros { get; set; }

    public virtual DbSet<SaTerceroArchivo> SaTerceroArchivos { get; set; }

    public virtual DbSet<SaUsuario> SaUsuarios { get; set; }

    public virtual DbSet<SaVerificarTer> SaVerificarTers { get; set; }

    public virtual DbSet<SaVisitum> SaVisita { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(coneccion);

        }
    }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    if (!optionsBuilder.IsConfigured)
    //    {

    //    }
    //}
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder);
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Server=DLUGO_PC\\SQL_DLUGO_2K22;Database=cuotas_v100;UID=sa;PWD=Usuario1;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Appautorizaciond>(entity =>
        {
            entity.HasKey(e => new { e.CodTercero, e.CodDependiente });

            entity.ToTable("APPAUTORIZACIOND");

            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.CodAutorizacion).HasColumnName("COD_AUTORIZACION");
        });

        modelBuilder.Entity<Appautorizaciont>(entity =>
        {
            entity.HasKey(e => e.CodTercero);

            entity.ToTable("APPAUTORIZACIONT");

            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodAutorizacion).HasColumnName("COD_AUTORIZACION");
        });
        modelBuilder.Entity<Applogin>(entity =>
        {
            entity.HasKey(e => e.CodUsuario);

            entity.ToTable("APPLOGIN");

            entity.Property(e => e.CodUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.ClaUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CLA_USUARIO");
        });
        modelBuilder.Entity<Apprespuestaautenticacion>(entity =>
        {
            entity.HasKey(e => e.CodUsuario);

            entity.ToTable("APPRESPUESTAAUTE");

            entity.Property(e => e.token)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("TOKEN");
            entity.Property(e => e.expiracion)
                .HasColumnType("datetime")
                .HasColumnName("EXPIRACION");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
        });
        modelBuilder.Entity<Appusuario>(entity =>
        {
            entity.HasKey(e => e.CodUsuario);

            entity.ToTable("APPUSUARIO");

            entity.Property(e => e.CodUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.ClaUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CLA_USUARIO");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.CodEstusu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTUSU");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.NomUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARIO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<Etipodocumento>(entity =>
        {
            entity.HasKey(e => e.CodTipodocumento);

            entity.ToTable("ETIPODOCUMENTO");

            entity.Property(e => e.CodTipodocumento).HasColumnName("COD_TIPODOCUMENTO");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodEstusu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTUSU");
            entity.Property(e => e.NomTipodocumento)
                .HasMaxLength(50)
                .HasColumnName("NOM_TIPODOCUMENTO");

            entity.HasOne(d => d.SaCodEstusu).WithMany(p => p.Etipodocumentos)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodEstusu })
                .HasConstraintName("FK_ETIPODOCUMENTO_SA_COD_ESTUSU");
        });

        modelBuilder.Entity<Expediente>(entity =>
        {
            entity.HasKey(e => new { e.CodArchivo, e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodDependiente, e.CodTipodocumento });

            entity.ToTable("Expediente");

            entity.Property(e => e.CodArchivo)
                .ValueGeneratedOnAdd()
                .HasColumnName("COD_ARCHIVO");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.CodTipodocumento).HasColumnName("COD_TIPODOCUMENTO");
            entity.Property(e => e.CodEstusu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTUSU");
            entity.Property(e => e.Documento).HasColumnName("DOCUMENTO");
            entity.Property(e => e.ExtDocumento)
                .HasMaxLength(100)
                .HasColumnName("EXT_DOCUMENTO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.NomDocumento)
                .HasMaxLength(50)
                .HasColumnName("NOM_DOCUMENTO");

            entity.HasOne(d => d.CodTipodocumentoNavigation).WithMany(p => p.Expedientes)
                .HasForeignKey(d => d.CodTipodocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Expediente_ETipoDocumento");

            entity.HasOne(d => d.SaCodEstusu).WithMany(p => p.Expedientes)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodEstusu })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Expediente_SA_COD_ESTUSU");

            entity.HasOne(d => d.SaDependiente).WithMany(p => p.Expedientes)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodTercero, d.CodDependiente })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Expediente_SA_DEPENDIENTE");
        });

        modelBuilder.Entity<ExpedienteIntermediaria>(entity =>
        {
            entity.HasKey(e => new { e.CodArchivo, e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodDependiente, e.CodTipodocumento });

            entity.ToTable("EXPEDIENTE_INTERMEDIARIA");

            entity.Property(e => e.CodArchivo)
                .ValueGeneratedOnAdd()
                .HasColumnName("COD_ARCHIVO");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.CodTipodocumento).HasColumnName("COD_TIPODOCUMENTO");
            entity.Property(e => e.CodEstusu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTUSU");
            entity.Property(e => e.Documento).HasColumnName("DOCUMENTO");
            entity.Property(e => e.ExtDocumento)
                .HasMaxLength(100)
                .HasColumnName("EXT_DOCUMENTO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.NomDocumento)
                .HasMaxLength(50)
                .HasColumnName("NOM_DOCUMENTO");

          
        });

        modelBuilder.Entity<Expedientetercero>(entity =>
        {
            entity.HasKey(e => new { e.CodArchivo, e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodTipodocumento });

            entity.ToTable("Expedientetercero");

            entity.Property(e => e.CodArchivo)
                .ValueGeneratedOnAdd()
                .HasColumnName("COD_ARCHIVO");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodTipodocumento).HasColumnName("COD_TIPODOCUMENTO");
            entity.Property(e => e.CodEstusu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTUSU");
            entity.Property(e => e.Documento).HasColumnName("DOCUMENTO");
            entity.Property(e => e.ExtDocumento)
                .HasMaxLength(100)
                .HasColumnName("EXT_DOCUMENTO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.NomDocumento)
                .HasMaxLength(50)
                .HasColumnName("NOM_DOCUMENTO");

            entity.HasOne(d => d.CodTipodocumentoNavigation).WithMany(p => p.Expedienteterceros)
                .HasForeignKey(d => d.CodTipodocumento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Expedientetercero_ETIPODOCUMENTO");

            entity.HasOne(d => d.SaCodEstusu).WithMany(p => p.Expedienteterceros)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodEstusu })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Expedientetercero_SA_COD_ESTUSU");

            entity.HasOne(d => d.SaTercero).WithMany(p => p.Expedienteterceros)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodTercero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Expedientetercero_SA_TERCERO");
        });

        modelBuilder.Entity<SaBiometriaCopium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_BIOMETRIA_COPIA");

            entity.Property(e => e.Biometria)
                .HasColumnType("image")
                .HasColumnName("BIOMETRIA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
        });

        modelBuilder.Entity<SaBiometrium>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodDependiente });

            entity.ToTable("SA_BIOMETRIA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.Biometria)
                .HasMaxLength(4000)
                .IsUnicode(false)
                .HasColumnName("BIOMETRIA");

            entity.HasOne(d => d.SaTercero).WithMany(p => p.SaBiometria)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodTercero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_BIOMETRIA_SA_TERCERO");
        });

        modelBuilder.Entity<SaBitacoraGeneracion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_BITACORA_GENERACION");

            entity.Property(e => e.FecFin)
                .HasColumnType("datetime")
                .HasColumnName("FEC_FIN");
            entity.Property(e => e.FecInicio)
                .HasColumnType("datetime")
                .HasColumnName("FEC_INICIO");
            entity.Property(e => e.FecModificacion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_MODIFICACION");
            entity.Property(e => e.FecRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REGISTRO");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Periodo)
                .HasColumnType("datetime")
                .HasColumnName("PERIODO");
            entity.Property(e => e.UsuModificacion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USU_MODIFICACION");
            entity.Property(e => e.Usuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<SaBitacoraImporteTercero>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_BITACORA_IMPORTE_TERCERO");

            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
        });

        modelBuilder.Entity<SaCargosTransMembresium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_CARGOS_TRANS_MEMBRESIA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodPlaMem)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("COD_PLA_MEM");
            entity.Property(e => e.CodTipoMembresia)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MEMBRESIA");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.TipoTransaccion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPO_TRANSACCION");
        });

        modelBuilder.Entity<SaCliente>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente });

            entity.ToTable("SA_CLIENTE");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodBusca)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_BUSCA");
            entity.Property(e => e.CodCobro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_COBRO");
            entity.Property(e => e.CodDeshabilitarImp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_DESHABILITAR_IMP");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodOperacion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_OPERACION");
            entity.Property(e => e.CodProducto)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_PRODUCTO");
            entity.Property(e => e.Extra01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.LonExtra01)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("LON_EXTRA01");
            entity.Property(e => e.LonExtra02)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("LON_EXTRA02");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.NomCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOM_CLIENTE");
            entity.Property(e => e.NumCuenta)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NUM_CUENTA");
            entity.Property(e => e.Tercero01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TERCERO01");
            entity.Property(e => e.Tercero02)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TERCERO02");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaClientes)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_CLIENTE_SA_COD_EMPRESA");

            entity.HasOne(d => d.SaCodCobro).WithMany(p => p.SaClientes)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCobro })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_CLIENTE_SA_COD_COBRO");
        });

        modelBuilder.Entity<SaCodAcceso>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodAcceso });

            entity.ToTable("SA_COD_ACCESO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodAcceso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ACCESO");
            entity.Property(e => e.DesAcceso)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_ACCESO");
        });

        modelBuilder.Entity<SaCodBanco>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodBanco });

            entity.ToTable("SA_COD_BANCO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodBanco)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_BANCO");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesBanco)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_BANCO");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodBancos)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_BANCO_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodBitacoraMembresium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_COD_BITACORA_MEMBRESIA");

            entity.Property(e => e.CodBitacoraMembresia)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_BITACORA_MEMBRESIA");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUCURSAL");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodTransaccionMembresia)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_TRANSACCION_MEMBRESIA");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Observacion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION");
        });

        modelBuilder.Entity<SaCodCaja>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCaja }).HasName("PK_SA_CAJA");

            entity.ToTable("SA_COD_CAJA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCaja)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CAJA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesCaja)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_CAJA");
        });

        modelBuilder.Entity<SaCodCalculo>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodTipo, e.CodSubtipo, e.CodCalculo });

            entity.ToTable("SA_COD_CALCULO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodTipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO");
            entity.Property(e => e.CodSubtipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUBTIPO");
            entity.Property(e => e.CodCalculo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_CALCULO");
            entity.Property(e => e.CodEtiqueta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ETIQUETA");
            entity.Property(e => e.CodOrigen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ORIGEN");
            entity.Property(e => e.CodPeriodo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_PERIODO");
            entity.Property(e => e.DesCalculo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_CALCULO");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodCalculos)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_CALCULO_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodCobro>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCobro });

            entity.ToTable("SA_COD_COBRO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCobro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_COBRO");
            entity.Property(e => e.DesCobro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_COBRO");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodCobros)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_COBRO_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodEmpresa>(entity =>
        {
            entity.HasKey(e => e.CodEmpresa);

            entity.ToTable("SA_COD_EMPRESA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.Basser1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BASSER1");
            entity.Property(e => e.Basser2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BASSER2");
            entity.Property(e => e.Basser3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BASSER3");
            entity.Property(e => e.DesEmpresa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_EMPRESA");
            entity.Property(e => e.Nomser1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMSER1");
            entity.Property(e => e.Nomser2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMSER2");
            entity.Property(e => e.Nomser3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMSER3");
            entity.Property(e => e.Passer1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSER1");
            entity.Property(e => e.Passer2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSER2");
            entity.Property(e => e.Passer3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PASSER3");
            entity.Property(e => e.Ususer1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUSER1");
            entity.Property(e => e.Ususer2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUSER2");
            entity.Property(e => e.Ususer3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUSER3");
            entity.Property(e => e.Versis)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("VERSIS");
        });

        modelBuilder.Entity<SaCodEstcer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_COD_ESTCER");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesEstado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_ESTADO");
        });

        modelBuilder.Entity<SaCodEstusu>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodEstusu });

            entity.ToTable("SA_COD_ESTUSU");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodEstusu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTUSU");
            entity.Property(e => e.DesEstusu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DES_ESTUSU");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodEstusus)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_ESTUSU_SA_COD_EMPRESA1");
        });

        modelBuilder.Entity<SaCodExtra01>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodImporte, e.Extra01 });

            entity.ToTable("SA_COD_EXTRA01");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.Extra01)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.Extra02)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");

            entity.HasOne(d => d.SaImporte).WithMany(p => p.SaCodExtra01s)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodImporte })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_EXTRA01_SA_IMPORTE");
        });

        modelBuilder.Entity<SaCodGrupoPar>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodGrupo });

            entity.ToTable("SA_COD_GRUPO_PAR");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_GRUPO");
            entity.Property(e => e.DesGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_GRUPO");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodGrupoPars)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_GRUPO_PAR_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodGrupoSer>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodGrupo });

            entity.ToTable("SA_COD_GRUPO_SER");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_GRUPO");
            entity.Property(e => e.DesGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_GRUPO");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodGrupoSers)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_GRUPO_SER_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodGrupoUsu>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodGrupo });

            entity.ToTable("SA_COD_GRUPO_USU");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_GRUPO");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesGrupo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_GRUPO");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodGrupoUsus)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_GRUPO_USU_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodOpcion>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodOpcion });

            entity.ToTable("SA_COD_OPCION");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodOpcion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_OPCION");
            entity.Property(e => e.DesOpcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_OPCION");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodOpcions)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_OPCION_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodReg>(entity =>
        {
            entity.HasKey(e => e.CodReg);

            entity.ToTable("SA_COD_REG");

            entity.Property(e => e.CodReg)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_REG");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUCURSAL");
            entity.Property(e => e.DesReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_REG");
        });

        modelBuilder.Entity<SaCodRelacionMembresiaCompraMantenimiento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_COD_RELACION_MEMBRESIA_COMPRA_MANTENIMIENTO");

            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodRelacion)
                .ValueGeneratedOnAdd()
                .HasColumnName("COD_RELACION");
            entity.Property(e => e.CodTipoCompra)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_COMPRA");
            entity.Property(e => e.CodTipoMantenimiento)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MANTENIMIENTO");
            entity.Property(e => e.CodTipoMembresia)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MEMBRESIA");
        });

        modelBuilder.Entity<SaCodSubtipo>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodTipo, e.CodSubtipo });

            entity.ToTable("SA_COD_SUBTIPO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodTipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO");
            entity.Property(e => e.CodSubtipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUBTIPO");
            entity.Property(e => e.DesSubtipo)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DES_SUBTIPO");

            entity.HasOne(d => d.SaCodTipo).WithMany(p => p.SaCodSubtipos)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodTipo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_SUBTIPO_SA_COD_TIPO");
        });

        modelBuilder.Entity<SaCodSucursal>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodSucursal });

            entity.ToTable("SA_COD_SUCURSAL");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUCURSAL");
            entity.Property(e => e.DesSucursal)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_SUCURSAL");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodSucursals)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_SUCURSAL_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodTipo>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodTipo });

            entity.ToTable("SA_COD_TIPO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodTipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO");
            entity.Property(e => e.DesTipo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DES_TIPO");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodTipos)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_TIPO_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodTipoCompra>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodTipoCompra }).HasName("PK_SA_COD_TIPO_COMRA");

            entity.ToTable("SA_COD_TIPO_COMPRA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodTipoCompra)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_COMPRA");
            entity.Property(e => e.DesTipoCompra)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_TIPO_COMPRA");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodTipoCompras)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_TIPO_COMPRA_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodTipoMantenimiento>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodTipoMantenimiento });

            entity.ToTable("SA_COD_TIPO_MANTENIMIENTO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodTipoMantenimiento)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MANTENIMIENTO");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesTipoMantenimiento)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DES_TIPO_MANTENIMIENTO");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodTipoMantenimientos)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_TIPO_MANTENIMIENTO_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodTipoMembresium>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodTipoMembresia });

            entity.ToTable("SA_COD_TIPO_MEMBRESIA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodTipoMembresia)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MEMBRESIA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.DesTipoMembresia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DES_TIPO_MEMBRESIA");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodTipoMembresia)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_TIPO_MEMBRESIA_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodTipoTransaccion>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodTipoTransaccion });

            entity.ToTable("SA_COD_TIPO_TRANSACCION");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodTipoTransaccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_TRANSACCION");
            entity.Property(e => e.DesTipoTransaccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_TIPO_TRANSACCION");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaCodTipoTransaccions)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_TIPO_TRANSACCION_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaCodTransMembresium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_COD_TRANS_MEMBRESIA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodTrans)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("COD_TRANS");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
        });

        modelBuilder.Entity<SaCodTransaccion>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodTransaccion });

            entity.ToTable("SA_COD_TRANSACCION");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodTransaccion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TRANSACCION");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodTipoTransaccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_TRANSACCION");
            entity.Property(e => e.DesTransaccion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_TRANSACCION");

            entity.HasOne(d => d.SaCodTipoTransaccion).WithMany(p => p.SaCodTransaccions)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodTipoTransaccion })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_COD_TRANSACCION_SA_COD_EMPRESA1");
        });

        modelBuilder.Entity<SaCodTransaccionBitacora>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_COD_TRANSACCION_BITACORA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodTransaccionMembresia)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_TRANSACCION_MEMBRESIA");
            entity.Property(e => e.DesTransaccionMembresia)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_TRANSACCION_MEMBRESIA");
        });

        modelBuilder.Entity<SaCodTransaccionMembresium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_COD_TRANSACCION_MEMBRESIA");

            entity.Property(e => e.CodBitacoraMembresia)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_BITACORA_MEMBRESIA");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUCURSAL");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodTransaccionMembresia)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_TRANSACCION_MEMBRESIA");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Observacion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION");
        });

        modelBuilder.Entity<SaConsumo>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodConsumo });

            entity.ToTable("SA_CONSUMO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodConsumo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_CONSUMO");
            entity.Property(e => e.CodCaja)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CAJA");
            entity.Property(e => e.CodCajaDetalleVen)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_CAJA_DETALLE_VEN");
            entity.Property(e => e.CodCajaVen)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_CAJA_VEN");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.CodVenta)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_VENTA");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Folio)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("FOLIO");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Serie)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SERIE");
        });

        modelBuilder.Entity<SaDependiente>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodDependiente });

            entity.ToTable("SA_DEPENDIENTE");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.CodCredencial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_CREDENCIAL");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.FecNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FEC_NACIMIENTO");
            entity.Property(e => e.LimiteCredito)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("LIMITE_CREDITO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.SaldoCredito)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SALDO_CREDITO");

           /* entity.HasOne(d => d.SaTercero).WithMany(p => p.SaDependientes)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodTercero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_DEPENDIENTE_SA_TERCERO");*/
        });

        modelBuilder.Entity<SaDesDocumentoDigitalizado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_DES_DOCUMENTO_DIGITALIZADO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodTipoDocumento)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("COD_TIPO_DOCUMENTO");
            entity.Property(e => e.DesTipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_TIPO_DOCUMENTO");
        });

        modelBuilder.Entity<SaDestinatario>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodDestinatario });

            entity.ToTable("SA_DESTINATARIO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodDestinatario)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_DESTINATARIO");
            entity.Property(e => e.CorDestinatario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COR_DESTINATARIO");
            entity.Property(e => e.NomDestinatario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOM_DESTINATARIO");

            entity.HasOne(d => d.SaCliente).WithMany(p => p.SaDestinatarios)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_DESTINATARIO_SA_CLIENTE");
        });

        modelBuilder.Entity<SaDetallePagoMixto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_DETALLE_PAGO_MIXTO");

            entity.Property(e => e.Banco).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Cheque).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Deposito).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Efectivo).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.IdMixto).ValueGeneratedOnAdd();
            entity.Property(e => e.MontoTotal).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Tarjeta).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UsuarioActualizacion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioCreacion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SaDocumento>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodTipoDocumento, e.CodSerie, e.CodDocumento });

            entity.ToTable("SA_DOCUMENTO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodTipoDocumento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_DOCUMENTO");
            entity.Property(e => e.CodSerie)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SERIE");
            entity.Property(e => e.CodDocumento)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DOCUMENTO");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodMovimiento)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_MOVIMIENTO");
            entity.Property(e => e.CodSistema)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SISTEMA");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodTipoMovimiento)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MOVIMIENTO");
            entity.Property(e => e.FecDocumento)
                .HasColumnType("datetime")
                .HasColumnName("FEC_DOCUMENTO");
            entity.Property(e => e.MonDocumento)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_DOCUMENTO");
            entity.Property(e => e.Observacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaDocumentos)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_DOCUMENTO_SA_COD_EMPRESA");
        });

        modelBuilder.Entity<SaDocumentoDigitalizado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_DOCUMENTO_DIGITALIZADO");

            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUCURSAL");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodTipoDocumento)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("COD_TIPO_DOCUMENTO");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO");
            entity.Property(e => e.Frente)
                .HasColumnType("image")
                .HasColumnName("FRENTE");
            entity.Property(e => e.Reverso)
                .HasColumnType("image")
                .HasColumnName("REVERSO");
        });

        modelBuilder.Entity<SaExcepcionesImporte>(entity =>
        {
            entity.HasKey(e => e.CodExcepcion).HasName("PK__SA_EXCEPCIONES_I__228D5B61");

            entity.ToTable("SA_EXCEPCIONES_IMPORTES");

            entity.Property(e => e.CodExcepcion).HasColumnName("COD_EXCEPCION");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodImporte)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodTipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO");
            entity.Property(e => e.FecFin)
                .HasColumnType("datetime")
                .HasColumnName("FEC_FIN");
            entity.Property(e => e.FecIni)
                .HasColumnType("datetime")
                .HasColumnName("FEC_INI");
            entity.Property(e => e.Parametro)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PARAMETRO");
        });

        modelBuilder.Entity<SaFotografium>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodDependiente });

            entity.ToTable("SA_FOTOGRAFIA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.Fotografia)
                .HasColumnType("image")
                .HasColumnName("FOTOGRAFIA");

            entity.HasOne(d => d.SaTercero).WithMany(p => p.SaFotografia)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodTercero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_FOTOGRAFIA_SA_TERCERO");
        });

        modelBuilder.Entity<SaImporte>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodImporte });

            entity.ToTable("SA_IMPORTE");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.CodConcepto)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_CONCEPTO");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodSubtipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUBTIPO");
            entity.Property(e => e.CodTipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO");
            entity.Property(e => e.DesImporte)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_IMPORTE");
            entity.Property(e => e.Extra01)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.FecFin)
                .HasColumnType("datetime")
                .HasColumnName("FEC_FIN");
            entity.Property(e => e.FecInicio)
                .HasColumnType("datetime")
                .HasColumnName("FEC_INICIO");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO");
            entity.Property(e => e.PorIva)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("POR_IVA");
            entity.Property(e => e.TipoCobro)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("TIPO_COBRO");

            entity.HasOne(d => d.SaCliente).WithMany(p => p.SaImportes)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente })
                .HasConstraintName("FK_SA_IMPORTE_SA_CLIENTE");

            entity.HasOne(d => d.SaCodSubtipo).WithMany(p => p.SaImportes)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodTipo, d.CodSubtipo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_IMPORTE_SA_COD_SUBTIPO");
        });

        modelBuilder.Entity<SaImporteArchivoTercero>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_IMPORTE_ARCHIVO_TERCERO");

            entity.Property(e => e.Abono)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("ABONO");
            entity.Property(e => e.Bonificacion)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("BONIFICACION");
            entity.Property(e => e.Cargo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("CARGO");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.CodImporteArchivo).HasColumnName("COD_IMPORTE_ARCHIVO");
            entity.Property(e => e.CodPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("COD_PERIODO");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.FecArchivo)
                .HasColumnType("datetime")
                .HasColumnName("FEC_ARCHIVO");
            entity.Property(e => e.FecRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REGISTRO");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO");
            entity.Property(e => e.MontoOriginal)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO_ORIGINAL");
            entity.Property(e => e.NumPeriodo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("NUM_PERIODO");
            entity.Property(e => e.Razon)
                .HasMaxLength(350)
                .IsUnicode(false)
                .HasColumnName("RAZON");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("SALDO");
            entity.Property(e => e.TotPeriodos)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("TOT_PERIODOS");
        });

        modelBuilder.Entity<SaImporteBonificacion>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodImporte });

            entity.ToTable("SA_IMPORTE_BONIFICACION");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO");

            entity.HasOne(d => d.SaImporte).WithMany(p => p.SaImporteBonificacions)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodImporte })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_IMPORTE_BONIFICACION_SA_IMPORTE");

            entity.HasOne(d => d.SaTercero).WithMany(p => p.SaImporteBonificacions)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodTercero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_IMPORTE_BONIFICACION_SA_TERCERO");
        });

        modelBuilder.Entity<SaImportePredeterminadoImporte>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodDetalle, e.CodImporte });

            entity.ToTable("SA_IMPORTE_PREDETERMINADO_IMPORTE");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodDetalle)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_DETALLE");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.FecFin)
                .HasColumnType("datetime")
                .HasColumnName("FEC_FIN");
            entity.Property(e => e.FecInicio)
                .HasColumnType("datetime")
                .HasColumnName("FEC_INICIO");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOTAL");

            entity.HasOne(d => d.SaImporte).WithMany(p => p.SaImportePredeterminadoImportes)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodImporte })
                .HasConstraintName("FK_SA_IMPORTE_PREDETERMINADO_IMPORTE_SA_IMPORTE");

            entity.HasOne(d => d.SaTercero).WithMany(p => p.SaImportePredeterminadoImportes)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodTercero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_IMPORTE_PREDETERMINADO_IMPORTE_SA_TERCERO");
        });

        modelBuilder.Entity<SaImportePredeterminadoImportePrueba>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodDetalle, e.CodImporte }).HasName("PK_SA_IMPORTE_PREDETERMINADO_IMPORTE_pruebas");

            entity.ToTable("SA_IMPORTE_PREDETERMINADO_IMPORTE_PRUEBAS");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodDetalle)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_DETALLE");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.Cantidad)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("CANTIDAD");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.FecFin)
                .HasColumnType("datetime")
                .HasColumnName("FEC_FIN");
            entity.Property(e => e.FecInicio)
                .HasColumnType("datetime")
                .HasColumnName("FEC_INICIO");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.Total)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<SaImportePredeterminadoTercero>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodDetalle, e.CodDependiente });

            entity.ToTable("SA_IMPORTE_PREDETERMINADO_TERCERO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodDetalle)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_DETALLE");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.FecFin)
                .HasColumnType("datetime")
                .HasColumnName("FEC_FIN");
            entity.Property(e => e.FecInicio)
                .HasColumnType("datetime")
                .HasColumnName("FEC_INICIO");

            entity.HasOne(d => d.SaTercero).WithMany(p => p.SaImportePredeterminadoTerceros)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodTercero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_IMPORTE_PREDETERMINADO_TERCERO_SA_TERCERO1");
        });

        modelBuilder.Entity<SaImportePredeterminadoTerceroPrueba>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodDetalle, e.CodDependiente });

            entity.ToTable("SA_IMPORTE_PREDETERMINADO_TERCERO_PRUEBAS");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodDetalle)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_DETALLE");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.FecFin)
                .HasColumnType("datetime")
                .HasColumnName("FEC_FIN");
            entity.Property(e => e.FecInicio)
                .HasColumnType("datetime")
                .HasColumnName("FEC_INICIO");
        });

        modelBuilder.Entity<SaImporteTercero>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodPeriodo, e.CodImporte }).HasName("PK_SA_IMPORTE_TERCERO_1");

            entity.ToTable("SA_IMPORTE_TERCERO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("COD_PERIODO");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.Abono)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("ABONO");
            entity.Property(e => e.Bonificacion)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("BONIFICACION");
            entity.Property(e => e.Cargo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("CARGO");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.FecRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REGISTRO");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO");
            entity.Property(e => e.MontoOriginal)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO_ORIGINAL");
            entity.Property(e => e.NumPeriodo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("NUM_PERIODO");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("SALDO");
            entity.Property(e => e.TotPeriodos)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("TOT_PERIODOS");

            entity.HasOne(d => d.SaImporte).WithMany(p => p.SaImporteTerceros)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodImporte })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_IMPORTE_TERCERO_SA_IMPORTE1");

            entity.HasOne(d => d.SaTercero).WithMany(p => p.SaImporteTerceros)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodTercero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_IMPORTE_TERCERO_SA_TERCERO2");
        });

        modelBuilder.Entity<SaImporteTerceroBitacora>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodPeriodo, e.CodImporte }).HasName("PK_SA_IMPORTE_TERCERO_BITACORA1");

            entity.ToTable("SA_IMPORTE_TERCERO_BITACORA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("COD_PERIODO");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.Abono)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("ABONO");
            entity.Property(e => e.Bonificacion)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("BONIFICACION");
            entity.Property(e => e.Cargo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("CARGO");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.FecRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REGISTRO");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO");
            entity.Property(e => e.MontoOriginal)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO_ORIGINAL");
            entity.Property(e => e.NumPeriodo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("NUM_PERIODO");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("SALDO");
            entity.Property(e => e.TotPeriodos)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("TOT_PERIODOS");

            entity.HasOne(d => d.SaImporte).WithMany(p => p.SaImporteTerceroBitacoras)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodImporte })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_IMPORTE_TERCERO_BITACORA_SA_IMPORTE1");

            entity.HasOne(d => d.SaTercero).WithMany(p => p.SaImporteTerceroBitacoras)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodTercero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_IMPORTE_TERCERO_BITACORA_SA_TERCERO2");
        });

        modelBuilder.Entity<SaImporteTerceroPrueba>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero, e.CodPeriodo, e.CodImporte }).HasName("PK_SA_IMPORTE_TERCERO_PRUEBAS_1");

            entity.ToTable("SA_IMPORTE_TERCERO_PRUEBAS");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("COD_PERIODO");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.Abono)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("ABONO");
            entity.Property(e => e.Bonificacion)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("BONIFICACION");
            entity.Property(e => e.Cargo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("CARGO");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.Descuento)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DESCUENTO");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.FecRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REGISTRO");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO");
            entity.Property(e => e.MontoOriginal)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO_ORIGINAL");
            entity.Property(e => e.NumPeriodo)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("NUM_PERIODO");
            entity.Property(e => e.Saldo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("SALDO");
            entity.Property(e => e.TotPeriodos)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("TOT_PERIODOS");
        });

        modelBuilder.Entity<SaLugare>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodImporte, e.Extra01 });

            entity.ToTable("SA_LUGARES");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");

            entity.HasOne(d => d.SaImporte).WithMany(p => p.SaLugares)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodImporte })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_LUGARES_SA_IMPORTE1");
        });

        modelBuilder.Entity<SaMovimientosDetum>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodMovimiento, e.CodTipo, e.CodDetalle });

            entity.ToTable("SA_MOVIMIENTOS_DETA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodMovimiento)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_MOVIMIENTO");
            entity.Property(e => e.CodTipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO");
            entity.Property(e => e.CodDetalle)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_DETALLE");
            entity.Property(e => e.AFavorAplicado)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("A_FAVOR_APLICADO");
            entity.Property(e => e.CobradoAplicado)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("COBRADO_APLICADO");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodFactura)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_FACTURA");
            entity.Property(e => e.CodImporte)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_IMPORTE");
            entity.Property(e => e.CodPeriodo)
                .HasColumnType("datetime")
                .HasColumnName("COD_PERIODO");
            entity.Property(e => e.CodRecibo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_RECIBO");
            entity.Property(e => e.CodReferencia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("COD_REFERENCIA");
            entity.Property(e => e.CodSubtipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUBTIPO");
            entity.Property(e => e.CodTipoTransaccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_TRANSACCION");
            entity.Property(e => e.CodTransaccion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TRANSACCION");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.MonAdeudoAnterior)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MON_ADEUDO_ANTERIOR");
            entity.Property(e => e.MonAdeudoAnteriorSinRecargo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MON_ADEUDO_ANTERIOR_SIN_RECARGO");
            entity.Property(e => e.MonBonificacion)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MON_BONIFICACION");
            entity.Property(e => e.MonDescuento)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MON_DESCUENTO");
            entity.Property(e => e.MonIvaAdeudo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MON_IVA_ADEUDO");
            entity.Property(e => e.MonOriginal)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MON_ORIGINAL");
            entity.Property(e => e.MonSubtotalAdeudo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MON_SUBTOTAL_ADEUDO");
            entity.Property(e => e.MonTotalAdeudo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MON_TOTAL_ADEUDO");
            entity.Property(e => e.PorIva)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("POR_IVA");
            entity.Property(e => e.Recargo)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("RECARGO");
            entity.Property(e => e.TotPeriodos)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("TOT_PERIODOS");
        });

        modelBuilder.Entity<SaMovimientosEnca>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodMovimiento });

            entity.ToTable("SA_MOVIMIENTOS_ENCA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodMovimiento)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_MOVIMIENTO");
            entity.Property(e => e.CobCargoTarjeta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COB_CARGO_TARJETA");
            entity.Property(e => e.CodAnuMembresia)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_ANU_MEMBRESIA");
            entity.Property(e => e.CodAnuMembresiaAnt)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_ANU_MEMBRESIA_ANT");
            entity.Property(e => e.CodBanco)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_BANCO");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodComrobante)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_COMROBANTE");
            entity.Property(e => e.CodDocumento)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DOCUMENTO");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodFactura)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_FACTURA");
            entity.Property(e => e.CodInstrumento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_INSTRUMENTO");
            entity.Property(e => e.CodMenMembresia)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_MEN_MEMBRESIA");
            entity.Property(e => e.CodMenMembresiaAnt)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_MEN_MEMBRESIA_ANT");
            entity.Property(e => e.CodRecibo)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_RECIBO");
            entity.Property(e => e.CodSerie)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SERIE");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUCURSAL");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.CodTipoDocumento)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_DOCUMENTO");
            entity.Property(e => e.CodTipoTransaccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_TRANSACCION");
            entity.Property(e => e.CodTransaccion)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TRANSACCION");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.DesAnuMembresia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DES_ANU_MEMBRESIA");
            entity.Property(e => e.DesMenMembresia)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("DES_MEN_MEMBRESIA");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.FecFacturacion)
                .HasColumnType("datetime")
                .HasColumnName("FEC_FACTURACION");
            entity.Property(e => e.FecMovimiento)
                .HasColumnType("datetime")
                .HasColumnName("FEC_MOVIMIENTO");
            entity.Property(e => e.FecReal)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REAL");
            entity.Property(e => e.FechaCancelacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CANCELACION");
            entity.Property(e => e.MonAdeudoAnterior)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_ADEUDO_ANTERIOR");
            entity.Property(e => e.MonAplicar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_APLICAR");
            entity.Property(e => e.MonBonificacion)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_BONIFICACION");
            entity.Property(e => e.MonCobrar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_COBRAR");
            entity.Property(e => e.MonDescuento)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_DESCUENTO");
            entity.Property(e => e.MonDisponible)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_DISPONIBLE");
            entity.Property(e => e.MonIvaAdeudo)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_IVA_ADEUDO");
            entity.Property(e => e.MonIvaAplicado)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_IVA_APLICADO");
            entity.Property(e => e.MonSaldoFavor)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_SALDO_FAVOR");
            entity.Property(e => e.MonSaldoFavorAnterior)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_SALDO_FAVOR_ANTERIOR");
            entity.Property(e => e.MonSubtotalAdeudo)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_SUBTOTAL_ADEUDO");
            entity.Property(e => e.MonSubtotalAplicado)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_SUBTOTAL_APLICADO");
            entity.Property(e => e.MonTotalAdeudo)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_TOTAL_ADEUDO");
            entity.Property(e => e.MonTotalAplicado)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MON_TOTAL_APLICADO");
            entity.Property(e => e.Observacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION");
            entity.Property(e => e.Referencia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("REFERENCIA");
            entity.Property(e => e.SerieFactura)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SERIE_FACTURA");
            entity.Property(e => e.SerieRecibo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("SERIE_RECIBO");
            entity.Property(e => e.TotalAbono)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("TOTAL_ABONO");
            entity.Property(e => e.UsuarioCancelacion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("USUARIO_CANCELACION");

            entity.HasOne(d => d.SaCodBanco).WithMany(p => p.SaMovimientosEncas)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodBanco })
                .HasConstraintName("FK_SA_MOVIMIENTOS_ENCA_SA_COD_BANCO");

            entity.HasOne(d => d.SaCodTransaccion).WithMany(p => p.SaMovimientosEncas)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodTransaccion })
                .HasConstraintName("FK_SA_MOVIMIENTOS_ENCA_SA_COD_TRANSACCION");

            entity.HasOne(d => d.SaTercero).WithMany(p => p.SaMovimientosEncas)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente, d.CodTercero })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_MOVIMIENTOS_ENCA_SA_TERCERO");
        });

        modelBuilder.Entity<SaParametro>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodGrupo, e.CodSubgrupo, e.CodParametro });

            entity.ToTable("SA_PARAMETRO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_GRUPO");
            entity.Property(e => e.CodSubgrupo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUBGRUPO");
            entity.Property(e => e.CodParametro)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_PARAMETRO");
            entity.Property(e => e.DesParametro)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_PARAMETRO");
            entity.Property(e => e.ValParametro)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("VAL_PARAMETRO");

            entity.HasOne(d => d.SaCodGrupoPar).WithMany(p => p.SaParametros)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodGrupo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_PARAMETRO_SA_COD_GRUPO_PAR");
        });

        modelBuilder.Entity<SaParametrosDeAccion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_PARAMETROS_DE_ACCION");

            entity.Property(e => e.Accion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACCION");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.Commentario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COMMENTARIO");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MODIFICACION");
            entity.Property(e => e.Parametro)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PARAMETRO");
            entity.Property(e => e.Valor)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VALOR");
        });

        modelBuilder.Entity<SaPlazoPagoMembresium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_PLAZO_PAGO_MEMBRESIA");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodPerPag)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_PER_PAG");
            entity.Property(e => e.CodPlaMem)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("COD_PLA_MEM");
            entity.Property(e => e.CodTipoMembresia)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MEMBRESIA");
            entity.Property(e => e.Mensualidad)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MENSUALIDAD");
            entity.Property(e => e.Monto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO");
            entity.Property(e => e.PeriodoPago)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PERIODO_PAGO");
            entity.Property(e => e.TipoAdquisicion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TIPO_ADQUISICION");
        });

        modelBuilder.Entity<SaSeguridad>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodOpcion, e.CodGrupo });

            entity.ToTable("SA_SEGURIDAD");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodOpcion)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_OPCION");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_GRUPO");
            entity.Property(e => e.CodAcceso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ACCESO");

            entity.HasOne(d => d.SaCodAcceso).WithMany(p => p.SaSeguridads)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodAcceso })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_SEGURIDAD_SA_COD_ACCESO");

            entity.HasOne(d => d.SaCodGrupoUsu).WithMany(p => p.SaSeguridads)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodGrupo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_SEGURIDAD_SA_COD_GRUPO_USU");

            entity.HasOne(d => d.SaCodOpcion).WithMany(p => p.SaSeguridads)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodOpcion })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_SEGURIDAD_SA_COD_OPCION");
        });

        modelBuilder.Entity<SaSerie>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodGrupo, e.CodSubgrupo, e.CodSerie });

            entity.ToTable("SA_SERIE");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_GRUPO");
            entity.Property(e => e.CodSubgrupo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUBGRUPO");
            entity.Property(e => e.CodSerie)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_SERIE");
            entity.Property(e => e.DesSerie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DES_SERIE");
            entity.Property(e => e.NumSerie)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("NUM_SERIE");

            entity.HasOne(d => d.SaCodGrupoSer).WithMany(p => p.SaSeries)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodGrupo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_SERIE_SA_COD_GRUPO_SER");
        });

        modelBuilder.Entity<SaTercero>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero });

            entity.ToTable("SA_TERCERO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.AnticipoMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ANTICIPO_MEMBRESIA");
            entity.Property(e => e.Celular)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.CodAnuMembresia)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_ANU_MEMBRESIA");
            entity.Property(e => e.CodCredencial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_CREDENCIAL");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodEstadoCertificado)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO_CERTIFICADO");
            entity.Property(e => e.CodMenMembresia)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_MEN_MEMBRESIA");
            entity.Property(e => e.CodTipoCompra)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_COMPRA");
            entity.Property(e => e.CodTipoMantenimiento)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MANTENIMIENTO");
            entity.Property(e => e.CodTipoMembresia)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MEMBRESIA");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.ConsumoConAduedo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CONSUMO_CON_ADUEDO");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Cp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CP");
            entity.Property(e => e.CpFiscal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CP_FISCAL");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.DomicioFiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DOMICIO_FISCAL");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.Extra03)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA03");
            entity.Property(e => e.Extra04)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA04");
            entity.Property(e => e.FecNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FEC_NACIMIENTO");
            entity.Property(e => e.FecRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REGISTRO");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MODIFICACION");
            entity.Property(e => e.FinAnuMembresia)
                .HasColumnType("datetime")
                .HasColumnName("FIN_ANU_MEMBRESIA");
            entity.Property(e => e.FinMenMembresia)
                .HasColumnType("datetime")
                .HasColumnName("FIN_MEN_MEMBRESIA");
            entity.Property(e => e.InicioAnuMembresia)
                .HasColumnType("datetime")
                .HasColumnName("INICIO_ANU_MEMBRESIA");
            entity.Property(e => e.InicioMenMembresia)
                .HasColumnType("datetime")
                .HasColumnName("INICIO_MEN_MEMBRESIA");
            entity.Property(e => e.LimiteCredito)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("LIMITE_CREDITO");
            entity.Property(e => e.MenAdeudoPermitido)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("MEN_ADEUDO_PERMITIDO");
            entity.Property(e => e.MesImporteAnual)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MES_IMPORTE_ANUAL");
            entity.Property(e => e.MontoAnuMembresia)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO_ANU_MEMBRESIA");
            entity.Property(e => e.MontoFavor)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO_FAVOR");
            entity.Property(e => e.MontoMenMembresia)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO_MEN_MEMBRESIA");
            entity.Property(e => e.NomTercero)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOM_TERCERO");
            entity.Property(e => e.NumeroAnuMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("NUMERO_ANU_MEMBRESIA");
            entity.Property(e => e.NumeroMenMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("NUMERO_MEN_MEMBRESIA");
            entity.Property(e => e.ObservacionModificacion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_MODIFICACION");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.OtrosAbonosMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OTROS_ABONOS_MEMBRESIA");
            entity.Property(e => e.Poblacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("POBLACION");
            entity.Property(e => e.PoblacionFiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("POBLACION_FISCAL");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RAZON_SOCIAL");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RFC");
            entity.Property(e => e.SaldoCredito)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SALDO_CREDITO");
            entity.Property(e => e.SaldoMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SALDO_MEMBRESIA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TotalAnuMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOTAL_ANU_MEMBRESIA");
            entity.Property(e => e.TotalMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOTAL_MEMBRESIA");
            entity.Property(e => e.TotalMenMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOTAL_MEN_MEMBRESIA");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaTerceros)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_TERCERO_SA_COD_EMPRESA");

            entity.HasOne(d => d.SaCliente).WithMany(p => p.SaTerceros)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodCliente })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_TERCERO_SA_CLIENTE");

            entity.HasOne(d => d.SaCodTipoCompra).WithMany(p => p.SaTerceros)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodTipoCompra })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_TERCERO_SA_COD_TIPO_COMPRA");

            entity.HasOne(d => d.SaCodTipoMantenimiento).WithMany(p => p.SaTerceros)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodTipoMantenimiento })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_TERCERO_SA_COD_TIPO_MANTENIMIENTO");

            entity.HasOne(d => d.SaCodTipoMembresium).WithMany(p => p.SaTerceros)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodTipoMembresia })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_TERCERO_SA_COD_TIPO_MEMBRESIA");
        });

        modelBuilder.Entity<SaTerceroArchivo>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodCliente, e.CodTercero });

            entity.ToTable("SA_TERCERO_ARCHIVO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.AnticipoMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ANTICIPO_MEMBRESIA");
            entity.Property(e => e.Celular)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CELULAR");
            entity.Property(e => e.CodAnuMembresia)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_ANU_MEMBRESIA");
            entity.Property(e => e.CodCredencial)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_CREDENCIAL");
            entity.Property(e => e.CodEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO");
            entity.Property(e => e.CodEstadoCertificado)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_ESTADO_CERTIFICADO");
            entity.Property(e => e.CodMenMembresia)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("COD_MEN_MEMBRESIA");
            entity.Property(e => e.CodTipoCompra)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_COMPRA");
            entity.Property(e => e.CodTipoMantenimiento)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MANTENIMIENTO");
            entity.Property(e => e.CodTipoMembresia)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_TIPO_MEMBRESIA");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.ConsumoConAduedo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CONSUMO_CON_ADUEDO");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CORREO");
            entity.Property(e => e.Cp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CP");
            entity.Property(e => e.CpFiscal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CP_FISCAL");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.DomicioFiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DOMICIO_FISCAL");
            entity.Property(e => e.Extra01)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA01");
            entity.Property(e => e.Extra02)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA02");
            entity.Property(e => e.Extra03)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA03");
            entity.Property(e => e.Extra04)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EXTRA04");
            entity.Property(e => e.FecNacimiento)
                .HasColumnType("datetime")
                .HasColumnName("FEC_NACIMIENTO");
            entity.Property(e => e.FecRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FEC_REGISTRO");
            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MODIFICACION");
            entity.Property(e => e.FinAnuMembresia)
                .HasColumnType("datetime")
                .HasColumnName("FIN_ANU_MEMBRESIA");
            entity.Property(e => e.FinMenMembresia)
                .HasColumnType("datetime")
                .HasColumnName("FIN_MEN_MEMBRESIA");
            entity.Property(e => e.InicioAnuMembresia)
                .HasColumnType("datetime")
                .HasColumnName("INICIO_ANU_MEMBRESIA");
            entity.Property(e => e.InicioMenMembresia)
                .HasColumnType("datetime")
                .HasColumnName("INICIO_MEN_MEMBRESIA");
            entity.Property(e => e.LimiteCredito)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("LIMITE_CREDITO");
            entity.Property(e => e.MenAdeudoPermitido)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("MEN_ADEUDO_PERMITIDO");
            entity.Property(e => e.MesImporteAnual)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MES_IMPORTE_ANUAL");
            entity.Property(e => e.MontoAnuMembresia)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO_ANU_MEMBRESIA");
            entity.Property(e => e.MontoFavor)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MONTO_FAVOR");
            entity.Property(e => e.MontoMenMembresia)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MONTO_MEN_MEMBRESIA");
            entity.Property(e => e.NomTercero)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOM_TERCERO");
            entity.Property(e => e.NumeroAnuMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("NUMERO_ANU_MEMBRESIA");
            entity.Property(e => e.NumeroMenMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("NUMERO_MEN_MEMBRESIA");
            entity.Property(e => e.ObservacionModificacion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBSERVACION_MODIFICACION");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.OtrosAbonosMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OTROS_ABONOS_MEMBRESIA");
            entity.Property(e => e.Poblacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("POBLACION");
            entity.Property(e => e.PoblacionFiscal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("POBLACION_FISCAL");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RAZON_SOCIAL");
            entity.Property(e => e.Rfc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RFC");
            entity.Property(e => e.SaldoCredito)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SALDO_CREDITO");
            entity.Property(e => e.SaldoMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SALDO_MEMBRESIA");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
            entity.Property(e => e.TotalAnuMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOTAL_ANU_MEMBRESIA");
            entity.Property(e => e.TotalMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOTAL_MEMBRESIA");
            entity.Property(e => e.TotalMenMembresia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOTAL_MEN_MEMBRESIA");
        });

        modelBuilder.Entity<SaUsuario>(entity =>
        {
            entity.HasKey(e => new { e.CodEmpresa, e.CodUsuario });

            entity.ToTable("SA_USUARIO");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_USUARIO");
            entity.Property(e => e.ClaUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CLA_USUARIO");
            entity.Property(e => e.CodCaja)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CAJA");
            entity.Property(e => e.CodEstusu)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ESTUSU");
            entity.Property(e => e.CodGrupo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_GRUPO");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_SUCURSAL");
            entity.Property(e => e.DesUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DES_USUARIO");
            entity.Property(e => e.NomUsuario)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("NOM_USUARIO");

            entity.HasOne(d => d.CodEmpresaNavigation).WithMany(p => p.SaUsuarios)
                .HasForeignKey(d => d.CodEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_USUARIO_SA_COD_EMPRESA");

            entity.HasOne(d => d.SaCodEstusu).WithMany(p => p.SaUsuarios)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodEstusu })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_USUARIO_SA_COD_ESTUSU");

            entity.HasOne(d => d.SaCodGrupoUsu).WithMany(p => p.SaUsuarios)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodGrupo })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_USUARIO_SA_COD_GRUPO_USU");

            entity.HasOne(d => d.SaCodSucursal).WithMany(p => p.SaUsuarios)
                .HasForeignKey(d => new { d.CodEmpresa, d.CodSucursal })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SA_USUARIO_SA_COD_SUCURSAL");
        });

        modelBuilder.Entity<SaVerificarTer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_VERIFICAR_TER");

            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
        });

        modelBuilder.Entity<SaVisitum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SA_VISITA");

            entity.Property(e => e.CodAcceso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("COD_ACCESO");
            entity.Property(e => e.CodCliente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("COD_CLIENTE");
            entity.Property(e => e.CodDependiente)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("COD_DEPENDIENTE");
            entity.Property(e => e.CodEmpresa)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("COD_EMPRESA");
            entity.Property(e => e.CodTercero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COD_TERCERO");
            entity.Property(e => e.FecVisita)
                .HasColumnType("datetime")
                .HasColumnName("FEC_VISITA");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
