﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnionAPI.Persistence.Contexts;

#nullable disable

namespace OnionAPI.Persistence.Migrations
{
    [DbContext(typeof(OnionAPIDbContext))]
    [Migration("20230714115329_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OnionAPI.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OnionAPI.Domain.Entities.Identity.AppRole", b =>
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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("OnionAPI.Domain.Entities.Identity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("OnionAPI.Domain.Entities.Mudurluk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Boylam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Enlem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MudurlukAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MudurlukBolgeKodu")
                        .HasColumnType("int");

                    b.Property<int>("MudurlukKodu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Mudurlukler");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ca3553a6-72c7-4b07-97e6-1faa3dea5787"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3018),
                            Enlem = "",
                            MudurlukAdi = "BALIKESİR",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 1
                        },
                        new
                        {
                            Id = new Guid("ef9b4222-1e98-41aa-b25e-4ee4d7b55376"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3029),
                            Enlem = "",
                            MudurlukAdi = "EDREMİT",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 2
                        },
                        new
                        {
                            Id = new Guid("481c955b-c366-4794-b976-23d91d3d86b2"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3031),
                            Enlem = "",
                            MudurlukAdi = "BANDIRMA",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 3
                        },
                        new
                        {
                            Id = new Guid("97da8941-ed81-4206-b4e4-1139c79f2399"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3042),
                            Enlem = "",
                            MudurlukAdi = "ÇANAKKALE",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 4
                        },
                        new
                        {
                            Id = new Guid("4d6746a7-89cf-4239-ac87-bda3e2f2a530"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3044),
                            Enlem = "",
                            MudurlukAdi = "BİGA",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 5
                        },
                        new
                        {
                            Id = new Guid("30c3be1a-4ea4-4389-b7e4-8a8775c8a0e6"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3045),
                            Enlem = "",
                            MudurlukAdi = "YALOVA",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 6
                        },
                        new
                        {
                            Id = new Guid("0e3ec415-db8a-4c48-b4e8-8316e2274793"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3047),
                            Enlem = "",
                            MudurlukAdi = "OSMANGAZİ",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 7
                        },
                        new
                        {
                            Id = new Guid("c85c3e3c-c92b-4a08-aed7-9e61e0e20e55"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3048),
                            Enlem = "",
                            MudurlukAdi = "GEMLİK",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 8
                        },
                        new
                        {
                            Id = new Guid("089352de-7d9b-43e7-b2a3-5c3080ae6906"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3050),
                            Enlem = "",
                            MudurlukAdi = "İNEGÖL",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 9
                        },
                        new
                        {
                            Id = new Guid("5a0661fc-362b-45ef-b57b-ad96eacdb8cc"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3052),
                            Enlem = "",
                            MudurlukAdi = "M.KEMALPAŞA",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 10
                        },
                        new
                        {
                            Id = new Guid("43ea8fd7-75c7-4a79-b3c0-d65bb133a3f8"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3053),
                            Enlem = "",
                            MudurlukAdi = "NİLÜFER",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 11
                        },
                        new
                        {
                            Id = new Guid("58884325-de0e-4e83-a126-9de638521d0e"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 14, 14, 53, 29, 436, DateTimeKind.Local).AddTicks(3057),
                            Enlem = "",
                            MudurlukAdi = "YILDIRIM",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 12
                        });
                });

            modelBuilder.Entity("OnionAPI.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<Guid>("CustomerId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Description")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnionAPI.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<Guid>("OrdersId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrdersId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("OnionAPI.Domain.Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OnionAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnionAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("OnionAPI.Domain.Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnionAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OnionAPI.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnionAPI.Domain.Entities.Order", b =>
                {
                    b.HasOne("OnionAPI.Domain.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("OnionAPI.Domain.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnionAPI.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnionAPI.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
