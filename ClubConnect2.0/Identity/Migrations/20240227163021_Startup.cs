using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubConnect2._0.Identity.Migrations
{
    /// <inheritdoc />
    public partial class Startup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APPAUTORIZACIOND",
                columns: table => new
                {
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    COD_AUTORIZACION = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPAUTORIZACIOND", x => new { x.COD_TERCERO, x.COD_DEPENDIENTE });
                });

            migrationBuilder.CreateTable(
                name: "APPAUTORIZACIONT",
                columns: table => new
                {
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_AUTORIZACION = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPAUTORIZACIONT", x => x.COD_TERCERO);
                });

            migrationBuilder.CreateTable(
                name: "APPUSUARIO",
                columns: table => new
                {
                    COD_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    NOM_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CLA_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_ESTUSU = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APPUSUARIO", x => x.COD_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SA_BIOMETRIA_COPIA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    BIOMETRIA = table.Column<byte[]>(type: "image", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_BITACORA_GENERACION",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PERIODO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FEC_INICIO = table.Column<DateTime>(type: "datetime", nullable: true),
                    FEC_FIN = table.Column<DateTime>(type: "datetime", nullable: true),
                    USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FEC_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: true),
                    USU_MODIFICACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FEC_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_BITACORA_IMPORTE_TERCERO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_CARGOS_TRANS_MEMBRESIA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_PLA_MEM = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_TIPO_MEMBRESIA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    TIPO_TRANSACCION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MONTO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_ACCESO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_ACCESO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    DES_ACCESO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_ACCESO", x => new { x.COD_EMPRESA, x.COD_ACCESO });
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_BITACORA_MEMBRESIA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_BITACORA_MEMBRESIA = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_TRANSACCION_MEMBRESIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: true),
                    COD_SUCURSAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_USUARIO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    COD_TERCERO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_CAJA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    DES_CAJA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_CAJA", x => new { x.COD_EMPRESA, x.COD_CAJA });
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_EMPRESA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_EMPRESA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NOMSER1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NOMSER2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    NOMSER3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BASSER1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BASSER2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BASSER3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    USUSER1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    USUSER2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    USUSER3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PASSER1 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PASSER2 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PASSER3 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    VERSIS = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_EMPRESA", x => x.COD_EMPRESA);
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_ESTCER",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    DES_ESTADO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_REG",
                columns: table => new
                {
                    COD_REG = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_SUCURSAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_REG = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_REG", x => x.COD_REG);
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_RELACION_MEMBRESIA_COMPRA_MANTENIMIENTO",
                columns: table => new
                {
                    COD_RELACION = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_TIPO_MEMBRESIA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_TIPO_COMPRA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_TIPO_MANTENIMIENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_TRANS_MEMBRESIA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_TRANS = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DESCRIPCION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_TRANSACCION_BITACORA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_TRANSACCION_MEMBRESIA = table.Column<decimal>(type: "numeric(5,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DES_TRANSACCION_MEMBRESIA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_TRANSACCION_MEMBRESIA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_BITACORA_MEMBRESIA = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_TRANSACCION_MEMBRESIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: true),
                    COD_SUCURSAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_CONSUMO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CONSUMO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    SERIE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FOLIO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    MONTO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: true),
                    COD_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COD_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    COD_CAJA_VEN = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    COD_CAJA_DETALLE_VEN = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    COD_VENTA = table.Column<decimal>(type: "numeric(10,0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_CONSUMO", x => new { x.COD_EMPRESA, x.COD_CONSUMO });
                });

            migrationBuilder.CreateTable(
                name: "SA_DES_DOCUMENTO_DIGITALIZADO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO_DOCUMENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    DES_TIPO_DOCUMENTO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_DETALLE_PAGO_MIXTO",
                columns: table => new
                {
                    IdMixto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodMovimiento = table.Column<int>(type: "int", nullable: true),
                    MontoTotal = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Efectivo = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Banco = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Cheque = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Tarjeta = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    Deposito = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    UsuarioCreacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime", nullable: true),
                    UsuarioActualizacion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_DOCUMENTO_DIGITALIZADO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_TIPO_DOCUMENTO = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    FRENTE = table.Column<byte[]>(type: "image", nullable: true),
                    REVERSO = table.Column<byte[]>(type: "image", nullable: true),
                    FECHA_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_USUARIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_SUCURSAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_EXCEPCIONES_IMPORTES",
                columns: table => new
                {
                    COD_EXCEPCION = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PARAMETRO = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    COD_IMPORTE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_TERCERO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    FEC_INI = table.Column<DateTime>(type: "datetime", nullable: true),
                    FEC_FIN = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SA_EXCEPCIONES_I__228D5B61", x => x.COD_EXCEPCION);
                });

            migrationBuilder.CreateTable(
                name: "SA_IMPORTE_ARCHIVO_TERCERO",
                columns: table => new
                {
                    COD_IMPORTE_ARCHIVO = table.Column<int>(type: "int", nullable: false),
                    FEC_ARCHIVO = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_PERIODO = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    MONTO_ORIGINAL = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MONTO = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    FEC_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    CARGO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ABONO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DESCUENTO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    BONIFICACION = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SALDO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    NUM_PERIODO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    TOT_PERIODOS = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    COD_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    RAZON = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_IMPORTE_PREDETERMINADO_IMPORTE_PRUEBAS",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_DETALLE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    MONTO = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    TOTAL = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FEC_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FEC_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_IMPORTE_PREDETERMINADO_IMPORTE_pruebas", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_DETALLE, x.COD_IMPORTE });
                });

            migrationBuilder.CreateTable(
                name: "SA_IMPORTE_PREDETERMINADO_TERCERO_PRUEBAS",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_DETALLE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FEC_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FEC_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_IMPORTE_PREDETERMINADO_TERCERO_PRUEBAS", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_DETALLE, x.COD_DEPENDIENTE });
                });

            migrationBuilder.CreateTable(
                name: "SA_IMPORTE_TERCERO_PRUEBAS",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_PERIODO = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    MONTO_ORIGINAL = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MONTO = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    FEC_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    CARGO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ABONO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DESCUENTO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    BONIFICACION = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SALDO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    NUM_PERIODO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    TOT_PERIODOS = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    COD_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_IMPORTE_TERCERO_PRUEBAS_1", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_PERIODO, x.COD_IMPORTE });
                });

            migrationBuilder.CreateTable(
                name: "SA_MOVIMIENTOS_DETA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_MOVIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    COD_TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_DETALLE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    COD_SUBTIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO_TRANSACCION = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    COD_TRANSACCION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_PERIODO = table.Column<DateTime>(type: "datetime", nullable: true),
                    TOT_PERIODOS = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    COD_FACTURA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    COD_RECIBO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    COD_REFERENCIA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MON_ORIGINAL = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MON_ADEUDO_ANTERIOR = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MON_ADEUDO_ANTERIOR_SIN_RECARGO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    RECARGO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MON_BONIFICACION = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MON_DESCUENTO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MON_SUBTOTAL_ADEUDO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    POR_IVA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    MON_IVA_ADEUDO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MON_TOTAL_ADEUDO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    A_FAVOR_APLICADO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    COBRADO_APLICADO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_MOVIMIENTOS_DETA", x => new { x.COD_EMPRESA, x.COD_MOVIMIENTO, x.COD_TIPO, x.COD_DETALLE });
                });

            migrationBuilder.CreateTable(
                name: "SA_PARAMETROS_DE_ACCION",
                columns: table => new
                {
                    ACCION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    PARAMETRO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    VALOR = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: false),
                    COMMENTARIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_USUARIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_PLAZO_PAGO_MEMBRESIA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_PLA_MEM = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_TIPO_MEMBRESIA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    PERIODO_PAGO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    MONTO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    MENSUALIDAD = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    TIPO_ADQUISICION = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    COD_PER_PAG = table.Column<decimal>(type: "numeric(5,0)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_TERCERO_ARCHIVO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NOM_TERCERO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    COD_TIPO_MEMBRESIA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DOMICILIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    POBLACION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TELEFONO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CELULAR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CORREO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    RAZON_SOCIAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    RFC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DOMICIO_FISCAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    POBLACION_FISCAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CP_FISCAL = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA03 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA04 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FEC_NACIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FEC_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_CREDENCIAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_TIPO_MANTENIMIENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO_COMPRA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TOTAL_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ANTICIPO_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    OTROS_ABONOS_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    NUMERO_MEN_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    NUMERO_ANU_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    MONTO_MEN_MEMBRESIA = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    MONTO_ANU_MEMBRESIA = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    TOTAL_MEN_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    TOTAL_ANU_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    INICIO_MEN_MEMBRESIA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FIN_MEN_MEMBRESIA = table.Column<DateTime>(type: "datetime", nullable: false),
                    INICIO_ANU_MEMBRESIA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FIN_ANU_MEMBRESIA = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    OBSERVACION_MODIFICACION = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    COD_USUARIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MONTO_FAVOR = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    SALDO_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    COD_MEN_MEMBRESIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    COD_ANU_MEMBRESIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    OBSERVACIONES = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    LIMITE_CREDITO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    SALDO_CREDITO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    COD_ESTADO_CERTIFICADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    MEN_ADEUDO_PERMITIDO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    CONSUMO_CON_ADUEDO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    MES_IMPORTE_ANUAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_TERCERO_ARCHIVO", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO });
                });

            migrationBuilder.CreateTable(
                name: "SA_VERIFICAR_TER",
                columns: table => new
                {
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: true),
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SA_VISITA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    FEC_VISITA = table.Column<DateTime>(type: "datetime", nullable: true),
                    COD_ACCESO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_BANCO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_BANCO = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    DES_BANCO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_BANCO", x => new { x.COD_EMPRESA, x.COD_BANCO });
                    table.ForeignKey(
                        name: "FK_SA_COD_BANCO_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_CALCULO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_SUBTIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CALCULO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_CALCULO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_ORIGEN = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    COD_PERIODO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_ETIQUETA = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_CALCULO", x => new { x.COD_EMPRESA, x.COD_TIPO, x.COD_SUBTIPO, x.COD_CALCULO });
                    table.ForeignKey(
                        name: "FK_SA_COD_CALCULO_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_COBRO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_COBRO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_COBRO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_COBRO", x => new { x.COD_EMPRESA, x.COD_COBRO });
                    table.ForeignKey(
                        name: "FK_SA_COD_COBRO_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_ESTUSU",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_ESTUSU = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    DES_ESTUSU = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_ESTUSU", x => new { x.COD_EMPRESA, x.COD_ESTUSU });
                    table.ForeignKey(
                        name: "FK_SA_COD_ESTUSU_SA_COD_EMPRESA1",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_GRUPO_PAR",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_GRUPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_GRUPO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_GRUPO_PAR", x => new { x.COD_EMPRESA, x.COD_GRUPO });
                    table.ForeignKey(
                        name: "FK_SA_COD_GRUPO_PAR_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_GRUPO_SER",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_GRUPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_GRUPO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_GRUPO_SER", x => new { x.COD_EMPRESA, x.COD_GRUPO });
                    table.ForeignKey(
                        name: "FK_SA_COD_GRUPO_SER_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_GRUPO_USU",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_GRUPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_GRUPO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_GRUPO_USU", x => new { x.COD_EMPRESA, x.COD_GRUPO });
                    table.ForeignKey(
                        name: "FK_SA_COD_GRUPO_USU_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_OPCION",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_OPCION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    DES_OPCION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_OPCION", x => new { x.COD_EMPRESA, x.COD_OPCION });
                    table.ForeignKey(
                        name: "FK_SA_COD_OPCION_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_SUCURSAL",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_SUCURSAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_SUCURSAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_SUCURSAL", x => new { x.COD_EMPRESA, x.COD_SUCURSAL });
                    table.ForeignKey(
                        name: "FK_SA_COD_SUCURSAL_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_TIPO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_TIPO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_TIPO", x => new { x.COD_EMPRESA, x.COD_TIPO });
                    table.ForeignKey(
                        name: "FK_SA_COD_TIPO_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_TIPO_COMPRA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO_COMPRA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_TIPO_COMPRA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_TIPO_COMRA", x => new { x.COD_EMPRESA, x.COD_TIPO_COMPRA });
                    table.ForeignKey(
                        name: "FK_SA_COD_TIPO_COMPRA_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_TIPO_MANTENIMIENTO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO_MANTENIMIENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_TIPO_MANTENIMIENTO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    MONTO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_TIPO_MANTENIMIENTO", x => new { x.COD_EMPRESA, x.COD_TIPO_MANTENIMIENTO });
                    table.ForeignKey(
                        name: "FK_SA_COD_TIPO_MANTENIMIENTO_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_TIPO_MEMBRESIA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO_MEMBRESIA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_TIPO_MEMBRESIA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    MONTO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_TIPO_MEMBRESIA", x => new { x.COD_EMPRESA, x.COD_TIPO_MEMBRESIA });
                    table.ForeignKey(
                        name: "FK_SA_COD_TIPO_MEMBRESIA_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_TIPO_TRANSACCION",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO_TRANSACCION = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    DES_TIPO_TRANSACCION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_TIPO_TRANSACCION", x => new { x.COD_EMPRESA, x.COD_TIPO_TRANSACCION });
                    table.ForeignKey(
                        name: "FK_SA_COD_TIPO_TRANSACCION_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_DOCUMENTO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO_DOCUMENTO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    COD_SERIE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    COD_MOVIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    FEC_DOCUMENTO = table.Column<DateTime>(type: "datetime", nullable: true),
                    MON_DOCUMENTO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    COD_SISTEMA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    COD_TIPO_MOVIMIENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_DOCUMENTO", x => new { x.COD_EMPRESA, x.COD_TIPO_DOCUMENTO, x.COD_SERIE, x.COD_DOCUMENTO });
                    table.ForeignKey(
                        name: "FK_SA_DOCUMENTO_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "SA_CLIENTE",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOM_CLIENTE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    NUM_CUENTA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_PRODUCTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TERCERO01 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    TERCERO02 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_BUSCA = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    COD_COBRO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    MONTO = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    COD_OPERACION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    LON_EXTRA01 = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    LON_EXTRA02 = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    COD_DESHABILITAR_IMP = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_CLIENTE", x => new { x.COD_EMPRESA, x.COD_CLIENTE });
                    table.ForeignKey(
                        name: "FK_SA_CLIENTE_SA_COD_COBRO",
                        columns: x => new { x.COD_EMPRESA, x.COD_COBRO },
                        principalTable: "SA_COD_COBRO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_COBRO" });
                    table.ForeignKey(
                        name: "FK_SA_CLIENTE_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                });

            migrationBuilder.CreateTable(
                name: "ETIPODOCUMENTO",
                columns: table => new
                {
                    COD_TIPODOCUMENTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    NOM_TIPODOCUMENTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    COD_ESTUSU = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ETIPODOCUMENTO", x => x.COD_TIPODOCUMENTO);
                    table.ForeignKey(
                        name: "FK_ETIPODOCUMENTO_SA_COD_ESTUSU",
                        columns: x => new { x.COD_EMPRESA, x.COD_ESTUSU },
                        principalTable: "SA_COD_ESTUSU",
                        principalColumns: new[] { "COD_EMPRESA", "COD_ESTUSU" });
                });

            migrationBuilder.CreateTable(
                name: "SA_PARAMETRO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_GRUPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_SUBGRUPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_PARAMETRO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    DES_PARAMETRO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    VAL_PARAMETRO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_PARAMETRO", x => new { x.COD_EMPRESA, x.COD_GRUPO, x.COD_SUBGRUPO, x.COD_PARAMETRO });
                    table.ForeignKey(
                        name: "FK_SA_PARAMETRO_SA_COD_GRUPO_PAR",
                        columns: x => new { x.COD_EMPRESA, x.COD_GRUPO },
                        principalTable: "SA_COD_GRUPO_PAR",
                        principalColumns: new[] { "COD_EMPRESA", "COD_GRUPO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_SERIE",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_GRUPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_SUBGRUPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_SERIE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    DES_SERIE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    NUM_SERIE = table.Column<decimal>(type: "numeric(10,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_SERIE", x => new { x.COD_EMPRESA, x.COD_GRUPO, x.COD_SUBGRUPO, x.COD_SERIE });
                    table.ForeignKey(
                        name: "FK_SA_SERIE_SA_COD_GRUPO_SER",
                        columns: x => new { x.COD_EMPRESA, x.COD_GRUPO },
                        principalTable: "SA_COD_GRUPO_SER",
                        principalColumns: new[] { "COD_EMPRESA", "COD_GRUPO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_SEGURIDAD",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_OPCION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_GRUPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_ACCESO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_SEGURIDAD", x => new { x.COD_EMPRESA, x.COD_OPCION, x.COD_GRUPO });
                    table.ForeignKey(
                        name: "FK_SA_SEGURIDAD_SA_COD_ACCESO",
                        columns: x => new { x.COD_EMPRESA, x.COD_ACCESO },
                        principalTable: "SA_COD_ACCESO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_ACCESO" });
                    table.ForeignKey(
                        name: "FK_SA_SEGURIDAD_SA_COD_GRUPO_USU",
                        columns: x => new { x.COD_EMPRESA, x.COD_GRUPO },
                        principalTable: "SA_COD_GRUPO_USU",
                        principalColumns: new[] { "COD_EMPRESA", "COD_GRUPO" });
                    table.ForeignKey(
                        name: "FK_SA_SEGURIDAD_SA_COD_OPCION",
                        columns: x => new { x.COD_EMPRESA, x.COD_OPCION },
                        principalTable: "SA_COD_OPCION",
                        principalColumns: new[] { "COD_EMPRESA", "COD_OPCION" });
                });

            migrationBuilder.CreateTable(
                name: "SA_USUARIO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    NOM_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    CLA_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    DES_USUARIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_GRUPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_ESTUSU = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    COD_SUCURSAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CAJA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_USUARIO", x => new { x.COD_EMPRESA, x.COD_USUARIO });
                    table.ForeignKey(
                        name: "FK_SA_USUARIO_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                    table.ForeignKey(
                        name: "FK_SA_USUARIO_SA_COD_ESTUSU",
                        columns: x => new { x.COD_EMPRESA, x.COD_ESTUSU },
                        principalTable: "SA_COD_ESTUSU",
                        principalColumns: new[] { "COD_EMPRESA", "COD_ESTUSU" });
                    table.ForeignKey(
                        name: "FK_SA_USUARIO_SA_COD_GRUPO_USU",
                        columns: x => new { x.COD_EMPRESA, x.COD_GRUPO },
                        principalTable: "SA_COD_GRUPO_USU",
                        principalColumns: new[] { "COD_EMPRESA", "COD_GRUPO" });
                    table.ForeignKey(
                        name: "FK_SA_USUARIO_SA_COD_SUCURSAL",
                        columns: x => new { x.COD_EMPRESA, x.COD_SUCURSAL },
                        principalTable: "SA_COD_SUCURSAL",
                        principalColumns: new[] { "COD_EMPRESA", "COD_SUCURSAL" });
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_SUBTIPO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_SUBTIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_SUBTIPO = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_SUBTIPO", x => new { x.COD_EMPRESA, x.COD_TIPO, x.COD_SUBTIPO });
                    table.ForeignKey(
                        name: "FK_SA_COD_SUBTIPO_SA_COD_TIPO",
                        columns: x => new { x.COD_EMPRESA, x.COD_TIPO },
                        principalTable: "SA_COD_TIPO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_TIPO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_TRANSACCION",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TRANSACCION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DES_TRANSACCION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    COD_TIPO_TRANSACCION = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_TRANSACCION", x => new { x.COD_EMPRESA, x.COD_TRANSACCION });
                    table.ForeignKey(
                        name: "FK_SA_COD_TRANSACCION_SA_COD_EMPRESA1",
                        columns: x => new { x.COD_EMPRESA, x.COD_TIPO_TRANSACCION },
                        principalTable: "SA_COD_TIPO_TRANSACCION",
                        principalColumns: new[] { "COD_EMPRESA", "COD_TIPO_TRANSACCION" });
                });

            migrationBuilder.CreateTable(
                name: "SA_DESTINATARIO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_DESTINATARIO = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    NOM_DESTINATARIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    COR_DESTINATARIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_DESTINATARIO", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_DESTINATARIO });
                    table.ForeignKey(
                        name: "FK_SA_DESTINATARIO_SA_CLIENTE",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE },
                        principalTable: "SA_CLIENTE",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE" });
                });

            migrationBuilder.CreateTable(
                name: "SA_TERCERO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    NOM_TERCERO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    COD_TIPO_MEMBRESIA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    DOMICILIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    POBLACION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CP = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TELEFONO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CELULAR = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    CORREO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    RAZON_SOCIAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    RFC = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    DOMICIO_FISCAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    POBLACION_FISCAL = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CP_FISCAL = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA03 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA04 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FEC_NACIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FEC_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_CREDENCIAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_TIPO_MANTENIMIENTO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_TIPO_COMPRA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    TOTAL_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ANTICIPO_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    OTROS_ABONOS_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    NUMERO_MEN_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    NUMERO_ANU_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    MONTO_MEN_MEMBRESIA = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    MONTO_ANU_MEMBRESIA = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    TOTAL_MEN_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    TOTAL_ANU_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    INICIO_MEN_MEMBRESIA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FIN_MEN_MEMBRESIA = table.Column<DateTime>(type: "datetime", nullable: false),
                    INICIO_ANU_MEMBRESIA = table.Column<DateTime>(type: "datetime", nullable: false),
                    FIN_ANU_MEMBRESIA = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    OBSERVACION_MODIFICACION = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    COD_USUARIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MONTO_FAVOR = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    SALDO_MEMBRESIA = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    COD_MEN_MEMBRESIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    COD_ANU_MEMBRESIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    OBSERVACIONES = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    LIMITE_CREDITO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    SALDO_CREDITO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    COD_ESTADO_CERTIFICADO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    MEN_ADEUDO_PERMITIDO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    CONSUMO_CON_ADUEDO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    MES_IMPORTE_ANUAL = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_TERCERO", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO });
                    table.ForeignKey(
                        name: "FK_SA_TERCERO_SA_CLIENTE",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE },
                        principalTable: "SA_CLIENTE",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE" });
                    table.ForeignKey(
                        name: "FK_SA_TERCERO_SA_COD_EMPRESA",
                        column: x => x.COD_EMPRESA,
                        principalTable: "SA_COD_EMPRESA",
                        principalColumn: "COD_EMPRESA");
                    table.ForeignKey(
                        name: "FK_SA_TERCERO_SA_COD_TIPO_COMPRA",
                        columns: x => new { x.COD_EMPRESA, x.COD_TIPO_COMPRA },
                        principalTable: "SA_COD_TIPO_COMPRA",
                        principalColumns: new[] { "COD_EMPRESA", "COD_TIPO_COMPRA" });
                    table.ForeignKey(
                        name: "FK_SA_TERCERO_SA_COD_TIPO_MANTENIMIENTO",
                        columns: x => new { x.COD_EMPRESA, x.COD_TIPO_MANTENIMIENTO },
                        principalTable: "SA_COD_TIPO_MANTENIMIENTO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_TIPO_MANTENIMIENTO" });
                    table.ForeignKey(
                        name: "FK_SA_TERCERO_SA_COD_TIPO_MEMBRESIA",
                        columns: x => new { x.COD_EMPRESA, x.COD_TIPO_MEMBRESIA },
                        principalTable: "SA_COD_TIPO_MEMBRESIA",
                        principalColumns: new[] { "COD_EMPRESA", "COD_TIPO_MEMBRESIA" });
                });

            migrationBuilder.CreateTable(
                name: "SA_IMPORTE",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    DES_IMPORTE = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COD_TIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_SUBTIPO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    FEC_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FEC_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    MONTO = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_CONCEPTO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    POR_IVA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    TIPO_COBRO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_IMPORTE", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_IMPORTE });
                    table.ForeignKey(
                        name: "FK_SA_IMPORTE_SA_CLIENTE",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE },
                        principalTable: "SA_CLIENTE",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SA_IMPORTE_SA_COD_SUBTIPO",
                        columns: x => new { x.COD_EMPRESA, x.COD_TIPO, x.COD_SUBTIPO },
                        principalTable: "SA_COD_SUBTIPO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_TIPO", "COD_SUBTIPO" });
                });

            migrationBuilder.CreateTable(
                name: "Expedientetercero",
                columns: table => new
                {
                    COD_ARCHIVO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_TIPODOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    NOM_DOCUMENTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOCUMENTO = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    EXT_DOCUMENTO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: true),
                    COD_ESTUSU = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expedientetercero", x => new { x.COD_ARCHIVO, x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_TIPODOCUMENTO });
                    table.ForeignKey(
                        name: "FK_Expedientetercero_ETIPODOCUMENTO",
                        column: x => x.COD_TIPODOCUMENTO,
                        principalTable: "ETIPODOCUMENTO",
                        principalColumn: "COD_TIPODOCUMENTO");
                    table.ForeignKey(
                        name: "FK_Expedientetercero_SA_COD_ESTUSU",
                        columns: x => new { x.COD_EMPRESA, x.COD_ESTUSU },
                        principalTable: "SA_COD_ESTUSU",
                        principalColumns: new[] { "COD_EMPRESA", "COD_ESTUSU" });
                    table.ForeignKey(
                        name: "FK_Expedientetercero_SA_TERCERO",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO },
                        principalTable: "SA_TERCERO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_BIOMETRIA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    BIOMETRIA = table.Column<string>(type: "varchar(4000)", unicode: false, maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_BIOMETRIA", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_DEPENDIENTE });
                    table.ForeignKey(
                        name: "FK_SA_BIOMETRIA_SA_TERCERO",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO },
                        principalTable: "SA_TERCERO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_DEPENDIENTE",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    NOMBRE = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FEC_NACIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_CREDENCIAL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    LIMITE_CREDITO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    SALDO_CREDITO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_DEPENDIENTE", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_DEPENDIENTE });
                    table.ForeignKey(
                        name: "FK_SA_DEPENDIENTE_SA_TERCERO",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO },
                        principalTable: "SA_TERCERO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_FOTOGRAFIA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    FOTOGRAFIA = table.Column<byte[]>(type: "image", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_FOTOGRAFIA", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_DEPENDIENTE });
                    table.ForeignKey(
                        name: "FK_SA_FOTOGRAFIA_SA_TERCERO",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO },
                        principalTable: "SA_TERCERO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_IMPORTE_PREDETERMINADO_TERCERO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_DETALLE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FEC_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FEC_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_IMPORTE_PREDETERMINADO_TERCERO", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_DETALLE, x.COD_DEPENDIENTE });
                    table.ForeignKey(
                        name: "FK_SA_IMPORTE_PREDETERMINADO_TERCERO_SA_TERCERO1",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO },
                        principalTable: "SA_TERCERO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_MOVIMIENTOS_ENCA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_MOVIMIENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    FEC_MOVIMIENTO = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_TIPO_TRANSACCION = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    COD_TRANSACCION = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    COD_SUCURSAL = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    FEC_REAL = table.Column<DateTime>(type: "datetime", nullable: true),
                    COD_COMROBANTE = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    COD_INSTRUMENTO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    COD_BANCO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    REFERENCIA = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    SERIE_RECIBO = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_RECIBO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    SERIE_FACTURA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_FACTURA = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    COD_TIPO_DOCUMENTO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    COD_SERIE = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    COD_DOCUMENTO = table.Column<decimal>(type: "numeric(10,0)", nullable: true),
                    OBSERVACION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    USUARIO_CANCELACION = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    FECHA_CANCELACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    MON_ADEUDO_ANTERIOR = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_BONIFICACION = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_DESCUENTO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_SUBTOTAL_ADEUDO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_IVA_ADEUDO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_TOTAL_ADEUDO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_SALDO_FAVOR_ANTERIOR = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_COBRAR = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_DISPONIBLE = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_APLICAR = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_SALDO_FAVOR = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_SUBTOTAL_APLICADO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_IVA_APLICADO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    MON_TOTAL_APLICADO = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    TOTAL_ABONO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    COD_MEN_MEMBRESIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    COD_MEN_MEMBRESIA_ANT = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    COD_ANU_MEMBRESIA = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    COD_ANU_MEMBRESIA_ANT = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    DES_MEN_MEMBRESIA = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    DES_ANU_MEMBRESIA = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    FEC_FACTURACION = table.Column<DateTime>(type: "datetime", nullable: true),
                    COB_CARGO_TARJETA = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_MOVIMIENTOS_ENCA", x => new { x.COD_EMPRESA, x.COD_MOVIMIENTO });
                    table.ForeignKey(
                        name: "FK_SA_MOVIMIENTOS_ENCA_SA_COD_BANCO",
                        columns: x => new { x.COD_EMPRESA, x.COD_BANCO },
                        principalTable: "SA_COD_BANCO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_BANCO" });
                    table.ForeignKey(
                        name: "FK_SA_MOVIMIENTOS_ENCA_SA_COD_TRANSACCION",
                        columns: x => new { x.COD_EMPRESA, x.COD_TRANSACCION },
                        principalTable: "SA_COD_TRANSACCION",
                        principalColumns: new[] { "COD_EMPRESA", "COD_TRANSACCION" });
                    table.ForeignKey(
                        name: "FK_SA_MOVIMIENTOS_ENCA_SA_TERCERO",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO },
                        principalTable: "SA_TERCERO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_COD_EXTRA01",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_COD_EXTRA01", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_IMPORTE, x.EXTRA01 });
                    table.ForeignKey(
                        name: "FK_SA_COD_EXTRA01_SA_IMPORTE",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_IMPORTE },
                        principalTable: "SA_IMPORTE",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_IMPORTE" });
                });

            migrationBuilder.CreateTable(
                name: "SA_IMPORTE_BONIFICACION",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    MONTO = table.Column<decimal>(type: "numeric(18,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_IMPORTE_BONIFICACION", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_IMPORTE });
                    table.ForeignKey(
                        name: "FK_SA_IMPORTE_BONIFICACION_SA_IMPORTE",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_IMPORTE },
                        principalTable: "SA_IMPORTE",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_IMPORTE" });
                    table.ForeignKey(
                        name: "FK_SA_IMPORTE_BONIFICACION_SA_TERCERO",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO },
                        principalTable: "SA_TERCERO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_IMPORTE_PREDETERMINADO_IMPORTE",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_DETALLE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    MONTO = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    CANTIDAD = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    TOTAL = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    FEC_INICIO = table.Column<DateTime>(type: "datetime", nullable: false),
                    FEC_FIN = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_IMPORTE_PREDETERMINADO_IMPORTE", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_DETALLE, x.COD_IMPORTE });
                    table.ForeignKey(
                        name: "FK_SA_IMPORTE_PREDETERMINADO_IMPORTE_SA_IMPORTE",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_IMPORTE },
                        principalTable: "SA_IMPORTE",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_IMPORTE" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SA_IMPORTE_PREDETERMINADO_IMPORTE_SA_TERCERO",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO },
                        principalTable: "SA_TERCERO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_IMPORTE_TERCERO",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_PERIODO = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    MONTO_ORIGINAL = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MONTO = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    FEC_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    CARGO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ABONO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DESCUENTO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    BONIFICACION = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SALDO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    NUM_PERIODO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    TOT_PERIODOS = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    COD_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_IMPORTE_TERCERO_1", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_PERIODO, x.COD_IMPORTE });
                    table.ForeignKey(
                        name: "FK_SA_IMPORTE_TERCERO_SA_IMPORTE1",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_IMPORTE },
                        principalTable: "SA_IMPORTE",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_IMPORTE" });
                    table.ForeignKey(
                        name: "FK_SA_IMPORTE_TERCERO_SA_TERCERO2",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO },
                        principalTable: "SA_TERCERO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_IMPORTE_TERCERO_BITACORA",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_PERIODO = table.Column<DateTime>(type: "datetime", nullable: false),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    MONTO_ORIGINAL = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    MONTO = table.Column<decimal>(type: "numeric(18,4)", nullable: false),
                    FEC_REGISTRO = table.Column<DateTime>(type: "datetime", nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    EXTRA02 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    COD_ESTADO = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    CARGO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    ABONO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    DESCUENTO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    BONIFICACION = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    SALDO = table.Column<decimal>(type: "numeric(18,4)", nullable: true),
                    NUM_PERIODO = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    TOT_PERIODOS = table.Column<decimal>(type: "numeric(5,0)", nullable: true),
                    COD_USUARIO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_IMPORTE_TERCERO_BITACORA1", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_PERIODO, x.COD_IMPORTE });
                    table.ForeignKey(
                        name: "FK_SA_IMPORTE_TERCERO_BITACORA_SA_IMPORTE1",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_IMPORTE },
                        principalTable: "SA_IMPORTE",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_IMPORTE" });
                    table.ForeignKey(
                        name: "FK_SA_IMPORTE_TERCERO_BITACORA_SA_TERCERO2",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO },
                        principalTable: "SA_TERCERO",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });
                });

            migrationBuilder.CreateTable(
                name: "SA_LUGARES",
                columns: table => new
                {
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_IMPORTE = table.Column<decimal>(type: "numeric(5,0)", nullable: false),
                    EXTRA01 = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA_LUGARES", x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_IMPORTE, x.EXTRA01 });
                    table.ForeignKey(
                        name: "FK_SA_LUGARES_SA_IMPORTE1",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_IMPORTE },
                        principalTable: "SA_IMPORTE",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_IMPORTE" });
                });

            migrationBuilder.CreateTable(
                name: "Expediente",
                columns: table => new
                {
                    COD_ARCHIVO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    COD_EMPRESA = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    COD_CLIENTE = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    COD_TERCERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    COD_DEPENDIENTE = table.Column<decimal>(type: "numeric(10,0)", nullable: false),
                    COD_TIPODOCUMENTO = table.Column<int>(type: "int", nullable: false),
                    NOM_DOCUMENTO = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOCUMENTO = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    EXT_DOCUMENTO = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: true),
                    COD_ESTUSU = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expediente", x => new { x.COD_ARCHIVO, x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_DEPENDIENTE, x.COD_TIPODOCUMENTO });
                    table.ForeignKey(
                        name: "FK_Expediente_ETipoDocumento",
                        column: x => x.COD_TIPODOCUMENTO,
                        principalTable: "ETIPODOCUMENTO",
                        principalColumn: "COD_TIPODOCUMENTO");
                    table.ForeignKey(
                        name: "FK_Expediente_SA_COD_ESTUSU",
                        columns: x => new { x.COD_EMPRESA, x.COD_ESTUSU },
                        principalTable: "SA_COD_ESTUSU",
                        principalColumns: new[] { "COD_EMPRESA", "COD_ESTUSU" });
                    table.ForeignKey(
                        name: "FK_Expediente_SA_DEPENDIENTE",
                        columns: x => new { x.COD_EMPRESA, x.COD_CLIENTE, x.COD_TERCERO, x.COD_DEPENDIENTE },
                        principalTable: "SA_DEPENDIENTE",
                        principalColumns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO", "COD_DEPENDIENTE" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ETIPODOCUMENTO_COD_EMPRESA_COD_ESTUSU",
                table: "ETIPODOCUMENTO",
                columns: new[] { "COD_EMPRESA", "COD_ESTUSU" });

            migrationBuilder.CreateIndex(
                name: "IX_Expediente_COD_EMPRESA_COD_CLIENTE_COD_TERCERO_COD_DEPENDIENTE",
                table: "Expediente",
                columns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO", "COD_DEPENDIENTE" });

            migrationBuilder.CreateIndex(
                name: "IX_Expediente_COD_EMPRESA_COD_ESTUSU",
                table: "Expediente",
                columns: new[] { "COD_EMPRESA", "COD_ESTUSU" });

            migrationBuilder.CreateIndex(
                name: "IX_Expediente_COD_TIPODOCUMENTO",
                table: "Expediente",
                column: "COD_TIPODOCUMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_Expedientetercero_COD_EMPRESA_COD_CLIENTE_COD_TERCERO",
                table: "Expedientetercero",
                columns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });

            migrationBuilder.CreateIndex(
                name: "IX_Expedientetercero_COD_EMPRESA_COD_ESTUSU",
                table: "Expedientetercero",
                columns: new[] { "COD_EMPRESA", "COD_ESTUSU" });

            migrationBuilder.CreateIndex(
                name: "IX_Expedientetercero_COD_TIPODOCUMENTO",
                table: "Expedientetercero",
                column: "COD_TIPODOCUMENTO");

            migrationBuilder.CreateIndex(
                name: "IX_SA_CLIENTE_COD_EMPRESA_COD_COBRO",
                table: "SA_CLIENTE",
                columns: new[] { "COD_EMPRESA", "COD_COBRO" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_COD_TRANSACCION_COD_EMPRESA_COD_TIPO_TRANSACCION",
                table: "SA_COD_TRANSACCION",
                columns: new[] { "COD_EMPRESA", "COD_TIPO_TRANSACCION" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_IMPORTE_COD_EMPRESA_COD_TIPO_COD_SUBTIPO",
                table: "SA_IMPORTE",
                columns: new[] { "COD_EMPRESA", "COD_TIPO", "COD_SUBTIPO" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_IMPORTE_BONIFICACION_COD_EMPRESA_COD_CLIENTE_COD_IMPORTE",
                table: "SA_IMPORTE_BONIFICACION",
                columns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_IMPORTE" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_IMPORTE_PREDETERMINADO_IMPORTE_COD_EMPRESA_COD_CLIENTE_COD_IMPORTE",
                table: "SA_IMPORTE_PREDETERMINADO_IMPORTE",
                columns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_IMPORTE" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_IMPORTE_TERCERO_COD_EMPRESA_COD_CLIENTE_COD_IMPORTE",
                table: "SA_IMPORTE_TERCERO",
                columns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_IMPORTE" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_IMPORTE_TERCERO_BITACORA_COD_EMPRESA_COD_CLIENTE_COD_IMPORTE",
                table: "SA_IMPORTE_TERCERO_BITACORA",
                columns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_IMPORTE" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_MOVIMIENTOS_ENCA_COD_EMPRESA_COD_BANCO",
                table: "SA_MOVIMIENTOS_ENCA",
                columns: new[] { "COD_EMPRESA", "COD_BANCO" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_MOVIMIENTOS_ENCA_COD_EMPRESA_COD_CLIENTE_COD_TERCERO",
                table: "SA_MOVIMIENTOS_ENCA",
                columns: new[] { "COD_EMPRESA", "COD_CLIENTE", "COD_TERCERO" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_MOVIMIENTOS_ENCA_COD_EMPRESA_COD_TRANSACCION",
                table: "SA_MOVIMIENTOS_ENCA",
                columns: new[] { "COD_EMPRESA", "COD_TRANSACCION" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_SEGURIDAD_COD_EMPRESA_COD_ACCESO",
                table: "SA_SEGURIDAD",
                columns: new[] { "COD_EMPRESA", "COD_ACCESO" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_SEGURIDAD_COD_EMPRESA_COD_GRUPO",
                table: "SA_SEGURIDAD",
                columns: new[] { "COD_EMPRESA", "COD_GRUPO" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_TERCERO_COD_EMPRESA_COD_TIPO_COMPRA",
                table: "SA_TERCERO",
                columns: new[] { "COD_EMPRESA", "COD_TIPO_COMPRA" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_TERCERO_COD_EMPRESA_COD_TIPO_MANTENIMIENTO",
                table: "SA_TERCERO",
                columns: new[] { "COD_EMPRESA", "COD_TIPO_MANTENIMIENTO" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_TERCERO_COD_EMPRESA_COD_TIPO_MEMBRESIA",
                table: "SA_TERCERO",
                columns: new[] { "COD_EMPRESA", "COD_TIPO_MEMBRESIA" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_USUARIO_COD_EMPRESA_COD_ESTUSU",
                table: "SA_USUARIO",
                columns: new[] { "COD_EMPRESA", "COD_ESTUSU" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_USUARIO_COD_EMPRESA_COD_GRUPO",
                table: "SA_USUARIO",
                columns: new[] { "COD_EMPRESA", "COD_GRUPO" });

            migrationBuilder.CreateIndex(
                name: "IX_SA_USUARIO_COD_EMPRESA_COD_SUCURSAL",
                table: "SA_USUARIO",
                columns: new[] { "COD_EMPRESA", "COD_SUCURSAL" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APPAUTORIZACIOND");

            migrationBuilder.DropTable(
                name: "APPAUTORIZACIONT");

            migrationBuilder.DropTable(
                name: "APPUSUARIO");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Expediente");

            migrationBuilder.DropTable(
                name: "Expedientetercero");

            migrationBuilder.DropTable(
                name: "SA_BIOMETRIA");

            migrationBuilder.DropTable(
                name: "SA_BIOMETRIA_COPIA");

            migrationBuilder.DropTable(
                name: "SA_BITACORA_GENERACION");

            migrationBuilder.DropTable(
                name: "SA_BITACORA_IMPORTE_TERCERO");

            migrationBuilder.DropTable(
                name: "SA_CARGOS_TRANS_MEMBRESIA");

            migrationBuilder.DropTable(
                name: "SA_COD_BITACORA_MEMBRESIA");

            migrationBuilder.DropTable(
                name: "SA_COD_CAJA");

            migrationBuilder.DropTable(
                name: "SA_COD_CALCULO");

            migrationBuilder.DropTable(
                name: "SA_COD_ESTCER");

            migrationBuilder.DropTable(
                name: "SA_COD_EXTRA01");

            migrationBuilder.DropTable(
                name: "SA_COD_REG");

            migrationBuilder.DropTable(
                name: "SA_COD_RELACION_MEMBRESIA_COMPRA_MANTENIMIENTO");

            migrationBuilder.DropTable(
                name: "SA_COD_TRANS_MEMBRESIA");

            migrationBuilder.DropTable(
                name: "SA_COD_TRANSACCION_BITACORA");

            migrationBuilder.DropTable(
                name: "SA_COD_TRANSACCION_MEMBRESIA");

            migrationBuilder.DropTable(
                name: "SA_CONSUMO");

            migrationBuilder.DropTable(
                name: "SA_DES_DOCUMENTO_DIGITALIZADO");

            migrationBuilder.DropTable(
                name: "SA_DESTINATARIO");

            migrationBuilder.DropTable(
                name: "SA_DETALLE_PAGO_MIXTO");

            migrationBuilder.DropTable(
                name: "SA_DOCUMENTO");

            migrationBuilder.DropTable(
                name: "SA_DOCUMENTO_DIGITALIZADO");

            migrationBuilder.DropTable(
                name: "SA_EXCEPCIONES_IMPORTES");

            migrationBuilder.DropTable(
                name: "SA_FOTOGRAFIA");

            migrationBuilder.DropTable(
                name: "SA_IMPORTE_ARCHIVO_TERCERO");

            migrationBuilder.DropTable(
                name: "SA_IMPORTE_BONIFICACION");

            migrationBuilder.DropTable(
                name: "SA_IMPORTE_PREDETERMINADO_IMPORTE");

            migrationBuilder.DropTable(
                name: "SA_IMPORTE_PREDETERMINADO_IMPORTE_PRUEBAS");

            migrationBuilder.DropTable(
                name: "SA_IMPORTE_PREDETERMINADO_TERCERO");

            migrationBuilder.DropTable(
                name: "SA_IMPORTE_PREDETERMINADO_TERCERO_PRUEBAS");

            migrationBuilder.DropTable(
                name: "SA_IMPORTE_TERCERO");

            migrationBuilder.DropTable(
                name: "SA_IMPORTE_TERCERO_BITACORA");

            migrationBuilder.DropTable(
                name: "SA_IMPORTE_TERCERO_PRUEBAS");

            migrationBuilder.DropTable(
                name: "SA_LUGARES");

            migrationBuilder.DropTable(
                name: "SA_MOVIMIENTOS_DETA");

            migrationBuilder.DropTable(
                name: "SA_MOVIMIENTOS_ENCA");

            migrationBuilder.DropTable(
                name: "SA_PARAMETRO");

            migrationBuilder.DropTable(
                name: "SA_PARAMETROS_DE_ACCION");

            migrationBuilder.DropTable(
                name: "SA_PLAZO_PAGO_MEMBRESIA");

            migrationBuilder.DropTable(
                name: "SA_SEGURIDAD");

            migrationBuilder.DropTable(
                name: "SA_SERIE");

            migrationBuilder.DropTable(
                name: "SA_TERCERO_ARCHIVO");

            migrationBuilder.DropTable(
                name: "SA_USUARIO");

            migrationBuilder.DropTable(
                name: "SA_VERIFICAR_TER");

            migrationBuilder.DropTable(
                name: "SA_VISITA");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SA_DEPENDIENTE");

            migrationBuilder.DropTable(
                name: "ETIPODOCUMENTO");

            migrationBuilder.DropTable(
                name: "SA_IMPORTE");

            migrationBuilder.DropTable(
                name: "SA_COD_BANCO");

            migrationBuilder.DropTable(
                name: "SA_COD_TRANSACCION");

            migrationBuilder.DropTable(
                name: "SA_COD_GRUPO_PAR");

            migrationBuilder.DropTable(
                name: "SA_COD_ACCESO");

            migrationBuilder.DropTable(
                name: "SA_COD_OPCION");

            migrationBuilder.DropTable(
                name: "SA_COD_GRUPO_SER");

            migrationBuilder.DropTable(
                name: "SA_COD_GRUPO_USU");

            migrationBuilder.DropTable(
                name: "SA_COD_SUCURSAL");

            migrationBuilder.DropTable(
                name: "SA_TERCERO");

            migrationBuilder.DropTable(
                name: "SA_COD_ESTUSU");

            migrationBuilder.DropTable(
                name: "SA_COD_SUBTIPO");

            migrationBuilder.DropTable(
                name: "SA_COD_TIPO_TRANSACCION");

            migrationBuilder.DropTable(
                name: "SA_CLIENTE");

            migrationBuilder.DropTable(
                name: "SA_COD_TIPO_COMPRA");

            migrationBuilder.DropTable(
                name: "SA_COD_TIPO_MANTENIMIENTO");

            migrationBuilder.DropTable(
                name: "SA_COD_TIPO_MEMBRESIA");

            migrationBuilder.DropTable(
                name: "SA_COD_TIPO");

            migrationBuilder.DropTable(
                name: "SA_COD_COBRO");

            migrationBuilder.DropTable(
                name: "SA_COD_EMPRESA");
        }
    }
}
