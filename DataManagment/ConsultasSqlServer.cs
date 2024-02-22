using Microsoft.Data.SqlClient;
using Objects;
using System.Data.Common;

namespace DataManagment
{
    public class ConsultasSqlServer : IConsultas, IDisposable
    {
        public static SqlConnection conexion;
        private SqlTransaction transaccion = null;
        private int timeOutSql = -1;
        public ConsultasSqlServer()
        {
            IniciarConeccion();
        }
        public ConsultasSqlServer(int timeOut)
        {
            timeOutSql = timeOut;
            IniciarConeccion();
        }
        private void IniciarConeccion()
        {
            //   coneccion = new SqlConnection("Server=localhost;Database=Tienda;UID=Tienda;PWD=Tienda;TrustServerCertificate=true"/*new Conecciones().ObtenerConeccion("Tienda")*/);
            conexion = new SqlConnection("Server=DLUGO_PC\\SQL_DLUGO_2K22;Database=cuotas_v100;UID=sa;PWD=Usuario1;TrustServerCertificate=True;"/*new Conecciones().ObtenerConeccion("Tienda")*/);

        }
        private void ConectarSinTransaccion()
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                IniciarConeccion();
                conexion.Open();
            }
        }
        private void DesconectarSinTransaccion()
        {
            if (transaccion == null)
            {
                conexion.Close();
                conexion.Dispose();
            }
        }
        private void DesconectarSinTransaccionError()
        {
            if (conexion.State == System.Data.ConnectionState.Open && transaccion == null)
            {
                conexion.Close();
                conexion.Dispose();
            }
        }

        /*  public List<NPOI.SS.Formula.Functions.T> Obtener<TEntityT>(TEntityT objeto, bool usaTransaccionSiAplica = false)
          {
              throw new NotImplementedException();
          }*/

        public System.Data.DataTable Obtener<T>(T objeto, bool usaTransaccionSiAplica = false)
        {
            try
            {
                ConectarSinTransaccion();
                SqlCommand consulta = new SqlCommand("select * from " + objeto.GetType().Name + "s" + CamposSql.ObtenerInstancia(), conexion);
                if (usaTransaccionSiAplica && transaccion != null)
                    consulta.Transaction = transaccion;
                if (timeOutSql > -1)
                    consulta.CommandTimeout = timeOutSql;
                SqlDataAdapter resultado = new SqlDataAdapter(consulta);
                System.Data.DataTable tabla = new System.Data.DataTable();
                tabla.TableName = objeto.GetType().Name;
                resultado.Fill(tabla);
                consulta.Dispose();
                DesconectarSinTransaccion();
                return tabla;
            }
            catch (Exception)
            {
                DesconectarSinTransaccionError();
                throw;
            }
        }
        public System.Data.DataTable Obtener<T>(T objeto)
        {
            throw new NotImplementedException();
        }



        public void Dispose()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
            GC.SuppressFinalize(this);
        }

        //List<NPOI.SS.Formula.Functions.T> IConsultas.Obtener<TEntityT>(TEntityT objeto, bool usaTransaccionSiAplica = false)
        //{
        //    throw new NotImplementedException();
        //}
        public void GuardarTransaccion()
        {
            this.transaccion.Commit();
            conexion.Close();
            this.transaccion = null;
            conexion.Dispose();
        }

        public void IniciarTransaccion()
        {
            conexion.Open();
            this.transaccion = conexion.BeginTransaction();
        }

        public void RegresarTransaccion()
        {
            this.transaccion.Rollback();
            conexion.Close();
            this.transaccion = null;
            conexion.Dispose();
        }
        public DbConnection ObtenerConeccion()
        {
            return conexion;
        }
        public DbTransaction ObtenerTransaccion()
        {
            return this.transaccion;
        }
        public System.Data.DataTable ObtenerSql<T>(T objeto, bool usaTransaccionSiAplica = false)

        {
            {
                try
                {
                    ConectarSinTransaccion();
                    SqlCommand consulta = new SqlCommand("select * from " + objeto.GetType().Name + "s" + CamposSql.ObtenerInstancia().ObtenerFiltro(objeto), conexion);
                    if (usaTransaccionSiAplica && transaccion != null)
                        consulta.Transaction = transaccion;
                    if (timeOutSql > -1)
                        consulta.CommandTimeout = timeOutSql;
                    SqlDataAdapter resultado = new SqlDataAdapter(consulta);
                    System.Data.DataTable tabla = new System.Data.DataTable();
                    tabla.TableName = objeto.GetType().Name;
                    resultado.Fill(tabla);
                    consulta.Dispose();
                    DesconectarSinTransaccion();
                    return tabla;

                }
                catch (Exception)
                {
                    DesconectarSinTransaccionError();
                    throw;
                }
            }
        }


        public InfoCompartidaCapas Crear<T>(T objeto, bool usaTransaccionSiAplica = false)
        {
            try
            {
                ConectarSinTransaccion();
                SqlCommand consulta = new SqlCommand("insert into " + objeto.GetType().Name + "s" + CamposSql.ObtenerInstancia().ObtenerFiltro(objeto), conexion);
                if (usaTransaccionSiAplica && transaccion != null)
                    consulta.Transaction = transaccion;
                if (timeOutSql > -1)
                    consulta.CommandTimeout = timeOutSql;
                consulta.ExecuteNonQuery();
                consulta.Dispose();
                DesconectarSinTransaccion();
                return new InfoCompartidaCapas() { informacion = true };
            }
            catch (Exception)
            {
                DesconectarSinTransaccionError();
                throw;
            };
        }

        public InfoCompartidaCapas Crear<T>(List<T> objeto, bool usaTransaccionSiAplica = false)
        {
            try
            {
                ConectarSinTransaccion();
                foreach (T item in objeto)
                {
                    SqlCommand consulta = new SqlCommand("insert into" + item.GetType().Name + "s" + CamposSql.ObtenerInstancia().ObtenerFiltro(item), conexion);
                    if (usaTransaccionSiAplica && transaccion != null)
                        consulta.Transaction = transaccion;
                    if (timeOutSql > -1)
                        consulta.CommandTimeout = timeOutSql;
                    consulta.ExecuteNonQuery();
                    consulta.Dispose();
                }

                DesconectarSinTransaccion();
                return new InfoCompartidaCapas() { informacion = true };
            }
            catch (Exception)
            {
                DesconectarSinTransaccionError();
                throw;
            }
        }


        public InfoCompartidaCapas Modificar<T>(T objeto, bool usaTransaccionSiAplica = false)
        {
            try
            {
                ConectarSinTransaccion();
                SqlCommand consulta = new SqlCommand("update " + objeto.GetType().Name + "s" + CamposSql.ObtenerInstancia().ObtenerFiltro(objeto), conexion);
                if (usaTransaccionSiAplica && transaccion != null)
                    consulta.Transaction = transaccion;
                if (timeOutSql > -1)
                    consulta.CommandTimeout = timeOutSql;
                consulta.ExecuteNonQuery();
                consulta.Dispose();
                DesconectarSinTransaccion();
                return new InfoCompartidaCapas() { informacion = true };
            }
            catch (Exception)
            {
                DesconectarSinTransaccionError();
                throw;
            };
        }

        public InfoCompartidaCapas Modificar<T>(List<T> objeto, bool usaTransaccionSiAplica = false)
        {
            try
            {
                ConectarSinTransaccion();
                foreach (T item in objeto)
                {
                    SqlCommand consulta = new SqlCommand("update" + item.GetType().Name + "s" + CamposSql.ObtenerInstancia().ObtenerFiltro(item), conexion);
                    if (usaTransaccionSiAplica && transaccion != null)
                        consulta.Transaction = transaccion;
                    if (timeOutSql > -1)
                        consulta.CommandTimeout = timeOutSql;
                    consulta.ExecuteNonQuery();
                    consulta.Dispose();
                }

                DesconectarSinTransaccion();
                return new InfoCompartidaCapas() { informacion = true };
            }
            catch (Exception)
            {
                DesconectarSinTransaccionError();
                throw;
            }
        }

        public InfoCompartidaCapas Compartir<T>(T objeto, bool usaTransaccionSiAplica = false)
        {
            throw new NotImplementedException();
        }

        public InfoCompartidaCapas Compartir<T>(List<T> objeto, bool usaTransaccionSiAplica = false)
        {
            throw new NotImplementedException();
        }



        public InfoCompartidaCapas Eliminar<T>(T objeto, bool usaTransaccionSiAplica = false)
        {
            try
            {
                ConectarSinTransaccion();
                SqlCommand consulta = new SqlCommand("delete from " + objeto.GetType().Name + "s" + CamposSql.ObtenerInstancia().ObtenerFiltro(objeto), conexion);
                if (usaTransaccionSiAplica && transaccion != null)
                    consulta.Transaction = transaccion;
                if (timeOutSql > -1)
                    consulta.CommandTimeout = timeOutSql;
                consulta.ExecuteNonQuery();
                consulta.Dispose();
                DesconectarSinTransaccion();
                return new InfoCompartidaCapas() { informacion = true };
            }
            catch (Exception)
            {
                DesconectarSinTransaccionError();
                throw;
            };
        }

        public InfoCompartidaCapas Eliminar<T>(List<T> objeto, bool usaTransaccionSiAplica = false)
        {
            try
            {
                ConectarSinTransaccion();
                foreach (T item in objeto)
                {
                    // Construye y ejecuta una consulta DELETE para el objeto actual
                    SqlCommand consulta = new SqlCommand("delete from " + item.GetType().Name + "s" + CamposSql.ObtenerInstancia().ObtenerFiltro(item), conexion);

                    // Asigna una transacción si es aplicable
                    if (usaTransaccionSiAplica && transaccion != null)
                        consulta.Transaction = transaccion;

                    // Configura el tiempo de espera si se proporciona un valor válido
                    if (timeOutSql > -1)
                        consulta.CommandTimeout = timeOutSql;

                    // Ejecuta la consulta DELETE
                    consulta.ExecuteNonQuery();

                    // Libera los recursos del objeto SqlCommand
                    consulta.Dispose();
                }

                // Desconecta sin transacción después de completar todas las operaciones
                DesconectarSinTransaccion();

                // Retorna un objeto InfoCompartidaCapas con la información de éxito
                return new InfoCompartidaCapas() { informacion = true };
            }
            catch (Exception)
            {
                // En caso de error, desconecta sin transacción, maneja el error y relanza la excepción
                DesconectarSinTransaccionError();
                throw;
            }

        }

        public InfoCompartidaCapas EjecutarStoredProcedure(string nombre, List<Objects.Parametros> parametros, bool soloEjecutar, bool usaTransaccionSiAplica = false)
        {
            try
            {
                ConectarSinTransaccion();
                SqlCommand consulta = new SqlCommand();
                consulta.Connection = conexion;
                consulta.CommandType = System.Data.CommandType.StoredProcedure;
                consulta.CommandText = nombre;
                System.Data.DataTable tabla = new System.Data.DataTable();
                if (parametros.Count > 0)
                {
                    foreach (Objects.Parametros parametro in parametros)
                    {
                        SqlParameter parametroSql = new SqlParameter();
                        parametroSql.ParameterName = parametro.nombre;
                        parametroSql.Value = parametro.valor;
                        if (parametro.esSalida)
                            parametroSql.Direction = System.Data.ParameterDirection.InputOutput;
                        consulta.Parameters.Add(parametroSql);
                    }
                }
                if (usaTransaccionSiAplica && transaccion != null)
                    consulta.Transaction = transaccion;
                if (timeOutSql > -1)
                    consulta.CommandTimeout = timeOutSql;
                if (soloEjecutar)
                {
                    consulta.ExecuteNonQuery();
                }
                else
                {
                    SqlDataAdapter resultado = new SqlDataAdapter(consulta);
                    tabla.TableName = nombre;
                    resultado.Fill(tabla);
                }
                DesconectarSinTransaccion();
                List<Parametros> resultados = new List<Parametros>();
                List<SqlParameter> parametrosSalida = new List<SqlParameter>();
                foreach (SqlParameter item in consulta.Parameters)
                {
                    if (item.Direction == System.Data.ParameterDirection.Output || item.Direction == System.Data.ParameterDirection.InputOutput)
                    {
                        parametrosSalida.Add(item);
                    }
                }
                consulta.Dispose();
                foreach (SqlParameter item in parametrosSalida)
                {
                    Parametros auxResultado = parametros.Where(a => item.ParameterName.Contains(a.nombre)).FirstOrDefault();
                    if (auxResultado != null)
                    {
                        auxResultado.valor = item.Value;
                        resultados.Add(auxResultado);
                    }
                }
                foreach (Objects.Parametros parametro in parametros)
                {
                    parametro.Dispose();
                }
                if (soloEjecutar)
                {
                    tabla.Dispose();
                    if (resultados.Count > 0)
                        return new InfoCompartidaCapas() { informacion = resultados };
                    else
                        return new InfoCompartidaCapas() { informacion = true };
                }
                else
                {
                    if (resultados.Count > 0)
                        return new InfoCompartidaCapas() { informacion = new object[] { tabla, resultados } };
                    else
                        return new InfoCompartidaCapas() { informacion = tabla };
                }
            }
            catch (Exception)
            {
                DesconectarSinTransaccionError();
                throw;
            }
        }
    }
}