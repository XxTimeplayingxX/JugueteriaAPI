using System.ComponentModel.DataAnnotations;

namespace JugueteriaAPI.MODELS
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

    }
}
