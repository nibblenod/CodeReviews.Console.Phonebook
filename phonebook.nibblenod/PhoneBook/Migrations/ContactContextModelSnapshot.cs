﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Phone_Book;

#nullable disable

namespace Phone_Book.Migrations
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Phone_Book.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ava.thompson@example.com",
                            Name = "Ava Thompson",
                            PhoneNumber = "9876543210"
                        },
                        new
                        {
                            Id = 2,
                            Email = "liam.patel@example.com",
                            Name = "Liam Patel",
                            PhoneNumber = "9823456789"
                        },
                        new
                        {
                            Id = 3,
                            Email = "emma.reddy@example.com",
                            Name = "Emma Reddy",
                            PhoneNumber = "9845123480"
                        },
                        new
                        {
                            Id = 4,
                            Email = "noah.mehta@example.com",
                            Name = "Noah Mehta",
                            PhoneNumber = "9911223344"
                        },
                        new
                        {
                            Id = 5,
                            Email = "sophia.shah@example.com",
                            Name = "Sophia Shah",
                            PhoneNumber = "9887766554"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
