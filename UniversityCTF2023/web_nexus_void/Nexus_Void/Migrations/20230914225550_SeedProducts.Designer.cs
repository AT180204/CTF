﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nexus_Void.Helpers;

#nullable disable

namespace Nexus_Void.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230914225550_SeedProducts")]
    partial class SeedProducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Nexus_Void.Models.ProductModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("backdropImage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("currentBid")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("endingIn")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sellerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            backdropImage = "/images/back1.png",
                            currentBid = "45 ETH",
                            endingIn = "10 Days",
                            image = "/images/weapon.png",
                            name = "Shadowcaster MK VI",
                            sellerName = "Xclow3n"
                        },
                        new
                        {
                            ID = 2,
                            backdropImage = "/images/back2.png",
                            currentBid = "25 ETH",
                            endingIn = "2 Days",
                            image = "/images/blade.png",
                            name = "Vortex Edgeblade",
                            sellerName = "Xclow3n"
                        },
                        new
                        {
                            ID = 3,
                            backdropImage = "/images/back3.png",
                            currentBid = "50 ETH",
                            endingIn = "3 Days",
                            image = "/images/hand.png",
                            name = "TechSinergi Cyberlimb",
                            sellerName = "Xclow3n"
                        },
                        new
                        {
                            ID = 4,
                            backdropImage = "/images/back4.png",
                            currentBid = "100 ETH",
                            endingIn = "7 Days",
                            image = "/images/grenade.png",
                            name = "Serum XY Scourgecaster",
                            sellerName = "Xclow3n"
                        },
                        new
                        {
                            ID = 5,
                            backdropImage = "/images/back5.png",
                            currentBid = "99 ETH",
                            endingIn = "4 Days",
                            image = "/images/something.png",
                            name = "NeuroHack Cortex Gear",
                            sellerName = "Xclow3n"
                        },
                        new
                        {
                            ID = 6,
                            backdropImage = "/images/back6.png",
                            currentBid = "1337 ETH",
                            endingIn = "3 Days",
                            image = "/images/breach.png",
                            name = "NeuroLink Intrusion Node",
                            sellerName = "Xclow3n"
                        });
                });

            modelBuilder.Entity("Nexus_Void.Models.UserModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
