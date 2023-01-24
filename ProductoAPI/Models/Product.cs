using System.ComponentModel.DataAnnotations;

namespace ProductAPI
{
    public class Product
    {
        public int Id { get; set; }
        
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

    }
}
