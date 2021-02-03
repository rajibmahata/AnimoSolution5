﻿// <auto-generated />
using System;
using AnimoWeb.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimoWeb.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201222151805_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("AnimoWeb.Shared.Firmas", b =>
                {
                    b.Property<int>("FirmaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("TEXT");

                    b.Property<int>("LandeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Logo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("FirmaId");

                    b.HasIndex("LandeId");

                    b.ToTable("Firmas");
                });

            modelBuilder.Entity("AnimoWeb.Shared.Landes", b =>
                {
                    b.Property<int>("LandeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LandeFlag")
                        .HasColumnType("TEXT");

                    b.Property<string>("LandeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LandeShort")
                        .HasColumnType("TEXT");

                    b.HasKey("LandeId");

                    b.ToTable("Landes");
                });

            modelBuilder.Entity("AnimoWeb.Shared.Photos", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhotoName")
                        .HasColumnType("TEXT");

                    b.HasKey("PhotoId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("AnimoWeb.Shared.Roles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleName")
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AnimoWeb.Shared.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Doc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Dol")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("FirmaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobPosition")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobPositionDescription")
                        .HasColumnType("TEXT");

                    b.Property<int>("LandeId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telephone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isBanned")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.HasIndex("FirmaId");

                    b.HasIndex("LandeId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AnimoWeb.Shared.UserPhotos", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PhotoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "PhotoId");

                    b.HasIndex("PhotoId");

                    b.ToTable("UserPhotos");
                });

            modelBuilder.Entity("AnimoWeb.Shared.Firmas", b =>
                {
                    b.HasOne("AnimoWeb.Shared.Landes", "Lande")
                        .WithMany()
                        .HasForeignKey("LandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lande");
                });

            modelBuilder.Entity("AnimoWeb.Shared.User", b =>
                {
                    b.HasOne("AnimoWeb.Shared.Firmas", "Firma")
                        .WithMany()
                        .HasForeignKey("FirmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimoWeb.Shared.Landes", "Lande")
                        .WithMany()
                        .HasForeignKey("LandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimoWeb.Shared.Roles", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firma");

                    b.Navigation("Lande");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AnimoWeb.Shared.UserPhotos", b =>
                {
                    b.HasOne("AnimoWeb.Shared.Photos", "Photo")
                        .WithMany("UserPhotos")
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AnimoWeb.Shared.User", "User")
                        .WithMany("UserPhotos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Photo");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AnimoWeb.Shared.Photos", b =>
                {
                    b.Navigation("UserPhotos");
                });

            modelBuilder.Entity("AnimoWeb.Shared.User", b =>
                {
                    b.Navigation("UserPhotos");
                });
#pragma warning restore 612, 618
        }
    }
}