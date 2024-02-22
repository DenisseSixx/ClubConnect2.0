using Objects;

namespace DataManagment
{
    public interface IDMUsuarios
    {
        public new List<Usuario> Obtener(int id, string NomTercero);
        public InfoCompartidaCapas Crear(Usuario usuarios);
        public InfoCompartidaCapas Crear(List<Usuario> usuarios);
        public InfoCompartidaCapas Modificar(Usuario usuarios);
        public InfoCompartidaCapas Modificar(List<Usuario> usuarios);
        public InfoCompartidaCapas Eliminar(Usuario usuarios);


        public void GuardarTransaccion()
        {
            throw new NotImplementedException();
        }

        public void RegresarTransaccion()
        {
            throw new NotImplementedException();
        }

    }
}
