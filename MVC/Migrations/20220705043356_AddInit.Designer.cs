﻿// <auto-generated />
using System;
using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC.Migrations
{
    [DbContext(typeof(FinalProjecContext))]
    [Migration("20220705043356_AddInit")]
    partial class AddInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.Models.Project", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProjectDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Domain.Models.ProjectMember", b =>
                {
                    b.Property<Guid>("ProjectMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AcceptInviation")
                        .HasColumnType("int");

                    b.Property<string>("MemberRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProjectMemberId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectMembers");
                });

            modelBuilder.Entity("Domain.Models.Task", b =>
                {
                    b.Property<Guid>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssignbyUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("InProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TaskDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TaskId");

                    b.HasIndex("AssignbyUserId");

                    b.HasIndex("InProjectId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.ProjectMember", b =>
                {
                    b.HasOne("Domain.Models.Project", "IsProject")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Models.User", "IsUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IsProject");

                    b.Navigation("IsUser");
                });

            modelBuilder.Entity("Domain.Models.Task", b =>
                {
                    b.HasOne("Domain.Models.User", "Assignby")
                        .WithMany("Task")
                        .HasForeignKey("AssignbyUserId");

                    b.HasOne("Domain.Models.Project", "In")
                        .WithMany("Tasks")
                        .HasForeignKey("InProjectId");

                    b.Navigation("Assignby");

                    b.Navigation("In");
                });

            modelBuilder.Entity("Domain.Models.Project", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("Task");
                });
#pragma warning restore 612, 618
        }
    }
}
