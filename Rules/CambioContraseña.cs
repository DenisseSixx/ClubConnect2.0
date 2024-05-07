
/*
using DataManagment.Models;
using Microsoft.EntityFrameworkCore;

namespace Rules
{
    public class CambioContraseña
    {
        public void CambioContrasena(string codUsuario, string nuevaContrasena)
        {
            using (var context = new CuotasV100Context())
                
                    try
                    {
                        var contra = context.Appusuarios.FirstOrDefaultAsync(u => u.CodUsuario == codUsuario);

                        if (contra == null)
                        {
                            return NotFound(); // Devuelve un resultado NotFound si no se encuentra el usuario
                        }

                        contra. = nuevaContrasena; // Actualiza la contraseña del usuario

                         context.SaveChangesAsync(); // Guarda los cambios en la base de datos

                        return NoContent(); // Devuelve un resultado NoContent si la contraseña se actualizó correctamente
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message); // Devuelve un resultado BadRequest con el mensaje de error si ocurre un error inesperado
                    }
                }
}

    }
}
*/