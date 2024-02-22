
namespace Objects
{
    public class Fotografias { 
    
        public int IdFotografia {  get; set; }
        public byte[] FotoMiembro { get; set; }
        public byte[] FotoMiniatura { get; set; }
        public DateTime FechaActualizacion { get; set; }

        public string CodTercero { set; get; }


    }
}
