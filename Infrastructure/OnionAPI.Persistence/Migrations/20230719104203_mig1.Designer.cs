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
    [Migration("20230719104203_mig1")]
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
                            Id = new Guid("e56a6df1-a593-410e-8e63-4881babbef95"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4314),
                            Enlem = "",
                            MudurlukAdi = "BALIKESİR",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 1
                        },
                        new
                        {
                            Id = new Guid("f069a5ab-b8a2-43e3-9e97-4ba82a404ebf"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4327),
                            Enlem = "",
                            MudurlukAdi = "EDREMİT",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 2
                        },
                        new
                        {
                            Id = new Guid("470ba793-b22b-4954-83a7-8e1d723c2aca"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4329),
                            Enlem = "",
                            MudurlukAdi = "BANDIRMA",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 3
                        },
                        new
                        {
                            Id = new Guid("d3bdd077-caae-4447-bb0e-cf2f2cd60456"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4331),
                            Enlem = "",
                            MudurlukAdi = "ÇANAKKALE",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 4
                        },
                        new
                        {
                            Id = new Guid("008944b7-54ef-46f1-9747-d4fff4ba6092"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4333),
                            Enlem = "",
                            MudurlukAdi = "BİGA",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 5
                        },
                        new
                        {
                            Id = new Guid("dc34c73a-2142-45c2-8a64-8969a5bf4425"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4335),
                            Enlem = "",
                            MudurlukAdi = "YALOVA",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 6
                        },
                        new
                        {
                            Id = new Guid("3eb10d3e-b1fb-4b99-a81d-4cb433162ec2"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4337),
                            Enlem = "",
                            MudurlukAdi = "OSMANGAZİ",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 7
                        },
                        new
                        {
                            Id = new Guid("09a2ec0c-40ca-4079-9f05-3559f839fc01"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4345),
                            Enlem = "",
                            MudurlukAdi = "GEMLİK",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 8
                        },
                        new
                        {
                            Id = new Guid("e1a4d846-d50a-46f4-aca6-e55d9c39e311"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4347),
                            Enlem = "",
                            MudurlukAdi = "İNEGÖL",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 9
                        },
                        new
                        {
                            Id = new Guid("987e9a29-0623-40bb-8e05-7e77dc11cb3b"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4349),
                            Enlem = "",
                            MudurlukAdi = "M.KEMALPAŞA",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 10
                        },
                        new
                        {
                            Id = new Guid("9962a79a-c29e-40e2-83a3-e18827f4033d"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4350),
                            Enlem = "",
                            MudurlukAdi = "NİLÜFER",
                            MudurlukBolgeKodu = 0,
                            MudurlukKodu = 11
                        },
                        new
                        {
                            Id = new Guid("ea204ea7-0cc8-4538-b752-18dbb4eb5533"),
                            Boylam = "",
                            CreatedDate = new DateTime(2023, 7, 19, 13, 42, 3, 202, DateTimeKind.Local).AddTicks(4352),
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