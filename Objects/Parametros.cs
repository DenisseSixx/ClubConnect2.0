
namespace Objects
{
    public class Parametros
    {
        public string nombre { get; set; }
        public object valor { get; set; }
        public bool esSalida
        {
            get; set;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
