using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class ReceiveInfo
    {
        public ReceiveInfo()
        {
            Orders = new HashSet<Order>();
        }

        public string? Default { get; set; }
        public string? Fullname { get; set; }
        public string? Phone { get; set; }
        public string? SpecificAddress { get; set; }
        public int? DistrictId { get; set; }
        public int? ProvinceId { get; set; }
        public int? UserId { get; set; }
        public int? WardId { get; set; }
        public int Id { get; set; }

        public virtual District? District { get; set; }
        public virtual Province? Province { get; set; }
        public virtual Ward? Ward { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
