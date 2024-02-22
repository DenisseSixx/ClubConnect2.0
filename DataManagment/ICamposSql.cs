namespace DataManagment
{
    public interface ICamposSql
    {
        public string ObtenerFiltro<T>(T objeto);
        public string ObtenerSetUpdate<T>(T objeto);
        public string ObtenerInsert<T>(string palabraRecervadaValue, T objeto);
    }
}
