﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hjudgeWeb.Data;

namespace hjudgeWeb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("hjudgeWeb.Data.Contest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalInfo");

                    b.Property<string>("Config");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndTime");

                    b.Property<bool>("Hidden");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<bool>("SpecifyCompetitors");

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Contest");
                });

            modelBuilder.Entity("hjudgeWeb.Data.ContestProblemConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AcceptCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<int?>("ContestId");

                    b.Property<int?>("ProblemId");

                    b.Property<int?>("SubmissionCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ProblemId");

                    b.ToTable("ContestProblemConfig");
                });

            modelBuilder.Entity("hjudgeWeb.Data.ContestRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContestId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.ToTable("ContestRegister");
                });

            modelBuilder.Entity("hjudgeWeb.Data.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalInfo");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description");

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("hjudgeWeb.Data.GroupContestConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ContestId");

                    b.Property<int?>("GroupId");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupContestConfig");
                });

            modelBuilder.Entity("hjudgeWeb.Data.GroupJoin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GroupId");

                    b.Property<DateTime>("JoinTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupJoin");
                });

            modelBuilder.Entity("hjudgeWeb.Data.Identity.UserInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<byte[]>("Avatar");

                    b.Property<long>("Coins");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<long>("Experience");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("OtherInfo");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("Privilege");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("hjudgeWeb.Data.Judge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalInfo");

                    b.Property<string>("Code");

                    b.Property<int?>("ContestId");

                    b.Property<string>("Description");

                    b.Property<int?>("GroupId");

                    b.Property<DateTime>("JudgeTime");

                    b.Property<string>("Language");

                    b.Property<string>("Logs");

                    b.Property<int?>("ProblemId");

                    b.Property<string>("Result");

                    b.Property<int>("ResultType");

                    b.Property<int>("Type");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("GroupId");

                    b.HasIndex("ProblemId");

                    b.ToTable("Judge");
                });

            modelBuilder.Entity("hjudgeWeb.Data.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("SendTime");

                    b.Property<string>("Targets");

                    b.Property<string>("Title");

                    b.Property<int>("Type");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("hjudgeWeb.Data.MessageStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MessageId");

                    b.Property<DateTime>("OperationTime");

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.ToTable("MessageStatus");
                });

            modelBuilder.Entity("hjudgeWeb.Data.Problem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AcceptCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<string>("AdditionalInfo");

                    b.Property<string>("Config");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description");

                    b.Property<bool>("Hidden");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<int?>("SubmissionCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<int>("Type");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Problem");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("hjudgeWeb.Data.ContestProblemConfig", b =>
                {
                    b.HasOne("hjudgeWeb.Data.Contest", "Contest")
                        .WithMany("ContestProblemConfig")
                        .HasForeignKey("ContestId");

                    b.HasOne("hjudgeWeb.Data.Problem", "Problem")
                        .WithMany("ContestProblemConfig")
                        .HasForeignKey("ProblemId");
                });

            modelBuilder.Entity("hjudgeWeb.Data.ContestRegister", b =>
                {
                    b.HasOne("hjudgeWeb.Data.Contest", "Contest")
                        .WithMany("ContestRegister")
                        .HasForeignKey("ContestId");
                });

            modelBuilder.Entity("hjudgeWeb.Data.GroupContestConfig", b =>
                {
                    b.HasOne("hjudgeWeb.Data.Contest", "Contest")
                        .WithMany("GroupContestConfig")
                        .HasForeignKey("ContestId");

                    b.HasOne("hjudgeWeb.Data.Group", "Group")
                        .WithMany("GroupContestConfig")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("hjudgeWeb.Data.GroupJoin", b =>
                {
                    b.HasOne("hjudgeWeb.Data.Group", "Group")
                        .WithMany("GroupJoin")
                        .HasForeignKey("GroupId");
                });

            modelBuilder.Entity("hjudgeWeb.Data.Judge", b =>
                {
                    b.HasOne("hjudgeWeb.Data.Contest", "Contest")
                        .WithMany("Judge")
                        .HasForeignKey("ContestId");

                    b.HasOne("hjudgeWeb.Data.Group", "Group")
                        .WithMany("Judge")
                        .HasForeignKey("GroupId");

                    b.HasOne("hjudgeWeb.Data.Problem", "Problem")
                        .WithMany("Judge")
                        .HasForeignKey("ProblemId");
                });

            modelBuilder.Entity("hjudgeWeb.Data.MessageStatus", b =>
                {
                    b.HasOne("hjudgeWeb.Data.Message", "Message")
                        .WithMany("MessageStatus")
                        .HasForeignKey("MessageId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("hjudgeWeb.Data.Identity.UserInfo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("hjudgeWeb.Data.Identity.UserInfo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWeb.Data.Identity.UserInfo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("hjudgeWeb.Data.Identity.UserInfo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
