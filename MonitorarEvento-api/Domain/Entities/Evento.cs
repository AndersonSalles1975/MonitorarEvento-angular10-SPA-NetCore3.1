

using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Evento : BaseEntity
    {
        [Required]
        public double Timestamp { get; set; }
        [Required]
        public string Tag { get; set; }
        [Required]
        public string Valor { get; set; }
        
    }

}
