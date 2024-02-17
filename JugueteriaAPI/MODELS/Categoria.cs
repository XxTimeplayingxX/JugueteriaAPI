using System.ComponentModel.DataAnnotations;

namespace JugueteriaAPI.MODELS
{
    public class Categoria
    {
        [Key]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int JugueteID { get; set; }
        public Juguete Juguete { get; set; }
    }
}
