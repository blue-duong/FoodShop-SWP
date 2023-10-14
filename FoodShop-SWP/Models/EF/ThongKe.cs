using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodShop_SWP.Models.EF
{
    [Table("ThongKe")]
    public class ThongKe
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime? ThoiGian { get; set; }
        public long? SoTruyCap { get; set; }
    }
}