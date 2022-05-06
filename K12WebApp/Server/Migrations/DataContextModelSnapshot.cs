﻿// <auto-generated />
using System;
using K12WebApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace K12WebApp.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ChoreMonthUser", b =>
                {
                    b.Property<int>("AssignedUserId")
                        .HasColumnType("int");

                    b.Property<int>("ChoreMonthsId")
                        .HasColumnType("int");

                    b.HasKey("AssignedUserId", "ChoreMonthsId");

                    b.HasIndex("ChoreMonthsId");

                    b.ToTable("ChoreMonthUser");
                });

            modelBuilder.Entity("K12WebApp.Shared.Chore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Chores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            Name = "Tjanse-tjekker"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            Name = "Affalds-sortering"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            Name = "Krydderihylde, emhætter og skuffer"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            Name = "Ovn/komfur ved dør"
                        },
                        new
                        {
                            Id = 5,
                            Description = "",
                            Name = "Altan og pant"
                        },
                        new
                        {
                            Id = 6,
                            Description = "",
                            Name = "Alm. og grønskraldespand"
                        },
                        new
                        {
                            Id = 7,
                            Description = "",
                            Name = "Ovn/komfur ved stuen"
                        },
                        new
                        {
                            Id = 8,
                            Description = "",
                            Name = "Rydde op, tørre af og støvsuge"
                        },
                        new
                        {
                            Id = 9,
                            Description = "",
                            Name = "Buffer"
                        });
                });

            modelBuilder.Entity("K12WebApp.Shared.ChoreMonth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ChoreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChoreId");

                    b.ToTable("ChoreMonths");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ChoreId = 1,
                            Name = "januar"
                        },
                        new
                        {
                            Id = 2,
                            ChoreId = 1,
                            Name = "februar"
                        },
                        new
                        {
                            Id = 3,
                            ChoreId = 1,
                            Name = "marts"
                        },
                        new
                        {
                            Id = 4,
                            ChoreId = 1,
                            Name = "april"
                        },
                        new
                        {
                            Id = 5,
                            ChoreId = 1,
                            Name = "maj"
                        },
                        new
                        {
                            Id = 6,
                            ChoreId = 1,
                            Name = "juni"
                        },
                        new
                        {
                            Id = 7,
                            ChoreId = 1,
                            Name = "juli"
                        },
                        new
                        {
                            Id = 8,
                            ChoreId = 1,
                            Name = "august"
                        },
                        new
                        {
                            Id = 9,
                            ChoreId = 1,
                            Name = "september"
                        },
                        new
                        {
                            Id = 10,
                            ChoreId = 1,
                            Name = "october"
                        },
                        new
                        {
                            Id = 11,
                            ChoreId = 1,
                            Name = "november"
                        },
                        new
                        {
                            Id = 12,
                            ChoreId = 1,
                            Name = "december"
                        },
                        new
                        {
                            Id = 13,
                            ChoreId = 2,
                            Name = "januar"
                        },
                        new
                        {
                            Id = 14,
                            ChoreId = 2,
                            Name = "februar"
                        },
                        new
                        {
                            Id = 15,
                            ChoreId = 2,
                            Name = "marts"
                        },
                        new
                        {
                            Id = 16,
                            ChoreId = 2,
                            Name = "april"
                        },
                        new
                        {
                            Id = 17,
                            ChoreId = 2,
                            Name = "maj"
                        },
                        new
                        {
                            Id = 18,
                            ChoreId = 2,
                            Name = "juni"
                        },
                        new
                        {
                            Id = 19,
                            ChoreId = 2,
                            Name = "juli"
                        },
                        new
                        {
                            Id = 20,
                            ChoreId = 2,
                            Name = "august"
                        },
                        new
                        {
                            Id = 21,
                            ChoreId = 2,
                            Name = "september"
                        },
                        new
                        {
                            Id = 22,
                            ChoreId = 2,
                            Name = "october"
                        },
                        new
                        {
                            Id = 23,
                            ChoreId = 2,
                            Name = "november"
                        },
                        new
                        {
                            Id = 24,
                            ChoreId = 2,
                            Name = "december"
                        },
                        new
                        {
                            Id = 25,
                            ChoreId = 3,
                            Name = "januar"
                        },
                        new
                        {
                            Id = 26,
                            ChoreId = 3,
                            Name = "februar"
                        },
                        new
                        {
                            Id = 27,
                            ChoreId = 3,
                            Name = "marts"
                        },
                        new
                        {
                            Id = 28,
                            ChoreId = 3,
                            Name = "april"
                        },
                        new
                        {
                            Id = 29,
                            ChoreId = 3,
                            Name = "maj"
                        },
                        new
                        {
                            Id = 30,
                            ChoreId = 3,
                            Name = "juni"
                        },
                        new
                        {
                            Id = 31,
                            ChoreId = 3,
                            Name = "juli"
                        },
                        new
                        {
                            Id = 32,
                            ChoreId = 3,
                            Name = "august"
                        },
                        new
                        {
                            Id = 33,
                            ChoreId = 3,
                            Name = "september"
                        },
                        new
                        {
                            Id = 34,
                            ChoreId = 3,
                            Name = "october"
                        },
                        new
                        {
                            Id = 35,
                            ChoreId = 3,
                            Name = "november"
                        },
                        new
                        {
                            Id = 36,
                            ChoreId = 3,
                            Name = "december"
                        },
                        new
                        {
                            Id = 37,
                            ChoreId = 4,
                            Name = "januar"
                        },
                        new
                        {
                            Id = 38,
                            ChoreId = 4,
                            Name = "februar"
                        },
                        new
                        {
                            Id = 39,
                            ChoreId = 4,
                            Name = "marts"
                        },
                        new
                        {
                            Id = 40,
                            ChoreId = 4,
                            Name = "april"
                        },
                        new
                        {
                            Id = 41,
                            ChoreId = 4,
                            Name = "maj"
                        },
                        new
                        {
                            Id = 42,
                            ChoreId = 4,
                            Name = "juni"
                        },
                        new
                        {
                            Id = 43,
                            ChoreId = 4,
                            Name = "juli"
                        },
                        new
                        {
                            Id = 44,
                            ChoreId = 4,
                            Name = "august"
                        },
                        new
                        {
                            Id = 45,
                            ChoreId = 4,
                            Name = "september"
                        },
                        new
                        {
                            Id = 46,
                            ChoreId = 4,
                            Name = "october"
                        },
                        new
                        {
                            Id = 47,
                            ChoreId = 4,
                            Name = "november"
                        },
                        new
                        {
                            Id = 48,
                            ChoreId = 4,
                            Name = "december"
                        },
                        new
                        {
                            Id = 49,
                            ChoreId = 5,
                            Name = "januar"
                        },
                        new
                        {
                            Id = 50,
                            ChoreId = 5,
                            Name = "februar"
                        },
                        new
                        {
                            Id = 51,
                            ChoreId = 5,
                            Name = "marts"
                        },
                        new
                        {
                            Id = 52,
                            ChoreId = 5,
                            Name = "april"
                        },
                        new
                        {
                            Id = 53,
                            ChoreId = 5,
                            Name = "maj"
                        },
                        new
                        {
                            Id = 54,
                            ChoreId = 5,
                            Name = "juni"
                        },
                        new
                        {
                            Id = 55,
                            ChoreId = 5,
                            Name = "juli"
                        },
                        new
                        {
                            Id = 56,
                            ChoreId = 5,
                            Name = "august"
                        },
                        new
                        {
                            Id = 57,
                            ChoreId = 5,
                            Name = "september"
                        },
                        new
                        {
                            Id = 58,
                            ChoreId = 5,
                            Name = "october"
                        },
                        new
                        {
                            Id = 59,
                            ChoreId = 5,
                            Name = "november"
                        },
                        new
                        {
                            Id = 60,
                            ChoreId = 5,
                            Name = "december"
                        },
                        new
                        {
                            Id = 61,
                            ChoreId = 6,
                            Name = "januar"
                        },
                        new
                        {
                            Id = 62,
                            ChoreId = 6,
                            Name = "februar"
                        },
                        new
                        {
                            Id = 63,
                            ChoreId = 6,
                            Name = "marts"
                        },
                        new
                        {
                            Id = 64,
                            ChoreId = 6,
                            Name = "april"
                        },
                        new
                        {
                            Id = 65,
                            ChoreId = 6,
                            Name = "maj"
                        },
                        new
                        {
                            Id = 66,
                            ChoreId = 6,
                            Name = "juni"
                        },
                        new
                        {
                            Id = 67,
                            ChoreId = 6,
                            Name = "juli"
                        },
                        new
                        {
                            Id = 68,
                            ChoreId = 6,
                            Name = "august"
                        },
                        new
                        {
                            Id = 69,
                            ChoreId = 6,
                            Name = "september"
                        },
                        new
                        {
                            Id = 70,
                            ChoreId = 6,
                            Name = "october"
                        },
                        new
                        {
                            Id = 71,
                            ChoreId = 6,
                            Name = "november"
                        },
                        new
                        {
                            Id = 72,
                            ChoreId = 6,
                            Name = "december"
                        },
                        new
                        {
                            Id = 73,
                            ChoreId = 7,
                            Name = "januar"
                        },
                        new
                        {
                            Id = 74,
                            ChoreId = 7,
                            Name = "februar"
                        },
                        new
                        {
                            Id = 75,
                            ChoreId = 7,
                            Name = "marts"
                        },
                        new
                        {
                            Id = 76,
                            ChoreId = 7,
                            Name = "april"
                        },
                        new
                        {
                            Id = 77,
                            ChoreId = 7,
                            Name = "maj"
                        },
                        new
                        {
                            Id = 78,
                            ChoreId = 7,
                            Name = "juni"
                        },
                        new
                        {
                            Id = 79,
                            ChoreId = 7,
                            Name = "juli"
                        },
                        new
                        {
                            Id = 80,
                            ChoreId = 7,
                            Name = "august"
                        },
                        new
                        {
                            Id = 81,
                            ChoreId = 7,
                            Name = "september"
                        },
                        new
                        {
                            Id = 82,
                            ChoreId = 7,
                            Name = "october"
                        },
                        new
                        {
                            Id = 83,
                            ChoreId = 7,
                            Name = "november"
                        },
                        new
                        {
                            Id = 84,
                            ChoreId = 7,
                            Name = "december"
                        },
                        new
                        {
                            Id = 85,
                            ChoreId = 8,
                            Name = "januar"
                        },
                        new
                        {
                            Id = 86,
                            ChoreId = 8,
                            Name = "februar"
                        },
                        new
                        {
                            Id = 87,
                            ChoreId = 8,
                            Name = "marts"
                        },
                        new
                        {
                            Id = 88,
                            ChoreId = 8,
                            Name = "april"
                        },
                        new
                        {
                            Id = 89,
                            ChoreId = 8,
                            Name = "maj"
                        },
                        new
                        {
                            Id = 90,
                            ChoreId = 8,
                            Name = "juni"
                        },
                        new
                        {
                            Id = 91,
                            ChoreId = 8,
                            Name = "juli"
                        },
                        new
                        {
                            Id = 92,
                            ChoreId = 8,
                            Name = "august"
                        },
                        new
                        {
                            Id = 93,
                            ChoreId = 8,
                            Name = "september"
                        },
                        new
                        {
                            Id = 94,
                            ChoreId = 8,
                            Name = "october"
                        },
                        new
                        {
                            Id = 95,
                            ChoreId = 8,
                            Name = "november"
                        },
                        new
                        {
                            Id = 96,
                            ChoreId = 8,
                            Name = "december"
                        },
                        new
                        {
                            Id = 97,
                            ChoreId = 9,
                            Name = "januar"
                        },
                        new
                        {
                            Id = 98,
                            ChoreId = 9,
                            Name = "februar"
                        },
                        new
                        {
                            Id = 99,
                            ChoreId = 9,
                            Name = "marts"
                        },
                        new
                        {
                            Id = 100,
                            ChoreId = 9,
                            Name = "april"
                        },
                        new
                        {
                            Id = 101,
                            ChoreId = 9,
                            Name = "maj"
                        },
                        new
                        {
                            Id = 102,
                            ChoreId = 9,
                            Name = "juni"
                        },
                        new
                        {
                            Id = 103,
                            ChoreId = 9,
                            Name = "juli"
                        },
                        new
                        {
                            Id = 104,
                            ChoreId = 9,
                            Name = "august"
                        },
                        new
                        {
                            Id = 105,
                            ChoreId = 9,
                            Name = "september"
                        },
                        new
                        {
                            Id = 106,
                            ChoreId = 9,
                            Name = "october"
                        },
                        new
                        {
                            Id = 107,
                            ChoreId = 9,
                            Name = "november"
                        },
                        new
                        {
                            Id = 108,
                            ChoreId = 9,
                            Name = "december"
                        });
                });

            modelBuilder.Entity("K12WebApp.Shared.Grocery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("GroceryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isBought")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.ToTable("Groceries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7464),
                            GroceryName = "Løg",
                            isBought = false
                        },
                        new
                        {
                            Id = 2,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7496),
                            GroceryName = "Hvidløg",
                            isBought = false
                        },
                        new
                        {
                            Id = 3,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7498),
                            GroceryName = "Affaldsposer",
                            isBought = false
                        },
                        new
                        {
                            Id = 4,
                            CreatedByUserId = 1,
                            DateCreated = new DateTime(2022, 5, 6, 17, 5, 50, 920, DateTimeKind.Local).AddTicks(7500),
                            GroceryName = "Karry",
                            isBought = false
                        });
                });

            modelBuilder.Entity("K12WebApp.Shared.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Køkken Ansvarlig"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Køkken Beboer"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tjanse Tjekker"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Køkken Kasserer"
                        });
                });

            modelBuilder.Entity("K12WebApp.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("RoomNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoomNo")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "",
                            FirstName = "Christian",
                            LastName = "Merithz Uhrenfeldt Nielsen",
                            NickName = "Krølle",
                            RoleId = 1,
                            RoomNo = 1350
                        },
                        new
                        {
                            Id = 2,
                            Email = "",
                            FirstName = "Joey",
                            LastName = "Knutsson",
                            NickName = "Joey",
                            RoleId = 2,
                            RoomNo = 1340
                        },
                        new
                        {
                            Id = 3,
                            Email = "",
                            FirstName = "Emma",
                            LastName = "Rosa",
                            NickName = "Ems",
                            RoleId = 3,
                            RoomNo = 1347
                        },
                        new
                        {
                            Id = 4,
                            Email = "",
                            FirstName = "Kasper",
                            LastName = "Djælund Nyberg",
                            NickName = "Guffe",
                            RoleId = 3,
                            RoomNo = 1345
                        },
                        new
                        {
                            Id = 5,
                            Email = "",
                            FirstName = "Daniel",
                            LastName = "Katz",
                            NickName = "Danniboi",
                            RoleId = 3,
                            RoomNo = 1344
                        },
                        new
                        {
                            Id = 6,
                            Email = "",
                            FirstName = "Andreas",
                            LastName = "Ven",
                            NickName = "Venno",
                            RoleId = 3,
                            RoomNo = 1349
                        },
                        new
                        {
                            Id = 7,
                            Email = "",
                            FirstName = "Lynge",
                            LastName = "Moustgaard",
                            NickName = "LyngLyng",
                            RoleId = 3,
                            RoomNo = 1351
                        },
                        new
                        {
                            Id = 8,
                            Email = "",
                            FirstName = "Lucas",
                            LastName = "Zacho",
                            NickName = "Peter",
                            RoleId = 3,
                            RoomNo = 1343
                        },
                        new
                        {
                            Id = 9,
                            Email = "",
                            FirstName = "Nicolai",
                            LastName = "Toft",
                            NickName = "Nico",
                            RoleId = 3,
                            RoomNo = 1348
                        },
                        new
                        {
                            Id = 10,
                            Email = "",
                            FirstName = "Anastasia",
                            LastName = "Jakobsen",
                            NickName = "Anastasia",
                            RoleId = 3,
                            RoomNo = 1346
                        },
                        new
                        {
                            Id = 11,
                            Email = "",
                            FirstName = "Eva",
                            LastName = "Sand Larsen",
                            NickName = "Eva",
                            RoleId = 5,
                            RoomNo = 1341
                        },
                        new
                        {
                            Id = 12,
                            Email = "",
                            FirstName = "Ahmad",
                            LastName = "Mazrah",
                            NickName = "Ahmad",
                            RoleId = 3,
                            RoomNo = 1353
                        });
                });

            modelBuilder.Entity("ChoreMonthUser", b =>
                {
                    b.HasOne("K12WebApp.Shared.User", null)
                        .WithMany()
                        .HasForeignKey("AssignedUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("K12WebApp.Shared.ChoreMonth", null)
                        .WithMany()
                        .HasForeignKey("ChoreMonthsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("K12WebApp.Shared.ChoreMonth", b =>
                {
                    b.HasOne("K12WebApp.Shared.Chore", null)
                        .WithMany("ChoreMonths")
                        .HasForeignKey("ChoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("K12WebApp.Shared.Grocery", b =>
                {
                    b.HasOne("K12WebApp.Shared.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");
                });

            modelBuilder.Entity("K12WebApp.Shared.User", b =>
                {
                    b.HasOne("K12WebApp.Shared.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("K12WebApp.Shared.Chore", b =>
                {
                    b.Navigation("ChoreMonths");
                });
#pragma warning restore 612, 618
        }
    }
}
