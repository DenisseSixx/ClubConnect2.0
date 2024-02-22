using Objects;

namespace DataManagment
{
    public interface IConsultas : IDisposable, IDMTransacciones
    {
        //  public List<NPOI.SS.Formula.Functions.T> Obtener<TEntityT>(TEntityT objeto, bool usaTransaccionSiAplica = false);

        // public System.Data.DataTable Obtener<T>(T objeto, bool usaTransaccionSiAplica = false);
        public InfoCompartidaCapas Crear<T>(T objeto, bool usaTransaccionSiAplica = false);
        public InfoCompartidaCapas Crear<T>(List<T> objeto, bool usaTransaccionSiAplica = false);
        public InfoCompartidaCapas Modificar<T>(T objeto, bool usaTransaccionSiAplica = false);
        public InfoCompartidaCapas Modificar<T>(List<T> objeto, bool usaTransaccionSiAplica = false);
        public InfoCompartidaCapas Compartir<T>(T objeto, bool usaTransaccionSiAplica = false);
        public InfoCompartidaCapas Compartir<T>(List<T> objeto, bool usaTransaccionSiAplica = false);
        public InfoCompartidaCapas Eliminar<T>(T objeto, bool usaTransaccionSiAplica = false);
        public InfoCompartidaCapas Eliminar<T>(List<T> objeto, bool usaTransaccionSiAplica = false);


        public void IniciarTransaccion();
        public System.Data.Common.DbConnection ObtenerConeccion();
        public System.Data.Common.DbTransaction ObtenerTransaccion();
        public InfoCompartidaCapas EjecutarStoredProcedure(string nombre, List<Objects.Parametros> parametros, bool soloEjecutar, bool usaTransaccionSiAplica = false);

    }
}
