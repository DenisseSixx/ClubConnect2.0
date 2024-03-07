using System;
using DataManagment.Models;
using Microsoft.Win32;
namespace Rules
{
    public class TablaLogin
    {
        private void EliminarDatosLogin()
        {
            using (var context = new CuotasV100Context())
            {

                var registros = context.Applogin.ToList();
                foreach (var registro in registros)
                {

                    context.Applogin.Remove(registro);
                }


                context.SaveChanges();
            }
        }

        public void AgregarDatosLogin()
        {
            using (var context = new CuotasV100Context())
            {

                // Paso 1: Eliminar datos existentes de la tabla Applogin
                var registrosExistente = context.Applogin.ToList();
                foreach (var registro in registrosExistente)
                {
                    context.Applogin.RemoveRange(registro);
                }
                context.SaveChanges();

                var datosusuarios = context.Appusuarios.ToList();
                // Paso 2: Agregar nuevos datos a la tabla Applogin basándote en Appusuarios
                foreach (var nuevoDatoUsuario in datosusuarios)
                {
                    var nuevoDatoLogin = new Applogin
                    {

                        CodUsuario = nuevoDatoUsuario.CodUsuario,
                        ClaUsuario = nuevoDatoUsuario.ClaUsuario

                        // Asigna otros atributos si es necesario
                    };
                    if (nuevoDatoUsuario.CodEstusu == "A")
                    {
                        context.Applogin.Add(nuevoDatoLogin);
                    }


                    context.SaveChanges();
                }
            }

        }
    }
}



