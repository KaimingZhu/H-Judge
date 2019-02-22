﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hjudgeWebHost.Data;

namespace hjudgeWebHost.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181115035730_VotesAndCountAndImprovements")]
    partial class VotesAndCountAndImprovements
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("hjudgeWebHost.Data.Contest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInfo");

                    b.Property<string>("Config");

                    b.Property<string>("Description");

                    b.Property<int>("Downvote")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<DateTime>("EndTime");

                    b.Property<bool>("Hidden");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<bool>("SpecifyCompetitors");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("Upvote")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Contest");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.ContestProblemConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcceptCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<int>("ContestId");

                    b.Property<int>("ProblemId");

                    b.Property<int>("SubmissionCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("ProblemId");

                    b.ToTable("ContestProblemConfig");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.ContestRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContestId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("UserId");

                    b.ToTable("ContestRegister");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.Discussion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int?>("ContestId");

                    b.Property<int?>("GroupId");

                    b.Property<int?>("ProblemId");

                    b.Property<DateTime>("SubmitTime");

                    b.Property<string>("Title");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("GroupId");

                    b.HasIndex("ProblemId");

                    b.HasIndex("UserId");

                    b.ToTable("Discussion");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInfo");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description");

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("Name");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.GroupContestConfig", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContestId");

                    b.Property<int>("GroupId");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("GroupId");

                    b.ToTable("GroupContestConfig");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.GroupJoin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.Property<DateTime>("JoinTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupJoin");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.Identity.UserInfo", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AcceptedCount");

                    b.Property<int>("AccessFailedCount");

                    b.Property<byte[]>("Avatar");

                    b.Property<long>("Coins");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<int>("ContinuousSignedIn");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<long>("Experience");

                    b.Property<DateTime>("LastSignedIn");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<int>("MessageReplyCount");

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

                    b.Property<int>("SubmissionCount");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.Judge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalInfo");

                    b.Property<string>("Content");

                    b.Property<int?>("ContestId");

                    b.Property<string>("Description");

                    b.Property<float>("FullScore");

                    b.Property<int?>("GroupId");

                    b.Property<bool>("IsPublic");

                    b.Property<int>("JudgeCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<DateTime>("JudgeTime");

                    b.Property<string>("Language");

                    b.Property<string>("Logs");

                    b.Property<int>("ProblemId");

                    b.Property<string>("Result");

                    b.Property<int>("ResultType");

                    b.Property<int>("Type");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("GroupId");

                    b.HasIndex("ProblemId");

                    b.HasIndex("UserId");

                    b.ToTable("Judge");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("SendTime");

                    b.Property<string>("Targets");

                    b.Property<string>("Title");

                    b.Property<int>("Type");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.MessageStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MessageId");

                    b.Property<DateTime>("OperationTime");

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("MessageStatus");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.Problem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcceptCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<string>("AdditionalInfo");

                    b.Property<string>("Config");

                    b.Property<DateTime>("CreationTime");

                    b.Property<string>("Description");

                    b.Property<int>("Downvote")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<bool>("Hidden");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<int>("SubmissionCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<int>("Type");

                    b.Property<int>("Upvote")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("0");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Problem");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.VotesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int?>("ContestId");

                    b.Property<int?>("GroupId");

                    b.Property<int?>("ProblemId");

                    b.Property<string>("Title");

                    b.Property<string>("UserId");

                    b.Property<DateTime>("VoteTime");

                    b.Property<int>("VoteType")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("1");

                    b.HasKey("Id");

                    b.HasIndex("ContestId");

                    b.HasIndex("GroupId");

                    b.HasIndex("ProblemId");

                    b.HasIndex("UserId");

                    b.ToTable("VotesRecord");
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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("hjudgeWebHost.Data.Contest", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo", "UserInfo")
                        .WithMany("Contest")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.ContestProblemConfig", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Contest", "Contest")
                        .WithMany("ContestProblemConfig")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Problem", "Problem")
                        .WithMany("ContestProblemConfig")
                        .HasForeignKey("ProblemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("hjudgeWebHost.Data.ContestRegister", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Contest", "Contest")
                        .WithMany("ContestRegister")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo", "UserInfo")
                        .WithMany("ContestRegister")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("hjudgeWebHost.Data.Discussion", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Contest", "Contest")
                        .WithMany("Discussion")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Group", "Group")
                        .WithMany("Discussion")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Problem", "Problem")
                        .WithMany("Discussion")
                        .HasForeignKey("ProblemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo", "UserInfo")
                        .WithMany("Discussion")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("hjudgeWebHost.Data.Group", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo", "UserInfo")
                        .WithMany("Group")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.GroupContestConfig", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Contest", "Contest")
                        .WithMany("GroupContestConfig")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Group", "Group")
                        .WithMany("GroupContestConfig")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("hjudgeWebHost.Data.GroupJoin", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Group", "Group")
                        .WithMany("GroupJoin")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo", "UserInfo")
                        .WithMany("GroupJoin")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("hjudgeWebHost.Data.Judge", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Contest", "Contest")
                        .WithMany("Judge")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Group", "Group")
                        .WithMany("Judge")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Problem", "Problem")
                        .WithMany("Judge")
                        .HasForeignKey("ProblemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo", "UserInfo")
                        .WithMany("Judge")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("hjudgeWebHost.Data.Message", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo", "UserInfo")
                        .WithMany("Message")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("hjudgeWebHost.Data.MessageStatus", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Message", "Message")
                        .WithMany("MessageStatus")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo", "UserInfo")
                        .WithMany("MessageStatus")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.Problem", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo", "UserInfo")
                        .WithMany("Problem")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("hjudgeWebHost.Data.VotesRecord", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Contest", "Contest")
                        .WithMany("VotesRecord")
                        .HasForeignKey("ContestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Group", "Group")
                        .WithMany("VotesRecord")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Problem", "Problem")
                        .WithMany("VotesRecord")
                        .HasForeignKey("ProblemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo", "UserInfo")
                        .WithMany("VotesRecord")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
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
                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo")
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

                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("hjudgeWebHost.Data.Identity.UserInfo")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
