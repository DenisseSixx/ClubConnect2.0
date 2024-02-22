
using Objects;

namespace DataManagment
{
    public class Consultas : IDisposable, IConsultas
    {
        public static Consultas instancia = null;
        private IConsultas conector;
        public Consultas(IConsultas conector)
        {
            this.conector = conector;
        }

        public InfoCompartidaCapas Crear<TEntityT>(TEntityT objeto, bool usaTransaccionSiAplica = false)
        {
            return conector.Crear(objeto, usaTransaccionSiAplica);
        }

        public InfoCompartidaCapas Crear<TEntityT>(List<TEntityT> objeto, bool usaTransaccionSiAplica = false)
        {
            return conector.Crear(objeto, usaTransaccionSiAplica);
        }

        public InfoCompartidaCapas Modificar<TEntityT>(TEntityT objeto, bool usaTransaccionSiAplica = false)
        {
            return conector.Modificar(objeto, usaTransaccionSiAplica);
        }

        public InfoCompartidaCapas Modificar<TEntityT>(List<TEntityT> objeto, bool usaTransaccionSiAplica = false)
        {
            return conector.Modificar(objeto, usaTransaccionSiAplica);
        }

        //public List<NPOI.SS.Formula.Functions.T> Obtener<TEntityT>(TEntityT objeto, bool usaTransaccionSiAplica = false)
        //{
        //    return conector.Obtener(objeto, usaTransaccionSiAplica);
        //}

        /*public DataTable Obtener<T>(T objeto, bool usaTransaccionSiAplica = false)
                {
                    return conector.Obtener(objeto, usaTransaccionSiAplica);

                */
        public InfoCompartidaCapas Compartir<T>(T objeto, bool usaTransaccionSiAplica = false)
        {
            return conector.Compartir(objeto, usaTransaccionSiAplica);

        }
        public InfoCompartidaCapas Compartir<T>(List<T> objeto, bool usaTransaccionSiAplica = false)
        {
            return conector.Compartir(objeto, usaTransaccionSiAplica);
        }

        public InfoCompartidaCapas Eliminar<T>(T objeto, bool usaTransaccionSiAplica = false)
        {
            return conector.Eliminar(objeto, usaTransaccionSiAplica);
        }

        public InfoCompartidaCapas Eliminar<T>(List<T> objeto, bool usaTransaccionSiAplica = false)
        {
            return conector.Eliminar(objeto, usaTransaccionSiAplica);
        }

        public void GuardarTransaccion()
        {
            conector.GuardarTransaccion();
        }

        public void IniciarTransaccion()
        {
            conector.IniciarTransaccion();
        }

        public void RegresarTransaccion()
        {
            conector.RegresarTransaccion();
        }
        public System.Data.Common.DbConnection ObtenerConeccion()
        {
            return conector.ObtenerConeccion();
        }
        public System.Data.Common.DbTransaction ObtenerTransaccion()
        {
            return conector.ObtenerTransaccion();
        }
        public InfoCompartidaCapas EjecutarStoredProcedure(string nombre, List<Objects.Parametros> parametros, bool soloEjecutar, bool usaTransaccionSiAplica = false)
        {
            return conector.EjecutarStoredProcedure(nombre, parametros, soloEjecutar, usaTransaccionSiAplica);
        }

        public void Dispose()
        {
            conector.Dispose();
            GC.SuppressFinalize(this);
        }



    }
}
