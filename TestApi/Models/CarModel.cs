using System.ComponentModel.DataAnnotations;

namespace TestApi.Models
{
    public class CarModel
    {
        [Key]
        public int Id { get; set; }
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string CarClass { get; set; }
        public float Price { get; set; }
    }
}
