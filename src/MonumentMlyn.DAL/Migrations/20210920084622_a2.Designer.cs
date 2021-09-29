﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonumentMlyn.DAL.EF;

namespace MonumentMlyn.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210920084622_a2")]
    partial class a2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Article", b =>
                {
                    b.Property<Guid>("articleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Contents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateArticle")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateArticle")
                        .HasColumnType("datetime2");

                    b.HasKey("articleId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.ArticlePhoto", b =>
                {
                    b.Property<Guid>("articleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArticlearticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PhotoPhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("articleId", "PhotoId");

                    b.HasIndex("ArticlearticleId");

                    b.HasIndex("PhotoPhotoId");

                    b.ToTable("ArticlePhotos");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.ArticleUser", b =>
                {
                    b.Property<Guid>("articleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ArticlearticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("articleId", "IdUser");

                    b.HasIndex("ArticlearticleId");

                    b.HasIndex("UserIdUser");

                    b.ToTable("ArticleUsers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Calculations", b =>
                {
                    b.Property<Guid>("IdWorker")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Advance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NumberOfHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Rete")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("WorkerIdWorker")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdWorker", "Date");

                    b.HasIndex("WorkerIdWorker");

                    b.ToTable("Calculations");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Customer", b =>
                {
                    b.Property<Guid>("id_customer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("create_user")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("update_user")
                        .HasColumnType("datetime2");

                    b.HasKey("id_customer");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Material", b =>
                {
                    b.Property<Guid>("IdMaterial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Appointment")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateMaterial")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Number")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateMaterial")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdMaterial");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.MaterialMonument", b =>
                {
                    b.Property<Guid>("IdMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMonument")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MaterialIdMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MonumentIdMonument")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdMaterial", "IdMonument");

                    b.HasIndex("MaterialIdMaterial");

                    b.HasIndex("MonumentIdMonument");

                    b.ToTable("MaterialMonuments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Monument", b =>
                {
                    b.Property<Guid>("IdMonument")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Customerid_customer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_customer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PhotoPhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdMonument");

                    b.HasIndex("Customerid_customer");

                    b.HasIndex("PhotoPhotoId");

                    b.ToTable("Monuments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.MonumentWorker", b =>
                {
                    b.Property<Guid>("IdMonument")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdWorker")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MonumentIdMonument")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("WorkerIdWorker")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdMonument", "IdWorker");

                    b.HasIndex("MonumentIdMonument");

                    b.HasIndex("WorkerIdWorker");

                    b.ToTable("MonumentWorkers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Photo", b =>
                {
                    b.Property<Guid>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryPhoto")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatePhoto")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("FullPhoto")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("MinyPhoto")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatePhoto")
                        .HasColumnType("datetime2");

                    b.HasKey("PhotoId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Role", b =>
                {
                    b.Property<Guid>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateRole")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateRole")
                        .HasColumnType("datetime2");

                    b.HasKey("IdRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.RoleUser", b =>
                {
                    b.Property<Guid>("IdRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("RoleIdRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdRole", "IdUser");

                    b.HasIndex("RoleIdRole");

                    b.HasIndex("UserIdUser");

                    b.ToTable("RoleUsers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.User", b =>
                {
                    b.Property<Guid>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Worker", b =>
                {
                    b.Property<Guid>("IdWorker")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateWorcer")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateWorker")
                        .HasColumnType("datetime2");

                    b.HasKey("IdWorker");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.ArticlePhoto", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Article", "Article")
                        .WithMany("ArticlePhotos")
                        .HasForeignKey("ArticlearticleId");

                    b.HasOne("MonumentMlyn.DAL.Entities.Photo", "Photo")
                        .WithMany("ArticlePhotos")
                        .HasForeignKey("PhotoPhotoId");

                    b.Navigation("Article");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.ArticleUser", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Article", "Article")
                        .WithMany("ArticleUsers")
                        .HasForeignKey("ArticlearticleId");

                    b.HasOne("MonumentMlyn.DAL.Entities.User", "User")
                        .WithMany("Article")
                        .HasForeignKey("UserIdUser");

                    b.Navigation("Article");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Calculations", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Worker", "Worker")
                        .WithMany("Calculations")
                        .HasForeignKey("WorkerIdWorker");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.MaterialMonument", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Material", "Material")
                        .WithMany("MaterialMonuments")
                        .HasForeignKey("MaterialIdMaterial");

                    b.HasOne("MonumentMlyn.DAL.Entities.Monument", "Monument")
                        .WithMany("MaterialMonuments")
                        .HasForeignKey("MonumentIdMonument");

                    b.Navigation("Material");

                    b.Navigation("Monument");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Monument", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Customer", null)
                        .WithMany("Monuments")
                        .HasForeignKey("Customerid_customer");

                    b.HasOne("MonumentMlyn.DAL.Entities.Photo", "Photo")
                        .WithMany("Monument")
                        .HasForeignKey("PhotoPhotoId");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.MonumentWorker", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Monument", "Monument")
                        .WithMany("MonumentWorkers")
                        .HasForeignKey("MonumentIdMonument");

                    b.HasOne("MonumentMlyn.DAL.Entities.Worker", "Worker")
                        .WithMany("MonumentWorkers")
                        .HasForeignKey("WorkerIdWorker");

                    b.Navigation("Monument");

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.RoleUser", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Role", "Role")
                        .WithMany("RoleUsers")
                        .HasForeignKey("RoleIdRole");

                    b.HasOne("MonumentMlyn.DAL.Entities.User", "User")
                        .WithMany("RoleUsers")
                        .HasForeignKey("UserIdUser");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Article", b =>
                {
                    b.Navigation("ArticlePhotos");

                    b.Navigation("ArticleUsers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Customer", b =>
                {
                    b.Navigation("Monuments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Material", b =>
                {
                    b.Navigation("MaterialMonuments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Monument", b =>
                {
                    b.Navigation("MaterialMonuments");

                    b.Navigation("MonumentWorkers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Photo", b =>
                {
                    b.Navigation("ArticlePhotos");

                    b.Navigation("Monument");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Role", b =>
                {
                    b.Navigation("RoleUsers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.User", b =>
                {
                    b.Navigation("Article");

                    b.Navigation("RoleUsers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Worker", b =>
                {
                    b.Navigation("Calculations");

                    b.Navigation("MonumentWorkers");
                });
#pragma warning restore 612, 618
        }
    }
}