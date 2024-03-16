
namespace DataManagment.Models
{
    public partial class Apprespuestaautenticacion
    {
        public string token { get; set; }
        public DateTime expiracion { get; set; }

        public string CodUsuario { get; set; } = null!;
    }
}
