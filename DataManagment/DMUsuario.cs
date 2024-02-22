using Objects;
namespace DataManagment
{
    public class DMUsuario: IDMUsuarios, IDisposable
    {
        private IConsultas consulta;
        private int timeOut;
        private bool trabajaTransaccion;

        public DMUsuario()
        {
        }
            public DMUsuario(int timeOut)
            {
                this.timeOut = timeOut;
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
            public DMUsuario(bool preparaTransaccion)
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


            public InfoCompartidaCapas Crear(Usuario usuarios)
            {
                try
                {
                    InstanciarConsulta();
                    consulta.Crear(usuarios);
                    LiberarConsulta();
                    return new InfoCompartidaCapas() { informacion = usuarios };
                }
                catch (Exception)
                {
                    return new InfoCompartidaCapas() { error = $"Error al agregar {usuarios.CodUsuario}" };
                }
            }

            public InfoCompartidaCapas Crear(List<Usuario> usuarios)
            {
                {
                    try
                    {
                        foreach (var item in usuarios)
                        {
                            InstanciarConsulta();
                            consulta.Crear(item);
                            LiberarConsulta();
                        }
                        return new InfoCompartidaCapas() { informacion = usuarios };
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

            public InfoCompartidaCapas Modificar(Usuario usuarios)
            {
                {
                    try
                    {
                        InstanciarConsulta();
                        consulta.Modificar(usuarios);
                        LiberarConsulta();
                        return new InfoCompartidaCapas() { informacion = usuarios };
                    }
                    catch (Exception)
                    {
                        return new InfoCompartidaCapas() { error = $"Error al modificar {usuarios.CodUsuario}" };
                    }

                }
            }

            public InfoCompartidaCapas Modificar(List<Usuario> usuarios)
            {
                {
                    try
                    {
                        foreach (var item in usuarios)
                        {
                            InstanciarConsulta();
                            consulta.Modificar(item);
                            LiberarConsulta();
                        }
                        return new InfoCompartidaCapas() { informacion = usuarios };
                    }
                    catch (Exception e)
                    {
                        return new InfoCompartidaCapas() { error = e.Message };
                    };
                }
            }

            public InfoCompartidaCapas Eliminar(Usuario usuarios)
            {
                try
                {
                    //tienda.Miemb.Remove(usuarios);
                    return new InfoCompartidaCapas() { informacion = usuarios };
                }
                catch (Exception)
                {
                    return new InfoCompartidaCapas() { error = $"Error al eliminar {usuarios.CodUsuario}" };
                }
            }

            public List<Usuario> Obtener(string Nombre)
            {
                List<Usuario> Usuarios = new List<Usuario>();
                Usuario usuarios = new Usuario();
                // usuarios.id = id;
                usuarios.Nombre = Nombre ;
                List<Parametros> parametros = new List<Parametros>()
            {
                new Parametros() { nombre = "CodUsuario", valor = usuarios.CodUsuario, esSalida = false },
                new Parametros() { nombre = "Nombre", valor = usuarios.Nombre, esSalida = false },
                new Parametros() { nombre = "Correo", valor = usuarios.Correo, esSalida = false },

            };
                InstanciarConsulta();
                InfoCompartidaCapas aux = consulta.EjecutarStoredProcedure("ObtenerMiembros", parametros, false, false);
                LiberarConsulta();

                return Usuarios;
            }

            public List<Usuario> Obtener(string CodUsuario, string Nombre)
            {
                List<Usuario> Usuarios = new List<Usuario>();
                Usuario usuarios = new Usuario();
                usuarios.CodUsuario = CodUsuario;
                usuarios.Nombre = Nombre;
                List<Parametros> parametros = new List<Parametros>()
            {
             new Parametros() { nombre = "CodUsuario", valor = usuarios.CodUsuario, esSalida = false },
                new Parametros() { nombre = "Nombre", valor = usuarios.Nombre, esSalida = false },
                new Parametros() { nombre = "Correo", valor = usuarios.Correo, esSalida = false },

            };
                InstanciarConsulta();
                InfoCompartidaCapas aux = consulta.EjecutarStoredProcedure("ObtenerMiembros", parametros, false, false);
                LiberarConsulta();

                return Usuarios;
            }

        public List<Usuario> Obtener(int id, string NomTercero)
        {
            throw new NotImplementedException();
        }
    }
    }

