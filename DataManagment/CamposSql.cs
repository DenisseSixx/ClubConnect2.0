

using System.ComponentModel;

namespace DataManagment
{
    public class CamposSql : ICamposSql
    {
        public static CamposSql instancia = null;
        private CamposSql()
        {
        }
        public static CamposSql ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new CamposSql();
            }
            return instancia;
        }

        public string ObtenerInsert<T>(string palabraRecervadaValue, T objeto)
        {
            throw new NotImplementedException();
        }

        public string ObtenerSetUpdate<T>(T objeto)
        {
            throw new NotImplementedException();
        }

        internal string ObtenerFiltro<T>(T objeto)
        {
            throw new NotImplementedException();
        }

        string ICamposSql.ObtenerFiltro<T>(T objeto)
        {
            throw new NotImplementedException();
        }
    }
}
