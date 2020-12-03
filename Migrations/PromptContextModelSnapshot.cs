﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETD3202_Lab5.Models;

namespace NETD3202_Lab5.Migrations
{
    [DbContext(typeof(PromptContext))]
    partial class PromptContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NETD3202_Lab5.Models.Prompts", b =>
                {
                    b.Property<int>("p_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("prompt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("p_id");

                    b.ToTable("Prompts");
                });
#pragma warning restore 612, 618
        }
    }
}
