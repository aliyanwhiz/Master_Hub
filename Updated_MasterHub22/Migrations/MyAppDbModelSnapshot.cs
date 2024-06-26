﻿// <auto-generated />
using DashBoard2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Updated_MasterHub22.Migrations
{
    [DbContext(typeof(MyAppDb))]
    partial class MyAppDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DashBoard2.Models.Admin", b =>
                {
                    b.Property<int>("Adm_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Adm_id"), 1L, 1);

                    b.Property<string>("Adm_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adm_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adm_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adm_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Adm_id");

                    b.ToTable("tbl_adm1");
                });

            modelBuilder.Entity("DashBoard2.Models.Booking", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Book_Id"), 1L, 1);

                    b.Property<string>("Custmers_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Custmers_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Custmers_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Messages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Service_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Book_Id");

                    b.ToTable("tbl_booking");
                });

            modelBuilder.Entity("DashBoard2.Models.Bookingservice", b =>
                {
                    b.Property<int>("Book_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Book_id"), 1L, 1);

                    b.Property<string>("city_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("service_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Book_id");

                    b.ToTable("tbl_bookingservice");
                });

            modelBuilder.Entity("DashBoard2.Models.City", b =>
                {
                    b.Property<int>("City_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("City_id"), 1L, 1);

                    b.Property<string>("City_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("City_id");

                    b.ToTable("tbl_city");
                });

            modelBuilder.Entity("DashBoard2.Models.Customer", b =>
                {
                    b.Property<int>("Cus_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cus_id"), 1L, 1);

                    b.Property<string>("Cus_address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cus_city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cus_email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cus_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cus_password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cus_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cus_id");

                    b.ToTable("tbl_cus1");
                });

            modelBuilder.Entity("DashBoard2.Models.Feedback", b =>
                {
                    b.Property<int>("Feedback_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Feedback_Id"), 1L, 1);

                    b.Property<string>("Feedback_Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Feedback_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Feedback_Id");

                    b.ToTable("tbl_feed");
                });

            modelBuilder.Entity("DashBoard2.Models.Partner", b =>
                {
                    b.Property<int>("Partner_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Partner_Id"), 1L, 1);

                    b.Property<string>("Partner_experties")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Partner_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Partner_phonr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Partner_Id");

                    b.ToTable("tbl_part");
                });

            modelBuilder.Entity("DashBoard2.Models.Services", b =>
                {
                    b.Property<int>("Service_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Service_Id"), 1L, 1);

                    b.Property<string>("Services_Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Services_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Service_Id");

                    b.ToTable("tbl_services");
                });
#pragma warning restore 612, 618
        }
    }
}
