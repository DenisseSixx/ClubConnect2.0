using DataManagment.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic; // Agrega esta línea

namespace Rules
{
    public class Dependientes
    {
        public List<SaDependiente> ObtenerDependientesDeUsuario(string CodUsuario)
        {
            using (var contexto = new CuotasV100Context())
            {
                var dependientes = contexto.Applogin
                    .Where(l => l.CodUsuario == CodUsuario) // Filtrar por el código de usuario
                    .Join(contexto.Appusuarios, l => l.CodUsuario, u => u.CodUsuario, (l, u) => u) // Unir con la tabla de usuarios
                    .Join(contexto.SaDependientes, u => u.CodTercero, d => d.CodTercero, (u, d) => d)
                     .Where(d => d.CodEstado == "A")// Unir con la tabla de dependientes
                    .ToList();

                return dependientes;
            }
        }
        public List<SaDependiente> ObtenerDependientesCod(string CodUsuario, decimal CodDependiente)
        {
            using (var contexto = new CuotasV100Context())
            {
                var dependiente = contexto.Applogin
                    .Where(l => l.CodUsuario == CodUsuario) // Filtrar por el código de usuario
                    .Join(contexto.Appusuarios, l => l.CodUsuario, u => u.CodUsuario, (l, u) => u) // Unir con la tabla de usuarios
                    .Join(contexto.SaDependientes, u => u.CodTercero, d => d.CodTercero, (u, d) => d) // Unir con la tabla de dependientes
                    .Where(d => d.CodDependiente == CodDependiente) // Filtrar por el código de dependiente utilizando ==
                    .ToList();

                return dependiente;
            }
        }

        public SaDependiente ObtenerDependientesCodOb(string CodUsuario, decimal CodDependiente)
        {
            using (var contexto = new CuotasV100Context())
            {
                var dependien = contexto.Applogin
                    .Where(l => l.CodUsuario == CodUsuario) // Filtrar por el código de usuario
                    .Join(contexto.Appusuarios, l => l.CodUsuario, u => u.CodUsuario, (l, u) => u) // Unir con la tabla de usuarios
                    .Join(contexto.SaDependientes, u => u.CodTercero, d => d.CodTercero, (u, d) => d) // Unir con la tabla de dependientes
                    .Where(d => d.CodDependiente == CodDependiente) // Filtrar por el código de dependiente utilizando ==
                    .FirstOrDefault();

                return dependien;
            }
        }


        /*public SaDependiente ObtenerDependientesDeUsuario(string CodUsuario)
        {
            using (var contexto = new CuotasV100Context())
            {
                var dependientes = contexto.Applogin
                    .Where(l => l.CodUsuario == CodUsuario) // Filtrar por el código de usuario
                    .Join(contexto.Appusuarios, l => l.CodUsuario, u => u.CodUsuario, (l, u) => u) // Unir con la tabla de usuarios
                    .Join(contexto.SaDependientes, u => u.CodTercero, d => d.CodTercero, (u, d) => d)
                    .Where(d => d.CodEstado == "A") // Filtrar por el estado "A"
                    .FirstOrDefault(); // Obtener el primer dependiente que cumple con las condiciones

                return dependientes;
            }*/
    }
    }

    
