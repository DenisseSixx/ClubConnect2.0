/*using DataManagment.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Rules
{
    public class EstadoCuentaBase
    {
        public static List<EstadoCuentaItem> EstadoCuenta(string cod)
        {
            List<EstadoCuentaItem> listaItems = new List<EstadoCuentaItem>();

            using (var contexto = new CuotasV100Context())
            {
                // Variables para almacenar los valores de salida
                decimal uncodmenmemValue;
                decimal uncodmenmemantValue;
                decimal uncodanumemValue;
                decimal uncodanumemantValue;
                string uvdesmenmemValue;
                string uvdesanumemValue;
                decimal unporcartarValue;

                // Primer llamado al procedimiento almacenado
                contexto.Database.ExecuteSqlRaw(
                        "EXEC sa_LisImpTerCodMes @IVCODEMP, @IVCODCLI, @IVCODTER, @IDFECPRO, @UNCODMENMEM OUT, @UNCODMENMEMANT OUT, @UNCODANUMEM OUT, @UNCODANUMEMANT OUT, @UVDESMENMEM OUT, @UVDESANUMEM OUT, @UNPORCARTAR OUT",
                        new SqlParameter("@IVCODEMP", "CAP"),
                        new SqlParameter("@IVCODCLI", "CTR00026478"),
                        new SqlParameter("@IVCODTER", cod),
                        new SqlParameter("@IDFECPRO", DateTime.Now),
                        new SqlParameter("@UNCODMENMEM", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                        new SqlParameter("@UNCODMENMEMANT", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                        new SqlParameter("@UNCODANUMEM", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                        new SqlParameter("@UNCODANUMEMANT", SqlDbType.Decimal) { Direction = ParameterDirection.Output },
                        new SqlParameter("@UVDESMENMEM", SqlDbType.VarChar, 50) { Direction = ParameterDirection.Output },
                        new SqlParameter("@UVDESANUMEM", SqlDbType.VarChar, 50) { Direction = ParameterDirection.Output },
                        new SqlParameter("@UNPORCARTAR", SqlDbType.Decimal) { Direction = ParameterDirection.Output }
                    );

                // Almacenar los valores de salida en variables
                uncodmenmemValue = Convert.ToDecimal(contexto.Entry(contexto).Property("@UNCODMENMEM").CurrentValue);
                uncodmenmemantValue = Convert.ToDecimal(contexto.Entry(contexto).Property("@UNCODMENMEMANT").CurrentValue);
                uncodanumemValue = Convert.ToDecimal(contexto.Entry(contexto).Property("@UNCODANUMEM").CurrentValue);
                uncodanumemantValue = Convert.ToDecimal(contexto.Entry(contexto).Property("@UNCODANUMEMANT").CurrentValue);
                uvdesmenmemValue = contexto.Entry(contexto).Property("@UVDESMENMEM").CurrentValue.ToString();
                uvdesanumemValue = contexto.Entry(contexto).Property("@UVDESANUMEM").CurrentValue.ToString();
                unporcartarValue = Convert.ToDecimal(contexto.Entry(contexto).Property("@UNPORCARTAR").CurrentValue);

                // Segundo llamado al procedimiento almacenado usando los valores de salida
                contexto.Database.ExecuteSqlRaw(
                        "EXEC sa_LisImpTerCodMes @IVCODEMP, @IVCODCLI, @IVCODTER, @IDFECPRO, @UNCODMENMEM, @UNCODMENMEMANT, @UNCODANUMEM, @UNCODANUMEMANT, @UVDESMENMEM, @UVDESANUMEM, @UNPORCARTAR",
                        new SqlParameter("@IVCODEMP", "CAP"),
                        new SqlParameter("@IVCODCLI", "CTR00026478"),
                        new SqlParameter("@IVCODTER", "valor_ivcodter"),
                        new SqlParameter("@IDFECPRO", DateTime.Now),
                        new SqlParameter("@UNCODMENMEM", uncodmenmemValue),
                        new SqlParameter("@UNCODMENMEMANT", uncodmenmemantValue),
                        new SqlParameter("@UNCODANUMEM", uncodanumemValue),
                        new SqlParameter("@UNCODANUMEMANT", uncodanumemantValue),
                        new SqlParameter("@UVDESMENMEM", uvdesmenmemValue),
                        new SqlParameter("@UVDESANUMEM", uvdesanumemValue),
                        new SqlParameter("@UNPORCARTAR", unporcartarValue)
                    );

                // Aquí puedes continuar con el procesamiento de los resultados
            }

            return listaItems;
        }
    }
}*/