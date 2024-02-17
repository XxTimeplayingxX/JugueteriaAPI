using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace JugueteriaAPI.MODELS
{
    public class JugueteDetalle
    {
        [Key]
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
    }
}
