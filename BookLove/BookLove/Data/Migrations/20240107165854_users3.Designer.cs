﻿// <auto-generated />
using System;
using BookLove.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookLove.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240107165854_users3")]
    partial class users3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookLove.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BookGenreId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFavourite")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookGenreId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "J.R.R. Tolkien",
                            BookGenreId = 1,
                            Description = "Epicka powieść fantasy",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Władca Pierścieni"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Laura Esquivel",
                            BookGenreId = 2,
                            Description = "Romans z nutką magii",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Czekolada z chili"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Carl Sagan",
                            BookGenreId = 3,
                            Description = "Popularnonaukowe spojrzenie na wszechświat",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Kosmos"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Markus Zusak",
                            BookGenreId = 4,
                            Description = "Historia narracji z perspektywy śmierci",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Złodziejka książek"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Thomas Harris",
                            BookGenreId = 5,
                            Description = "Klasyczny thriller psychologiczny",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Milcząca owca"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Andrzej Sapkowski",
                            BookGenreId = 1,
                            Description = "niezwykłe i wciągające opowieści o przygodach wiedźmina Geralta z Rivii",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Ostatnie życzenie"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Nicholas Sparks",
                            BookGenreId = 2,
                            Description = "Piękna i wzruszająca opowieść o wielkiej miłości,która potrafiła przetrwać przez czternaście lat w rozłące",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Pamiętnik"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Neil deGrasse Tyson",
                            BookGenreId = 3,
                            Description = "Te opowieści o wszechświecie rozpalą waszą wyobraźnię",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Kosmiczne zachwyty i rozterki"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Agatha Christie",
                            BookGenreId = 4,
                            Description = "klasyczna powieść kryminalna autorstwa Agathy Christie, w której słynny detektyw Hercule Poirot prowadzi śledztwo w zamkniętym przedziałowym pociągu Orient Express, starając się rozwikłać tajemnicze morderstwo jednego z pasażerów",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Morderstwo w Orient Expressie"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Jo Nesbo",
                            BookGenreId = 5,
                            Description = "powieść, w której świat realny miesza się z fikcyjnym",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Nocny dom"
                        },
                        new
                        {
                            Id = 11,
                            Author = "Terry Pratchett",
                            BookGenreId = 1,
                            Description = "Pierwsza część długiego cyklu Świat Dysku",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Kolor magii"
                        },
                        new
                        {
                            Id = 12,
                            Author = "Lauren Weisberger",
                            BookGenreId = 2,
                            Description = "porywająca powieść, która rzuca spojrzenie za kulisy światka mody w Nowym Jorku",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Diabeł ubiera się u Prady"
                        },
                        new
                        {
                            Id = 13,
                            Author = "Stephen Hawking",
                            BookGenreId = 3,
                            Description = " Poznaj ogrom przestrzeni międzygalaktycznej i znajdź odpowiedzi na pytania o czasoprzestrzeń",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Krótka historia czasu "
                        },
                        new
                        {
                            Id = 14,
                            Author = "Jo Nesbo",
                            BookGenreId = 4,
                            Description = "Autor z wirtuozerią odmalowuje mroczne wizje przyszłości, w których sprawiedliwość rządzi się swoimi zasadami",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Zemsta"
                        },
                        new
                        {
                            Id = 15,
                            Author = "Remigiusz Mróz",
                            BookGenreId = 5,
                            Description = "Polski thriller prawniczy",
                            IsFavourite = false,
                            Language = "Polski",
                            Title = "Kasacja"
                        });
                });

            modelBuilder.Entity("BookLove.Models.BookGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookGenre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fantastyka"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Literatura obyczajowa"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Literatura naukowa"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kryminał"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("BookLove.Models.FavouriteBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("userId");

                    b.ToTable("FavouriteBook");
                });

            modelBuilder.Entity("BookLove.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("userId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("userId");

                    b.ToTable("Review");
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

                    b.ToTable("AspNetRoles", (string)null);
                });

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookLove.Models.Book", b =>
                {
                    b.HasOne("BookLove.Models.BookGenre", "BookGenre")
                        .WithMany()
                        .HasForeignKey("BookGenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookGenre");
                });

            modelBuilder.Entity("BookLove.Models.FavouriteBook", b =>
                {
                    b.HasOne("BookLove.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "user")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.Navigation("Book");

                    b.Navigation("user");
                });

            modelBuilder.Entity("BookLove.Models.Review", b =>
                {
                    b.HasOne("BookLove.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "user")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.Navigation("Book");

                    b.Navigation("user");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
