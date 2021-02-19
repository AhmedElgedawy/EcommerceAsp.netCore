﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyEcommerce.Models;

namespace MyEcommerce.Migrations
{
    [DbContext(typeof(EcommerceWebsiteContext))]
    [Migration("20210118195055_UserTableAddColumnPasswordNotHashed2")]
    partial class UserTableAddColumnPasswordNotHashed2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Domains.TbBusniessInfo", b =>
                {
                    b.Property<int>("BusinessInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("BusinessCardNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("CutomerId")
                        .HasColumnType("int");

                    b.Property<string>("OfficePhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BusinessInfoId");

                    b.HasIndex(new[] { "CutomerId" }, "IX_TbBusniessInfo_CutomerId")
                        .IsUnique();

                    b.ToTable("TbBusniessInfo");
                });

            modelBuilder.Entity("Domains.TbCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("TbCategories");
                });

            modelBuilder.Entity("Domains.TbCusomerItem", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("ItemId", "CustomerId");

                    b.HasIndex(new[] { "CustomerId" }, "IX_TbCusomerItems_CustomerId");

                    b.ToTable("TbCusomerItems");
                });

            modelBuilder.Entity("Domains.TbCustomer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomerId");

                    b.ToTable("TbCustomers");
                });

            modelBuilder.Entity("Domains.TbItem", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("('2020-09-20T00:00:00.0000000')");

                    b.Property<string>("ImageName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.ToTable("TbItems");
                });

            modelBuilder.Entity("Domains.TbItemDiscount", b =>
                {
                    b.Property<int>("ItemDiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("ItemDiscountId");

                    b.HasIndex(new[] { "ItemId" }, "IX_TbItemDiscount_ItemId");

                    b.ToTable("TbItemDiscount");
                });

            modelBuilder.Entity("Domains.TbItemImage", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("ImageId");

                    b.HasIndex("ItemId");

                    b.ToTable("TbItemImages");
                });

            modelBuilder.Entity("Domains.TbPurchaseInvoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("InvoiceDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceId");

                    b.HasIndex("SupplierId");

                    b.ToTable("TbPurchaseInvoices");
                });

            modelBuilder.Entity("Domains.TbPurchaseInvoiceItem", b =>
                {
                    b.Property<int>("InvoiceItemId")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("InvoicePrice")
                        .HasColumnType("decimal(8,4)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Qty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("InvoiceItemId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ItemId");

                    b.ToTable("TbPurchaseInvoiceItems");
                });

            modelBuilder.Entity("Domains.TbSalesInvoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DelivryDate")
                        .HasColumnType("datetime");

                    b.Property<int>("DelivryManId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoiceDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvoiceId");

                    b.HasIndex("CustomerId");

                    b.ToTable("TbSalesInvoices");
                });

            modelBuilder.Entity("Domains.TbSalesInvoiceItem", b =>
                {
                    b.Property<int>("InvoiceItemId")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("InvoicePrice")
                        .HasColumnType("decimal(8,4)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Qty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("InvoiceItemId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ItemId");

                    b.ToTable("TbSalesInvoiceItems");
                });

            modelBuilder.Entity("Domains.TbSlider", b =>
                {
                    b.Property<int>("SilderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("SilderId");

                    b.ToTable("TbSlider");
                });

            modelBuilder.Entity("Domains.TbSupplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SupplierId")
                        .HasName("PK_TbSupplier");

                    b.ToTable("TbSuppliers");
                });

            modelBuilder.Entity("Domains.VwItemCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(8,2)");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(8,2)");

                    b.ToView("VwItemCategories");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyEcommerce.Models.MyUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Domains.TbBusniessInfo", b =>
                {
                    b.HasOne("Domains.TbCustomer", "Cutomer")
                        .WithOne("TbBusniessInfo")
                        .HasForeignKey("Domains.TbBusniessInfo", "CutomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cutomer");
                });

            modelBuilder.Entity("Domains.TbCusomerItem", b =>
                {
                    b.HasOne("Domains.TbCustomer", "Customer")
                        .WithMany("TbCusomerItems")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domains.TbItem", "Item")
                        .WithMany("TbCusomerItems")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Domains.TbItem", b =>
                {
                    b.HasOne("Domains.TbCategory", "Category")
                        .WithMany("TbItems")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_TbItems_TbCategories")
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domains.TbItemDiscount", b =>
                {
                    b.HasOne("Domains.TbItem", "Item")
                        .WithMany("TbItemDiscounts")
                        .HasForeignKey("ItemId")
                        .HasConstraintName("FK_TbItemDiscounts_TbItems")
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Domains.TbItemImage", b =>
                {
                    b.HasOne("Domains.TbItem", "Item")
                        .WithMany("TbItemImages")
                        .HasForeignKey("ItemId")
                        .HasConstraintName("FK_TbItemImages_TbItems")
                        .IsRequired();

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Domains.TbPurchaseInvoice", b =>
                {
                    b.HasOne("Domains.TbSupplier", "Supplier")
                        .WithMany("TbPurchaseInvoices")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("FK_TbPurchaseInvoices_TbSuppliers")
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Domains.TbPurchaseInvoiceItem", b =>
                {
                    b.HasOne("Domains.TbPurchaseInvoice", "Invoice")
                        .WithMany("TbPurchaseInvoiceItems")
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("FK_TbPurchaseInvoiceItems_TbPurchaseInvoices")
                        .IsRequired();

                    b.HasOne("Domains.TbItem", "Item")
                        .WithMany("TbPurchaseInvoiceItems")
                        .HasForeignKey("ItemId")
                        .HasConstraintName("FK_TbPurchaseInvoiceItems_TbItems")
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Domains.TbSalesInvoice", b =>
                {
                    b.HasOne("Domains.TbCustomer", "Customer")
                        .WithMany("TbSalesInvoices")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_TbSalesInvoices_TbCustomers")
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domains.TbSalesInvoiceItem", b =>
                {
                    b.HasOne("Domains.TbSalesInvoice", "Invoice")
                        .WithMany("TbSalesInvoiceItems")
                        .HasForeignKey("InvoiceId")
                        .HasConstraintName("FK_TbSalesInvoiceItems_TbSalesInvoices")
                        .IsRequired();

                    b.HasOne("Domains.TbItem", "Item")
                        .WithMany("TbSalesInvoiceItems")
                        .HasForeignKey("ItemId")
                        .HasConstraintName("FK_TbSalesInvoiceItems_TbItems")
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MyEcommerce.Models.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MyEcommerce.Models.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyEcommerce.Models.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MyEcommerce.Models.MyUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domains.TbCategory", b =>
                {
                    b.Navigation("TbItems");
                });

            modelBuilder.Entity("Domains.TbCustomer", b =>
                {
                    b.Navigation("TbBusniessInfo");

                    b.Navigation("TbCusomerItems");

                    b.Navigation("TbSalesInvoices");
                });

            modelBuilder.Entity("Domains.TbItem", b =>
                {
                    b.Navigation("TbCusomerItems");

                    b.Navigation("TbItemDiscounts");

                    b.Navigation("TbItemImages");

                    b.Navigation("TbPurchaseInvoiceItems");

                    b.Navigation("TbSalesInvoiceItems");
                });

            modelBuilder.Entity("Domains.TbPurchaseInvoice", b =>
                {
                    b.Navigation("TbPurchaseInvoiceItems");
                });

            modelBuilder.Entity("Domains.TbSalesInvoice", b =>
                {
                    b.Navigation("TbSalesInvoiceItems");
                });

            modelBuilder.Entity("Domains.TbSupplier", b =>
                {
                    b.Navigation("TbPurchaseInvoices");
                });
#pragma warning restore 612, 618
        }
    }
}
