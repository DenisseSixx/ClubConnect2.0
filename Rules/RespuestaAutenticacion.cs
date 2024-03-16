
using DataManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace Rules
{
    public class RespuestaAutenticacion
    {

        public void AgregarRespuestaAute(string codUsuario, string token, DateTime expiracion)
        { 
                using (var context = new CuotasV100Context())
                {
                    // Paso 1: Eliminar datos existentes de la tabla Apprespuestaautenticacion
                    var registroExistente = context.Apprespuestaautenticacion.FirstOrDefault(r => r.CodUsuario == codUsuario);

                    if (registroExistente != null)
                    {
                        context.Apprespuestaautenticacion.Remove(registroExistente);
                        context.SaveChanges();

                    }
                }
                using (var context2 = new CuotasV100Context())
                {
                    // Paso 2: Agregar nuevo registro a la tabla Apprespuestaautenticacion
                    var nuevaRespuesta = new Apprespuestaautenticacion
                    {
                        CodUsuario = codUsuario,
                        token = token,
                        expiracion = expiracion
                    };
                    context2.Apprespuestaautenticacion.Add(nuevaRespuesta);
                    context2.SaveChanges();
                }
        }

        public void AgregarRespuestaAute()
        {
            throw new NotImplementedException();
        }
    }



}

