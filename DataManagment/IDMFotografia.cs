using Objects;


namespace DataManagment
{
    public interface IDMFotografia
    {

        public List<Fotografias> Obtener(int IdDocumento, int CodTipoDocumento);
        public InfoCompartidaCapas Crear(Fotografias fotografia);
        public InfoCompartidaCapas Crear(List<Fotografias> fotografia);
        public InfoCompartidaCapas Modificar(Fotografias fotografia);
        public InfoCompartidaCapas Modificar(List<Fotografias> fotografia);
        public InfoCompartidaCapas Eliminar(Fotografias fotografia);


        public void GuardarTransaccion()
        {
            throw new NotImplementedException();
        }

        public void RegresarTransaccion()
        {
            throw new NotImplementedException();
        }

        List<Fotografias> Obtener(int id, string codTipoDocumento);
    }
}
