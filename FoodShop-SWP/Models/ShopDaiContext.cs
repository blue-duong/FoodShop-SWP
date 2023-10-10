using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FoodShop_SWP.Models
{
    public partial class ShopDaiContext : DbContext
    {
        public ShopDaiContext()
        {
        }

        public ShopDaiContext(DbContextOptions<ShopDaiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<CartProduct> CartProducts { get; set; } = null!;
        public virtual DbSet<CategorGroup> CategorGroups { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<CategoryDetailInfo> CategoryDetailInfos { get; set; } = null!;
        public virtual DbSet<Conversation> Conversations { get; set; } = null!;
        public virtual DbSet<ConversationChatter> ConversationChatters { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<FeedbackReply> FeedbackReplies { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<MessageImage> MessageImages { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductDetailInfo> ProductDetailInfos { get; set; } = null!;
        public virtual DbSet<ProductFeedbackImage> ProductFeedbackImages { get; set; } = null!;
        public virtual DbSet<ProductImage> ProductImages { get; set; } = null!;
        public virtual DbSet<ProductSale> ProductSales { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<ReceiveInfo> ReceiveInfos { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<SaleEvent> SaleEvents { get; set; } = null!;
        public virtual DbSet<ShopPackage> ShopPackages { get; set; } = null!;
        public virtual DbSet<ShopPlan> ShopPlans { get; set; } = null!;
        public virtual DbSet<Subscription> Subscriptions { get; set; } = null!;
        public virtual DbSet<Token> Tokens { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<Ward> Wards { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-IL9OFDR\\MAYAO;Initial Catalog=ShopDai;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<CartProduct>(entity =>
            {
                entity.ToTable("CartProduct");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.CartProducts)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK_CartProduct_Cart");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CartProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_CartProduct_Product");
            });

            modelBuilder.Entity<CategorGroup>(entity =>
            {
                entity.ToTable("CategorGroup");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategorGroups)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_CategorGroup_category");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<CategoryDetailInfo>(entity =>
            {
                entity.ToTable("CategoryDetailInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryDetailInfos)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_CategoryDetailInfo_category");
            });

            modelBuilder.Entity<Conversation>(entity =>
            {
                entity.ToTable("Conversation");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<ConversationChatter>(entity =>
            {
                entity.ToTable("ConversationChatter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConversationId).HasColumnName("conversation_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Conversation)
                    .WithMany(p => p.ConversationChatters)
                    .HasForeignKey(d => d.ConversationId)
                    .HasConstraintName("FK_ConversationChatter_Conversation");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ConversationChatters)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ConversationChatter_User");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.ToTable("Feedback");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Processed).HasColumnName("processed");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("reason");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.VideoUrl)
                    .HasMaxLength(255)
                    .HasColumnName("video_url");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Feedback)
                    .HasForeignKey<Feedback>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_ProductFeedbackImage");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Feedback_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Feedback_Product");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Feedback_User");
            });

            modelBuilder.Entity<FeedbackReply>(entity =>
            {
                entity.ToTable("FeedbackReply");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contebt)
                    .HasColumnType("text")
                    .HasColumnName("contebt");

                entity.Property(e => e.FeedbackId).HasColumnName("feedback_id");

                entity.HasOne(d => d.Feedback)
                    .WithMany(p => p.FeedbackReplies)
                    .HasForeignKey(d => d.FeedbackId)
                    .HasConstraintName("FK_FeedbackReply_Feedback");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ConId).HasColumnName("con_id");

                entity.Property(e => e.Content)
                    .HasMaxLength(255)
                    .HasColumnName("content");

                entity.Property(e => e.ConversationId).HasColumnName("conversation_id");

                entity.Property(e => e.SendTime)
                    .HasColumnType("datetime")
                    .HasColumnName("send_time");

                entity.Property(e => e.SenderId).HasColumnName("sender_id");

                entity.Property(e => e.SenderImage)
                    .HasMaxLength(255)
                    .HasColumnName("sender_image");

                entity.Property(e => e.SenderType)
                    .HasMaxLength(255)
                    .HasColumnName("sender_type");

                entity.Property(e => e.Type)
                    .HasMaxLength(255)
                    .HasColumnName("type");

                entity.Property(e => e.Video)
                    .HasMaxLength(255)
                    .HasColumnName("video");

                entity.HasOne(d => d.Conversation)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.ConversationId)
                    .HasConstraintName("FK_message_Conversation");
            });

            modelBuilder.Entity<MessageImage>(entity =>
            {
                entity.ToTable("MessageImage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MessageId).HasColumnName("message_id");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessageImages)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_MessageImage_message");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasMaxLength(255)
                    .HasColumnName("content");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_at");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("image_url");

                entity.Property(e => e.Read).HasColumnName("read");

                entity.Property(e => e.RedirectUrl)
                    .HasMaxLength(255)
                    .HasColumnName("redirect_url");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Notification_User");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.ExpectedReceive)
                    .HasMaxLength(255)
                    .HasColumnName("expected_receive");

                entity.Property(e => e.Payment)
                    .HasMaxLength(255)
                    .HasColumnName("payment");

                entity.Property(e => e.ReceiveInfoId).HasColumnName("receive_info_id");

                entity.Property(e => e.Reported).HasColumnName("reported");

                entity.Property(e => e.SellPrice).HasColumnName("sell_price");

                entity.Property(e => e.ShippingFee).HasColumnName("shipping_fee");

                entity.Property(e => e.SoldPrice).HasColumnName("sold_price");

                entity.Property(e => e.Special).HasColumnName("special");

                entity.Property(e => e.Status)
                    .HasMaxLength(255)
                    .HasColumnName("status");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.ReceiveInfo)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ReceiveInfoId)
                    .HasConstraintName("FK_Order_receive_info");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Order_User");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Feedbacked).HasColumnName("feedbacked");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SellPrice).HasColumnName("sell_price");

                entity.Property(e => e.SoldPrice).HasColumnName("sold_price");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderDetail_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_OrderDetail_Product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Available).HasColumnName("available");

                entity.Property(e => e.Ban).HasColumnName("ban");

                entity.Property(e => e.CategoryGroupId).HasColumnName("category_group_id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Sold).HasColumnName("sold");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time");

                entity.Property(e => e.Video)
                    .HasMaxLength(255)
                    .HasColumnName("video");

                entity.HasOne(d => d.CategoryGroup)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryGroupId)
                    .HasConstraintName("FK_Product_CategorGroup");
            });

            modelBuilder.Entity<ProductDetailInfo>(entity =>
            {
                entity.ToTable("ProductDetailInfo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryDetailId).HasColumnName("category_detail_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value");

                entity.HasOne(d => d.CategoryDetail)
                    .WithMany(p => p.ProductDetailInfos)
                    .HasForeignKey(d => d.CategoryDetailId)
                    .HasConstraintName("FK_ProductDetailInfo_CategoryDetailInfo");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductDetailInfos)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductDetailInfo_Product");
            });

            modelBuilder.Entity<ProductFeedbackImage>(entity =>
            {
                entity.ToTable("ProductFeedbackImage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FeedbackId).HasColumnName("feedback_id");

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.ToTable("productImage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Url)
                    .HasColumnType("text")
                    .HasColumnName("url");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductImages)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_productImage_Product");
            });

            modelBuilder.Entity<ProductSale>(entity =>
            {
                entity.ToTable("ProductSale");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.SaleEventId).HasColumnName("sale_event_id");

                entity.Property(e => e.SaleQuantity).HasColumnName("sale_quantity");

                entity.Property(e => e.Sold).HasColumnName("sold");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSales)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductSale_Product");

                entity.HasOne(d => d.SaleEvent)
                    .WithMany(p => p.ProductSales)
                    .HasForeignKey(d => d.SaleEventId)
                    .HasConstraintName("FK_ProductSale_SaleEvent");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ReceiveInfo>(entity =>
            {
                entity.ToTable("receive_info");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Default)
                    .HasMaxLength(255)
                    .HasColumnName("_default");

                entity.Property(e => e.DistrictId).HasColumnName("district_id");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(255)
                    .HasColumnName("fullname");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");

                entity.Property(e => e.ProvinceId).HasColumnName("province_id");

                entity.Property(e => e.SpecificAddress)
                    .HasMaxLength(255)
                    .HasColumnName("specific_address");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.WardId).HasColumnName("ward_id");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.ReceiveInfos)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_receive_info_District");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.ReceiveInfos)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_receive_info_Province");

                entity.HasOne(d => d.Ward)
                    .WithMany(p => p.ReceiveInfos)
                    .HasForeignKey(d => d.WardId)
                    .HasConstraintName("FK_receive_info_Ward");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .HasColumnName("action");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ReasonSpecified)
                    .HasMaxLength(255)
                    .HasColumnName("reason_specified");

                entity.Property(e => e.ReasonType)
                    .HasMaxLength(255)
                    .HasColumnName("reason_type");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Report_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Report_Product");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Report_User");
            });

            modelBuilder.Entity<SaleEvent>(entity =>
            {
                entity.ToTable("SaleEvent");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Endding)
                    .HasColumnType("datetime")
                    .HasColumnName("endding");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Percent).HasColumnName("percent");

                entity.Property(e => e.Start)
                    .HasColumnType("datetime")
                    .HasColumnName("start");
            });

            modelBuilder.Entity<ShopPackage>(entity =>
            {
                entity.ToTable("ShopPackage");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time");

                entity.Property(e => e.ShopPlanId).HasColumnName("shop_plan_id");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");

                entity.HasOne(d => d.ShopPlan)
                    .WithMany(p => p.ShopPackages)
                    .HasForeignKey(d => d.ShopPlanId)
                    .HasConstraintName("FK_ShopPackage_ShopPlan");
            });

            modelBuilder.Entity<ShopPlan>(entity =>
            {
                entity.ToTable("ShopPlan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Plan)
                    .HasMaxLength(2)
                    .HasColumnName("plan");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.ToTable("Subscription");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.SubscriptionTime)
                    .HasColumnType("datetime")
                    .HasColumnName("subscription_time");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Subscriptions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Subscription_User");
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.ToTable("Token");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ComfirmedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("comfirmed_at");

                entity.Property(e => e.CreateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("create_at");

                entity.Property(e => e.ExpiredAt)
                    .HasColumnType("datetime")
                    .HasColumnName("expired_at");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("value");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Token_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CardId).HasColumnName("card_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Enable)
                    .IsRequired()
                    .HasColumnName("enable")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Firrtname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("firrtname");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("imageURL");

                entity.Property(e => e.IsLockout).HasColumnName("is_lockout");

                entity.Property(e => e.JoinAt)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("join_at");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("lastname");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Timeout)
                    .HasColumnType("datetime")
                    .HasColumnName("timeout");

                entity.Property(e => e.Wallet).HasColumnName("wallet");

                entity.Property(e => e.Wrongpasswordcount).HasColumnName("wrongpasswordcount");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK_User_Cart");
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.ToTable("Ward");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
