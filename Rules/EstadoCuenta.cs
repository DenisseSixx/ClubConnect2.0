using DataManagment.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Rules
{
    public class EstadoCuenta
    {
        public string connectionString;
        public List<EstadoCuentaItem>EstadoCuentaGeneral(string codigoTer)
        {
            List<EstadoCuentaItem> estadoCuentaItems = new List<EstadoCuentaItem>();
            
            connectionString  = ("Server=DLUGO_PC\\SQL_DLUGO_2K22;Database=cuotas_v100;UID=sa;PWD=Usuario1;TrustServerCertificate=True;"); ;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("sa_LisImpTerCodMes", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parámetros
                    command.Parameters.AddWithValue("@IVCODEMP", "CAP");
                    command.Parameters.AddWithValue("@IVCODCLI", "CTR00026478");
                    command.Parameters.AddWithValue("@IVCODTER", codigoTer);
                    command.Parameters.AddWithValue("@IDFECPRO", "01-04-2024");
                    command.Parameters.AddWithValue("@UNCODMENMEM", 0);
                    command.Parameters.AddWithValue("@UNCODMENMEMANT", 0);
                    command.Parameters.AddWithValue("@UNCODANUMEM", 0);
                    command.Parameters.AddWithValue("@UNCODANUMEMANT", 0);
                    command.Parameters.AddWithValue("@UVDESMENMEM", "");
                    command.Parameters.AddWithValue("@UVDESANUMEM", "");
                    command.Parameters.AddWithValue("@UNPORCARTAR", 0);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EstadoCuentaItem item = new EstadoCuentaItem();
                            item.CodPeriodo = reader.GetDateTime(reader.GetOrdinal("Cod_Periodo"));
                            item.CodImporte = reader.GetDecimal(reader.GetOrdinal("Cod_Importe"));
                            item.CodTipo = reader.GetString(reader.GetOrdinal("Cod_Tipo"));
                            item.CodSubtipo = reader.GetString(reader.GetOrdinal("Cod_Subtipo"));
                            item.Titulo = reader.GetString(reader.GetOrdinal("Titulo"));
                            item.DesImporte = reader.GetString(reader.GetOrdinal("Des_Importe"));
                            item.MontoOriginal = reader.GetDecimal(reader.GetOrdinal("MONTO_ORIGINAL"));
                            item.MonAdeudoAnterior = reader.GetDecimal(reader.GetOrdinal("MON_ADEUDO_ANTERIOR"));
                            item.MonAdeudoAnteriorSinRecargo = reader.GetDecimal(reader.GetOrdinal("MON_ADEUDO_ANTERIOR_SIN_RECARGO"));
                            item.Recargo = reader.GetDecimal(reader.GetOrdinal("Recargo"));
                            item.MonAbono = reader.GetDecimal(reader.GetOrdinal("MON_ABONO"));
                            item.Bonificacion = reader.GetDecimal(reader.GetOrdinal("Bonificacion"));
                            item.MontoDescuento = reader.GetDecimal(reader.GetOrdinal("MONTO_DESCUENTO"));
                            item.MonSubtotalAdeudo = reader.GetDecimal(reader.GetOrdinal("MON_SUBTOTAL_ADEUDO"));
                            item.PorIva = reader.GetDecimal(reader.GetOrdinal("POR_IVA"));
                            item.MonIvaAdeudo = reader.GetDecimal(reader.GetOrdinal("MON_IVA_ADEUDO"));
                            item.MonTotalAdeudo = reader.GetDecimal(reader.GetOrdinal("MON_TOTAL_ADEUDO"));
                            item.AFavorAplicado = reader.GetDecimal(reader.GetOrdinal("A_FAVOR_APLICADO"));
                            item.CobradoAplicado = reader.GetDecimal(reader.GetOrdinal("COBRADO_APLICADO"));

                            estadoCuentaItems.Add(item);
                        }
                    }
                }
            }

            return estadoCuentaItems;
        }
    }
}



