using System;
using System.Collections.Generic;

namespace FoodShop_SWP.Models
{
    public partial class Product
    {
        public Product()
        {
            CartProducts = new HashSet<CartProduct>();
            Feedbacks = new HashSet<Feedback>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductDetailInfos = new HashSet<ProductDetailInfo>();
            ProductImages = new HashSet<ProductImage>();
            ProductSales = new HashSet<ProductSale>();
            Reports = new HashSet<Report>();
        }

        public int? Available { get; set; }
        public bool? Ban { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public long? Price { get; set; }
        public long? Rating { get; set; }
        public int? Sold { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string? Video { get; set; }
        public int? CategoryGroupId { get; set; }
        public int Id { get; set; }

        public virtual CategorGroup? CategoryGroup { get; set; }
        public virtual ICollection<CartProduct> CartProducts { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductDetailInfo> ProductDetailInfos { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<ProductSale> ProductSales { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
