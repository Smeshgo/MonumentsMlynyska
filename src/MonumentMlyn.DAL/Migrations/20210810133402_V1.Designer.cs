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
    [Migration("20210810133402_V1")]
    partial class V1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArticlePhoto", b =>
                {
                    b.Property<Guid>("ArticlesIdArticle")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PhotoIdPhoto")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ArticlesIdArticle", "PhotoIdPhoto");

                    b.HasIndex("PhotoIdPhoto");

                    b.ToTable("ArticlePhoto");
                });

            modelBuilder.Entity("ArticleUser", b =>
                {
                    b.Property<Guid>("ArticlesIdArticle")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ArticlesIdArticle", "UserIdUser");

                    b.HasIndex("UserIdUser");

                    b.ToTable("ArticleUser");
                });

            modelBuilder.Entity("MaterialMonument", b =>
                {
                    b.Property<Guid>("MaterialsIdMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MonumentsIdMonument")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MaterialsIdMaterial", "MonumentsIdMonument");

                    b.HasIndex("MonumentsIdMonument");

                    b.ToTable("MaterialMonument");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Appointment", b =>
                {
                    b.Property<Guid>("IdAppointment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAppointment")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAppointment");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Article", b =>
                {
                    b.Property<Guid>("IdArticle")
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

                    b.HasKey("IdArticle");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.CategoryMaterial", b =>
                {
                    b.Property<Guid>("IdCategoryMaterial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateCategoryMaterial")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategoryMaterial");

                    b.ToTable("CategoryMaterials");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.CategoryPhoto", b =>
                {
                    b.Property<Guid>("IdCategoryPhoto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatePhotoPhoto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateCategoryPhoto")
                        .HasColumnType("datetime2");

                    b.HasKey("IdCategoryPhoto");

                    b.ToTable("CategoryPhotos");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Material", b =>
                {
                    b.Property<Guid>("IdMaterial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AppointmentIdAppointment")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryMaterialIdCategoryMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateMaterial")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("IdAppointment")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCategoryMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Number")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdMaterial");

                    b.HasIndex("AppointmentIdAppointment");

                    b.HasIndex("CategoryMaterialIdCategoryMaterial");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Monument", b =>
                {
                    b.Property<Guid>("IdMonument")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPhoto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_customer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PhotoIdPhoto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Prise")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("Сustomerid_customer")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdMonument");

                    b.HasIndex("PhotoIdPhoto");

                    b.HasIndex("Сustomerid_customer");

                    b.ToTable("Monuments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Photo", b =>
                {
                    b.Property<Guid>("IdPhoto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryPhotoIdCategoryPhoto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatePhoto")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdCategoryPhoto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathFull")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathMini")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatePhoto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Uuid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPhoto");

                    b.HasIndex("CategoryPhotoIdCategoryPhoto");

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

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.User", b =>
                {
                    b.Property<Guid>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

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

                    b.Property<DateTime>("Update")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usernama")
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

                    b.Property<decimal>("NumberOfHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rete")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateWorker")
                        .HasColumnType("datetime2");

                    b.HasKey("IdWorker");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Сustomer", b =>
                {
                    b.Property<Guid>("id_customer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("create_user")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("update_user")
                        .HasColumnType("datetime2");

                    b.HasKey("id_customer");

                    b.ToTable("Сustomers");
                });

            modelBuilder.Entity("MonumentWorker", b =>
                {
                    b.Property<Guid>("MonumentsIdMonument")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkersIdWorker")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MonumentsIdMonument", "WorkersIdWorker");

                    b.HasIndex("WorkersIdWorker");

                    b.ToTable("MonumentWorker");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<Guid>("RolesIdRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RolesIdRole", "UsersIdUser");

                    b.HasIndex("UsersIdUser");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("ArticlePhoto", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesIdArticle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentMlyn.DAL.Entities.Photo", null)
                        .WithMany()
                        .HasForeignKey("PhotoIdPhoto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleUser", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesIdArticle")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentMlyn.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MaterialMonument", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Material", null)
                        .WithMany()
                        .HasForeignKey("MaterialsIdMaterial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentMlyn.DAL.Entities.Monument", null)
                        .WithMany()
                        .HasForeignKey("MonumentsIdMonument")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Material", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Appointment", "Appointment")
                        .WithMany("Materials")
                        .HasForeignKey("AppointmentIdAppointment");

                    b.HasOne("MonumentMlyn.DAL.Entities.CategoryMaterial", "CategoryMaterial")
                        .WithMany("Materials")
                        .HasForeignKey("CategoryMaterialIdCategoryMaterial");

                    b.Navigation("Appointment");

                    b.Navigation("CategoryMaterial");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Monument", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Photo", "Photo")
                        .WithMany("Monuments")
                        .HasForeignKey("PhotoIdPhoto");

                    b.HasOne("MonumentMlyn.DAL.Entities.Сustomer", null)
                        .WithMany("Monuments")
                        .HasForeignKey("Сustomerid_customer");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Photo", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.CategoryPhoto", "CategoryPhoto")
                        .WithMany("Photos")
                        .HasForeignKey("CategoryPhotoIdCategoryPhoto");

                    b.Navigation("CategoryPhoto");
                });

            modelBuilder.Entity("MonumentWorker", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Monument", null)
                        .WithMany()
                        .HasForeignKey("MonumentsIdMonument")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentMlyn.DAL.Entities.Worker", null)
                        .WithMany()
                        .HasForeignKey("WorkersIdWorker")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesIdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentMlyn.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Appointment", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.CategoryMaterial", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.CategoryPhoto", b =>
                {
                    b.Navigation("Photos");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Photo", b =>
                {
                    b.Navigation("Monuments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Сustomer", b =>
                {
                    b.Navigation("Monuments");
                });
#pragma warning restore 612, 618
        }
    }
}
