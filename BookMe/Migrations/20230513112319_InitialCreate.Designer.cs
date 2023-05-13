﻿// <auto-generated />
using System;
using BookMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookMe.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230513112319_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookMe.Models.Auteur", b =>
                {
                    b.Property<int>("AuteurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuteurId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationalitie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuteurId");

                    b.ToTable("Auteurs");
                });

            modelBuilder.Entity("BookMe.Models.AuteurLivre", b =>
                {
                    b.Property<int>("AuteurId")
                        .HasColumnType("int");

                    b.Property<int>("LivreId")
                        .HasColumnType("int");

                    b.HasKey("AuteurId", "LivreId");

                    b.HasIndex("LivreId");

                    b.ToTable("AuteurLivres");
                });

            modelBuilder.Entity("BookMe.Models.Copie", b =>
                {
                    b.Property<int>("CopieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CopieId"));

                    b.Property<string>("Edition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Etat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LivreId")
                        .HasColumnType("int");

                    b.HasKey("CopieId");

                    b.HasIndex("LivreId");

                    b.ToTable("Copies");
                });

            modelBuilder.Entity("BookMe.Models.Livre", b =>
                {
                    b.Property<int>("LivreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LivreId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pagesNumbers")
                        .HasColumnType("int");

                    b.HasKey("LivreId");

                    b.ToTable("Livres");
                });

            modelBuilder.Entity("BookMe.Models.LivreTheme", b =>
                {
                    b.Property<int>("LivreId")
                        .HasColumnType("int");

                    b.Property<int>("ThemeId")
                        .HasColumnType("int");

                    b.HasKey("LivreId", "ThemeId");

                    b.HasIndex("ThemeId");

                    b.ToTable("LivreThemes");
                });

            modelBuilder.Entity("BookMe.Models.Theme", b =>
                {
                    b.Property<int>("ThemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ThemeId"));

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ThemeId");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("BookMe.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookMe.Models.UserCopie", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("CopieId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateDePret")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeRendre")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatePrevusRendre")
                        .HasColumnType("datetime2");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.HasKey("UserId", "CopieId");

                    b.HasIndex("CopieId");

                    b.ToTable("UserCopies");
                });

            modelBuilder.Entity("BookMe.Models.AuteurLivre", b =>
                {
                    b.HasOne("BookMe.Models.Auteur", "Auteur")
                        .WithMany("AuteurLivres")
                        .HasForeignKey("AuteurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookMe.Models.Livre", "Livre")
                        .WithMany("AuteurLivres")
                        .HasForeignKey("LivreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auteur");

                    b.Navigation("Livre");
                });

            modelBuilder.Entity("BookMe.Models.Copie", b =>
                {
                    b.HasOne("BookMe.Models.Livre", "Livre")
                        .WithMany("Copies")
                        .HasForeignKey("LivreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");
                });

            modelBuilder.Entity("BookMe.Models.LivreTheme", b =>
                {
                    b.HasOne("BookMe.Models.Livre", "Livre")
                        .WithMany("LivreThemes")
                        .HasForeignKey("LivreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookMe.Models.Theme", "Theme")
                        .WithMany("LivreThemes")
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("BookMe.Models.UserCopie", b =>
                {
                    b.HasOne("BookMe.Models.Copie", "Copie")
                        .WithMany("UserCopies")
                        .HasForeignKey("CopieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookMe.Models.User", "User")
                        .WithMany("UserCopies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Copie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BookMe.Models.Auteur", b =>
                {
                    b.Navigation("AuteurLivres");
                });

            modelBuilder.Entity("BookMe.Models.Copie", b =>
                {
                    b.Navigation("UserCopies");
                });

            modelBuilder.Entity("BookMe.Models.Livre", b =>
                {
                    b.Navigation("AuteurLivres");

                    b.Navigation("Copies");

                    b.Navigation("LivreThemes");
                });

            modelBuilder.Entity("BookMe.Models.Theme", b =>
                {
                    b.Navigation("LivreThemes");
                });

            modelBuilder.Entity("BookMe.Models.User", b =>
                {
                    b.Navigation("UserCopies");
                });
#pragma warning restore 612, 618
        }
    }
}
