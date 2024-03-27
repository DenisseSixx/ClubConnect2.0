using DataManagment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Rules
{
    public class AutorizacionDepen
    {
        public bool VerifyCodAutorizacion(string codUsuario)
        {
            using (var contexto = new CuotasV100Context())
                try
                {

                    {
                        // Consulta para obtener el código de tercero y dependiente del usuario
                        var usuario = contexto.Appusuarios.FirstOrDefault(u => u.CodUsuario == codUsuario);

                        if (usuario != null)
                        {
                            // Consulta para verificar la autorización en la tabla appautorizacion
                            var autorizacion = contexto.Appautorizacionds.FirstOrDefault(a => a.CodTercero == usuario.CodTercero && a.CodDependiente == usuario.CodDependiente);


                            if (autorizacion != null)
                            {
                                return autorizacion.CodAutorizacion ?? false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error verifying codautorizacion: " + ex.Message);
                }

            return false;
        }

        public int? ObtenerCodDependiente(string codUsuario)
        {
            using (var contexto = new CuotasV100Context())
            {
                try
                {
                    // Consulta para obtener el código de dependiente del usuario
                    var codDependiente = contexto.Appusuarios
                        .Where(u => u.CodUsuario == codUsuario)
                        .Select(u => u.CodDependiente)
                        .FirstOrDefault();

                    return (int?)codDependiente;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error obteniendo el CodDependiente: " + ex.Message);
                    return null;
                }
            }
        }

    }
}
