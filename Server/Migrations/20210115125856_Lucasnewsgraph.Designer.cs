﻿// <auto-generated />
using System;
using AnimoWeb.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimoWeb.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210115125856_Lucasnewsgraph")]
    partial class Lucasnewsgraph
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Model.Shared.Downloads", b =>
                {
                    b.Property<int>("DownloadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Dlu")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Doc")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("MimeTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isPassworded")
                        .HasColumnType("INTEGER");

                    b.HasKey("DownloadId");

                    b.HasIndex("MimeTypeId");

                    b.ToTable("Downloads");
                });

            modelBuilder.Entity("Model.Shared.Entities.GlobalLocations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("LandeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LocationReference")
                        .HasColumnType("TEXT");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone2")
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetFull")
                        .HasColumnType("TEXT");

                    b.Property<string>("Town")
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isAcive")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LandeId");

                    b.ToTable("GlobalLocations");
                });

            modelBuilder.Entity("Model.Shared.Firmas", b =>
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

                    b.Property<string>("Town")
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isActive")
                        .HasColumnType("INTEGER");

                    b.HasKey("FirmaId");

                    b.HasIndex("LandeId");

                    b.ToTable("Firmas");
                });

            modelBuilder.Entity("Model.Shared.GlobalConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirmaHost")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaLegalName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaSmtp")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaSmtpPass")
                        .HasColumnType("TEXT");

                    b.Property<int>("FirmaSmtpPort")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirmaSmtpUser")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaWeb")
                        .HasColumnType("TEXT");

                    b.Property<int>("LandeId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isPublished")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("GlobalConfig");
                });

            modelBuilder.Entity("Model.Shared.Graphs", b =>
                {
                    b.Property<int>("GraphId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GraphName")
                        .HasColumnType("TEXT");

                    b.Property<string>("GraphUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("GraphId");

                    b.ToTable("Graphs");
                });

            modelBuilder.Entity("Model.Shared.Images", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageFile")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .HasColumnType("TEXT");

                    b.Property<int>("order")
                        .HasColumnType("INTEGER");

                    b.HasKey("ImageId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Model.Shared.Landes", b =>
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

            modelBuilder.Entity("Model.Shared.Logos", b =>
                {
                    b.Property<int>("LogoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LogoFile")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LogoName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("isDefaultActive")
                        .HasColumnType("INTEGER");

                    b.HasKey("LogoId");

                    b.ToTable("Logos");
                });

            modelBuilder.Entity("Model.Shared.MimeType", b =>
                {
                    b.Property<int>("MimeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MimeTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MimeTypeId");

                    b.ToTable("MimeTypes");
                });

            modelBuilder.Entity("Model.Shared.News", b =>
                {
                    b.Property<int>("NewsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT");

                    b.Property<int>("Clicks")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Dlu")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Doc")
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("PosterImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tags")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isActive")
                        .HasColumnType("INTEGER");

                    b.HasKey("NewsId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Model.Shared.NewsGraphs", b =>
                {
                    b.Property<int>("NewsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GraphId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("NewsId", "GraphId");

                    b.HasIndex("GraphId");

                    b.ToTable("NewsGraphs");
                });

            modelBuilder.Entity("Model.Shared.Photos", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhotoName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("PhotoId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Model.Shared.ProjectImages", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ImageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjectId", "ImageId");

                    b.HasIndex("ImageId");

                    b.ToTable("ProjectImages");
                });

            modelBuilder.Entity("Model.Shared.ProjectTecnos", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TecnoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjectId", "TecnoId");

                    b.HasIndex("TecnoId");

                    b.ToTable("ProjectTecnos");
                });

            modelBuilder.Entity("Model.Shared.Projects", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Dlu")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Doc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("KundeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Poster")
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoUrl1")
                        .HasColumnType("TEXT");

                    b.Property<string>("VideoUrl2")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isInternational")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isRestAustria")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isVorarlberg")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Model.Shared.Roles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Model.Shared.Social", b =>
                {
                    b.Property<int>("SocialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocialIconUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("SocialId");

                    b.ToTable("Socials");
                });

            modelBuilder.Entity("Model.Shared.SocialLinks", b =>
                {
                    b.Property<int>("SocialId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GlobalConfigId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SocialUrlTarget")
                        .HasColumnType("TEXT");

                    b.HasKey("SocialId", "GlobalConfigId");

                    b.HasIndex("GlobalConfigId");

                    b.ToTable("SocialLinks");
                });

            modelBuilder.Entity("Model.Shared.Tecnos", b =>
                {
                    b.Property<int>("TecnoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TecnoName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TecnoId");

                    b.ToTable("Tecnos");
                });

            modelBuilder.Entity("Model.Shared.UserPhotos", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PhotoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "PhotoId");

                    b.HasIndex("PhotoId");

                    b.ToTable("UserPhotos");
                });

            modelBuilder.Entity("Model.Shared.Users", b =>
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
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("FirmaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobPosition")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobPositionDescription")
                        .HasColumnType("TEXT");

                    b.Property<int>("LandeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserPoster")
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

            modelBuilder.Entity("Model.Shared.Downloads", b =>
                {
                    b.HasOne("Model.Shared.MimeType", "MimeType")
                        .WithMany()
                        .HasForeignKey("MimeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MimeType");
                });

            modelBuilder.Entity("Model.Shared.Entities.GlobalLocations", b =>
                {
                    b.HasOne("Model.Shared.Landes", "Lande")
                        .WithMany()
                        .HasForeignKey("LandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lande");
                });

            modelBuilder.Entity("Model.Shared.Firmas", b =>
                {
                    b.HasOne("Model.Shared.Landes", "Lande")
                        .WithMany()
                        .HasForeignKey("LandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lande");
                });

            modelBuilder.Entity("Model.Shared.NewsGraphs", b =>
                {
                    b.HasOne("Model.Shared.Graphs", "Graph")
                        .WithMany()
                        .HasForeignKey("GraphId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Shared.News", "New")
                        .WithMany("NewsGraphs")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Graph");

                    b.Navigation("New");
                });

            modelBuilder.Entity("Model.Shared.ProjectImages", b =>
                {
                    b.HasOne("Model.Shared.Images", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Shared.Projects", "Project")
                        .WithMany("ProjectImages")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Model.Shared.ProjectTecnos", b =>
                {
                    b.HasOne("Model.Shared.Projects", "Project")
                        .WithMany("ProjectTecnos")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Shared.Tecnos", "Tecno")
                        .WithMany()
                        .HasForeignKey("TecnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Tecno");
                });

            modelBuilder.Entity("Model.Shared.SocialLinks", b =>
                {
                    b.HasOne("Model.Shared.GlobalConfig", "GlobalConfig")
                        .WithMany("SocialLinks")
                        .HasForeignKey("GlobalConfigId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Shared.Social", "Social")
                        .WithMany()
                        .HasForeignKey("SocialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GlobalConfig");

                    b.Navigation("Social");
                });

            modelBuilder.Entity("Model.Shared.UserPhotos", b =>
                {
                    b.HasOne("Model.Shared.Photos", "Photo")
                        .WithMany("UserPhotos")
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Shared.Users", "User")
                        .WithMany("UserPhotos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Photo");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Model.Shared.Users", b =>
                {
                    b.HasOne("Model.Shared.Firmas", "Firma")
                        .WithMany()
                        .HasForeignKey("FirmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Shared.Landes", "Lande")
                        .WithMany()
                        .HasForeignKey("LandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Shared.Roles", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firma");

                    b.Navigation("Lande");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Model.Shared.GlobalConfig", b =>
                {
                    b.Navigation("SocialLinks");
                });

            modelBuilder.Entity("Model.Shared.News", b =>
                {
                    b.Navigation("NewsGraphs");
                });

            modelBuilder.Entity("Model.Shared.Photos", b =>
                {
                    b.Navigation("UserPhotos");
                });

            modelBuilder.Entity("Model.Shared.Projects", b =>
                {
                    b.Navigation("ProjectImages");

                    b.Navigation("ProjectTecnos");
                });

            modelBuilder.Entity("Model.Shared.Users", b =>
                {
                    b.Navigation("UserPhotos");
                });
#pragma warning restore 612, 618
        }
    }
}
