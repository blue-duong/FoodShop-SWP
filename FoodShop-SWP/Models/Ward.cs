using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Ward
    {
        public Ward()
        {
            ReceiveInfos = new HashSet<ReceiveInfo>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<ReceiveInfo> ReceiveInfos { get; set; }
    }
}
