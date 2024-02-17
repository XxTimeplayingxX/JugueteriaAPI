using System.ComponentModel.DataAnnotations;

namespace JugueteriaAPI.MODELS
{
    public class Juguete
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio{ get; set; }
    }
}
