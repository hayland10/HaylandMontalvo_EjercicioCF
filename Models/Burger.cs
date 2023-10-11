using System.ComponentModel.DataAnnotations;

namespace HaylandMontalvo_EjercicioCF.Models
{
    public class Burger
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 3.50)]
        public decimal Precio { get; set; }
    }
}
