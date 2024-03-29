﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyAppCQRSPattern.Infrastructure.Data;

namespace MyAppCQRSPattern.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyAppCQRSPattern.Domain.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .IsFixedLength(true);

                    b.Property<int>("CourseNumber")
                        .HasColumnType("int")
                        .IsFixedLength(true);

                    b.Property<int>("CreditHour")
                        .HasColumnType("int")
                        .IsFixedLength(true);

                    b.HasKey("CourseId");

                    b.ToTable("tblCourse");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "Software Development",
                            CourseNumber = 300,
                            CreditHour = 8
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Razor Pages",
                            CourseNumber = 204,
                            CreditHour = 6
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = "MVC",
                            CourseNumber = 204,
                            CreditHour = 10
                        },
                        new
                        {
                            CourseId = 4,
                            CourseName = "Advanced Database Management",
                            CourseNumber = 400,
                            CreditHour = 10
                        });
                });

            modelBuilder.Entity("MyAppCQRSPattern.Domain.Entities.Gender", b =>
                {
                    b.Property<int>("GenderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .IsFixedLength(true);

                    b.HasKey("GenderId");

                    b.ToTable("tblGender");

                    b.HasData(
                        new
                        {
                            GenderId = 1,
                            Name = "Male"
                        },
                        new
                        {
                            GenderId = 2,
                            Name = "Female"
                        },
                        new
                        {
                            GenderId = 3,
                            Name = "Unknown"
                        });
                });

            modelBuilder.Entity("MyAppCQRSPattern.Domain.Entities.MainMenuItem", b =>
                {
                    b.Property<int>("MainMenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseDescripion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(max)")
                        .IsFixedLength(true);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("GenderDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(max)")
                        .IsFixedLength(true);

                    b.Property<string>("StudentDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(max)")
                        .IsFixedLength(true);

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("MainMenuId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("tblMainMenuItem");

                    b.HasData(
                        new
                        {
                            MainMenuId = 1,
                            CourseDescripion = "This is an introductory course to aspnet core razor pages!",
                            CourseId = 2,
                            GenderDescription = "Gender of a male",
                            StudentDescription = "This is our first student in the institution.",
                            StudentId = 1
                        },
                        new
                        {
                            MainMenuId = 2,
                            CourseDescripion = "This is an introductory course to software development fundamentals!",
                            CourseId = 1,
                            GenderDescription = "Gender of a male",
                            StudentDescription = "This is our second student in the institution.",
                            StudentId = 4
                        },
                        new
                        {
                            MainMenuId = 3,
                            CourseDescripion = "This is an introductory course to aspnet core model views and controllers!",
                            CourseId = 3,
                            GenderDescription = "Gender of a male",
                            StudentDescription = "This is our first student in the institution.",
                            StudentId = 2
                        },
                        new
                        {
                            MainMenuId = 4,
                            CourseDescripion = "This is an introductory course toa advanced database managemntn!",
                            CourseId = 4,
                            GenderDescription = "Gender of a male",
                            StudentDescription = "This is our first student in the institution.",
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("MyAppCQRSPattern.Domain.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateEnrolled")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("datetime2")
                        .IsFixedLength(true);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .IsFixedLength(true);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .IsFixedLength(true);

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .IsFixedLength(true);

                    b.HasKey("StudentId");

                    b.HasIndex("GenderId");

                    b.ToTable("tblStudent");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            DateEnrolled = new DateTime(2021, 7, 8, 15, 17, 20, 917, DateTimeKind.Utc).AddTicks(4582),
                            Email = "iamtuse@iamtuse.com",
                            FirstName = "iamtuse",
                            GenderId = 1,
                            LastName = "theProgrammer"
                        },
                        new
                        {
                            StudentId = 2,
                            DateEnrolled = new DateTime(2021, 7, 8, 15, 17, 20, 917, DateTimeKind.Utc).AddTicks(7226),
                            Email = "wonkulahp@iamtuse.com",
                            FirstName = "Precious",
                            GenderId = 2,
                            LastName = "Wonkulah"
                        },
                        new
                        {
                            StudentId = 3,
                            DateEnrolled = new DateTime(2021, 7, 8, 15, 17, 20, 917, DateTimeKind.Utc).AddTicks(7236),
                            Email = "dadwonkulahsr@iamtuse.com",
                            FirstName = "Dad",
                            GenderId = 1,
                            LastName = "Wonkulah Sr"
                        },
                        new
                        {
                            StudentId = 4,
                            DateEnrolled = new DateTime(2021, 7, 8, 15, 17, 20, 917, DateTimeKind.Utc).AddTicks(7240),
                            Email = "leo@iamtuse.com",
                            FirstName = "Leo",
                            GenderId = 1,
                            LastName = "Maxwell"
                        },
                        new
                        {
                            StudentId = 5,
                            DateEnrolled = new DateTime(2021, 7, 8, 15, 17, 20, 917, DateTimeKind.Utc).AddTicks(7244),
                            Email = "testuser@iamtuse.com",
                            FirstName = "Test",
                            GenderId = 3,
                            LastName = "User"
                        },
                        new
                        {
                            StudentId = 6,
                            DateEnrolled = new DateTime(2021, 7, 8, 15, 17, 20, 917, DateTimeKind.Utc).AddTicks(7257),
                            Email = "testuser1@iamtuse.com",
                            FirstName = "Test1",
                            GenderId = 2,
                            LastName = "User1"
                        });
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

            modelBuilder.Entity("MyAppCQRSPattern.Domain.Entities.MainMenuItem", b =>
                {
                    b.HasOne("MyAppCQRSPattern.Domain.Entities.Course", "Course")
                        .WithMany("MainMenuItem")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MyAppCQRSPattern.Domain.Entities.Student", "Student")
                        .WithMany("MainMenuItem")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("MyAppCQRSPattern.Domain.Entities.Student", b =>
                {
                    b.HasOne("MyAppCQRSPattern.Domain.Entities.Gender", "Gender")
                        .WithMany("Student")
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("MyAppCQRSPattern.Domain.Entities.Course", b =>
                {
                    b.Navigation("MainMenuItem");
                });

            modelBuilder.Entity("MyAppCQRSPattern.Domain.Entities.Gender", b =>
                {
                    b.Navigation("Student");
                });

            modelBuilder.Entity("MyAppCQRSPattern.Domain.Entities.Student", b =>
                {
                    b.Navigation("MainMenuItem");
                });
#pragma warning restore 612, 618
        }
    }
}
