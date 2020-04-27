﻿// <auto-generated />
using System;
using ItaLog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ItaLog.Data.Migrations
{
    [DbContext(typeof(ItaLogContext))]
    [Migration("20200427161812_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ItaLog.Domain.Models.Environment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Environment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Production"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Homologation"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Development"
                        });
                });

            modelBuilder.Entity("ItaLog.Domain.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("varchar(1024)")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("ErrorDate")
                        .HasColumnType("datetime");

                    b.Property<int>("LogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LogId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("ItaLog.Domain.Models.Level", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Level");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Debug"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Warning"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Error"
                        });
                });

            modelBuilder.Entity("ItaLog.Domain.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApiUserId")
                        .HasColumnType("int");

                    b.Property<bool>("Archived")
                        .HasColumnType("bit");

                    b.Property<int>("EnvironmentId")
                        .HasColumnType("int");

                    b.Property<int>("LevelId")
                        .HasColumnType("int");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ApiUserId");

                    b.HasIndex("EnvironmentId");

                    b.HasIndex("LevelId");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("ItaLog.Domain.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Administrator"
                        });
                });

            modelBuilder.Entity("ItaLog.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastUpdateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<Guid>("UserToken")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(2515),
                            Email = "admin@contato.com",
                            EmailConfirmed = true,
                            LastUpdateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(5883),
                            Name = "Admin",
                            NormalizedUserName = "ADMIN@CONTATO.COM",
                            Password = "AQAAAAEAACcQAAAAENiU++GjfU7q1nAIgwulJmL319Hj8DHBCiiag198T1yUIOSQusFnjpQDjdYZuxjCPw==",
                            UserName = "admin@contato.com",
                            UserToken = new Guid("ca00974e-c905-4c09-97e2-17e1ff8ebccc")
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6460),
                            Email = "itau@contato.com",
                            EmailConfirmed = true,
                            LastUpdateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6472),
                            Name = "Itau",
                            NormalizedUserName = "ITAU@CONTATO.COM",
                            Password = "AQAAAAEAACcQAAAAENiU++GjfU7q1nAIgwulJmL319Hj8DHBCiiag198T1yUIOSQusFnjpQDjdYZuxjCPw==",
                            UserName = "itau@contato.com",
                            UserToken = new Guid("1ee36516-e92b-4be7-8732-7e8667b7fff2")
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6482),
                            Email = "afonso@contato.com",
                            EmailConfirmed = true,
                            LastUpdateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6483),
                            Name = "Afonso",
                            NormalizedUserName = "AFONSO@CONTATO.COM",
                            Password = "AQAAAAEAACcQAAAAENiU++GjfU7q1nAIgwulJmL319Hj8DHBCiiag198T1yUIOSQusFnjpQDjdYZuxjCPw==",
                            UserName = "afonso@contato.com",
                            UserToken = new Guid("5c0d3586-81ef-44d4-aa50-afab3e0e70e6")
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6486),
                            Email = "andre@contato.com",
                            EmailConfirmed = true,
                            LastUpdateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6487),
                            Name = "André",
                            NormalizedUserName = "ANDRE@CONTATO.COM",
                            Password = "AQAAAAEAACcQAAAAENiU++GjfU7q1nAIgwulJmL319Hj8DHBCiiag198T1yUIOSQusFnjpQDjdYZuxjCPw==",
                            UserName = "andre@contato.com",
                            UserToken = new Guid("ca894eda-98b7-4992-843d-817eb9afdf43")
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6490),
                            Email = "brunna@contato.com",
                            EmailConfirmed = true,
                            LastUpdateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6491),
                            Name = "Brunna",
                            NormalizedUserName = "BRUNNA@CONTATO.COM",
                            Password = "AQAAAAEAACcQAAAAENiU++GjfU7q1nAIgwulJmL319Hj8DHBCiiag198T1yUIOSQusFnjpQDjdYZuxjCPw==",
                            UserName = "brunna@contato.com",
                            UserToken = new Guid("3dac8ca4-31ab-4c4e-86b3-58956b188675")
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6493),
                            Email = "bruno@contato.com",
                            EmailConfirmed = true,
                            LastUpdateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6494),
                            Name = "Bruno",
                            NormalizedUserName = "BRUNO@CONTATO.COM",
                            Password = "AQAAAAEAACcQAAAAENiU++GjfU7q1nAIgwulJmL319Hj8DHBCiiag198T1yUIOSQusFnjpQDjdYZuxjCPw==",
                            UserName = "bruno@contato.com",
                            UserToken = new Guid("3fd11e2f-836e-4986-8c73-aebf65235e89")
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6496),
                            Email = "carlos@contato.com",
                            EmailConfirmed = true,
                            LastUpdateDate = new DateTime(2020, 4, 27, 13, 18, 12, 347, DateTimeKind.Local).AddTicks(6497),
                            Name = "Carlos",
                            NormalizedUserName = "CARLOS@CONTATO.COM",
                            Password = "AQAAAAEAACcQAAAAENiU++GjfU7q1nAIgwulJmL319Hj8DHBCiiag198T1yUIOSQusFnjpQDjdYZuxjCPw==",
                            UserName = "carlos@contato.com",
                            UserToken = new Guid("be7b8f9a-64b5-4c92-9bf4-2c1b77fc9612")
                        });
                });

            modelBuilder.Entity("ItaLog.Domain.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("ItaLog.Domain.Models.Event", b =>
                {
                    b.HasOne("ItaLog.Domain.Models.Log", "Log")
                        .WithMany("Events")
                        .HasForeignKey("LogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItaLog.Domain.Models.Log", b =>
                {
                    b.HasOne("ItaLog.Domain.Models.User", "ApiUser")
                        .WithMany("Logs")
                        .HasForeignKey("ApiUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItaLog.Domain.Models.Environment", "Environment")
                        .WithMany("Logs")
                        .HasForeignKey("EnvironmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItaLog.Domain.Models.Level", "Level")
                        .WithMany("Logs")
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ItaLog.Domain.Models.UserRole", b =>
                {
                    b.HasOne("ItaLog.Domain.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ItaLog.Domain.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}