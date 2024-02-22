

using Objects;

namespace DataManagment
{
    public class DMFotografia
    {
        private IConsultas consulta;
        private int timeOut;
        private bool trabajaTransaccion;

        public DMFotografia()
        {

        }
        private void InstanciarConsulta()
        {

            this.consulta = new Consultas(new ConsultasSqlServer());
        }
        private void LiberarConsulta()
        {
            if (trabajaTransaccion)
                this.consulta.Dispose();
        }
        public DMFotografia(bool preparaTransaccion)
        {

            trabajaTransaccion = preparaTransaccion;
            if (trabajaTransaccion)
            {
                InstanciarConsulta();
                this.consulta.IniciarTransaccion();
            }
            else
            {
                InstanciarConsulta();
            }
        }
        public void GuardarTransaccion()
        {
            this.consulta.GuardarTransaccion();
            this.consulta.Dispose();
        }
        public void RegresarTransaccion()
        {
            this.consulta.RegresarTransaccion();
            this.consulta.Dispose();
        }

        public InfoCompartidaCapas Compartir(Fotografias fotografia)
        {
            throw new NotImplementedException();
        }

        public InfoCompartidaCapas Crear(Fotografias fotografia)
        {
            {
                try
                {
                    InstanciarConsulta();
                    consulta.Crear(fotografia);
                    LiberarConsulta();
                    return new InfoCompartidaCapas() { informacion = fotografia };
                }
                catch (Exception)
                {
                    return new InfoCompartidaCapas() { error = $"Error al agregar {fotografia.IdFotografia}" };
                }
            }
        }

        public InfoCompartidaCapas Crear(List<Fotografias> fotografia)
        {
            {
                try
                {
                    foreach (var item in fotografia)
                    {
                        InstanciarConsulta();
                        consulta.Crear(item);
                        LiberarConsulta();
                    }
                    return new InfoCompartidaCapas() { informacion = fotografia };
                }
                catch (Exception e)
                {
                    return new InfoCompartidaCapas() { error = e.Message };
                };
            }
        }

        public void Dispose()
        {
            this.consulta.Dispose();
        }

        //public InfoCompartidaCapas Eliminar(Fotografias fotografia)
        //{
        //    try
        //    {
        //        cuotas_v100.Miemb.Remove(fotografia);
        //        return new InfoCompartidaCapas() { informacion = fotografia };
        //    }
        //    catch (Exception)
        //    {
        //        return new InfoCompartidaCapas() { error = $"Error al eliminar {fotografia.IdFotografia}" };
        //    }
        //}


        public InfoCompartidaCapas Modificar(Fotografias fotografia)
        {

            {
                try
                {
                    InstanciarConsulta();
                    consulta.Modificar(fotografia);
                    LiberarConsulta();
                    return new InfoCompartidaCapas() { informacion = fotografia };
                }
                catch (Exception)
                {
                    return new InfoCompartidaCapas() { error = $"Error al agregar {fotografia.IdFotografia}" };
                }
            }
        }

        public InfoCompartidaCapas Modificar(List<Fotografias> fotografia)
        {
            {
                try
                {
                    foreach (var item in fotografia)
                    {
                        InstanciarConsulta();
                        consulta.Modificar(item);
                        LiberarConsulta();
                    }
                    return new InfoCompartidaCapas() { informacion = fotografia };
                }
                catch (Exception e)
                {
                    return new InfoCompartidaCapas() { error = e.Message };
                };
            }
        }

        public List<Fotografias> Obtener(int IdFotografia, int CodTipoDocumento)
        {
            List<Fotografias> fotografias = new List<Fotografias>();
            Fotografias fotografia = new Fotografias();
            List<Parametros> parametros = new List<Parametros>();
            {
                new Parametros()
                {
                    nombre = "",
                    valor = fotografia.FotoMiembro,
                    esSalida = false
                };
                InstanciarConsulta();
                InfoCompartidaCapas aux = consulta.EjecutarStoredProcedure("ObtenerFotografias", parametros, false, false);
                LiberarConsulta();

                return fotografias;
            }

        }

        public List<Fotografias> Obtener(int id, string codTipoDocumento)
        {
            List<Fotografias> fotografias = new List<Fotografias>();
            Fotografias fotografia = new Fotografias();
            List<Parametros> parametros = new List<Parametros>();
            {
                new Parametros()
                {
                    nombre = "",
                    valor = fotografia.FotoMiembro,
                    esSalida = false
                };
                InstanciarConsulta();
                InfoCompartidaCapas aux = consulta.EjecutarStoredProcedure("ObtenerDocuementos", parametros, false, false);
                LiberarConsulta();

                return fotografias;
            }
        }
    }
}

