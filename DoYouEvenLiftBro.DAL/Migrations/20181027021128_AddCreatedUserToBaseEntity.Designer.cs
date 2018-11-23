﻿// <auto-generated />
using System;
using DoYouEvenLiftBro.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DoYouEvenLiftBro.DAL.Migrations
{
    [DbContext(typeof(DoYouEvenLiftBroContext))]
    [Migration("20181027021128_AddCreatedUserToBaseEntity")]
    partial class AddCreatedUserToBaseEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:citext", "'citext', '', ''")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DoYouEvenLiftBro.DAL.Entities.Exercise", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnName("created");

                    b.Property<long?>("CreatedUserId")
                        .HasColumnName("created_user_id");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_exercises");

                    b.HasIndex("CreatedUserId")
                        .HasName("ix_exercises_created_user_id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("ix_exercises_name");

                    b.ToTable("exercises");
                });

            modelBuilder.Entity("DoYouEvenLiftBro.DAL.Entities.MuscleGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnName("created");

                    b.Property<long?>("CreatedUserId")
                        .HasColumnName("created_user_id");

                    b.Property<long?>("ExerciseId")
                        .HasColumnName("exercise_id");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_muscle_groups");

                    b.HasIndex("CreatedUserId")
                        .HasName("ix_muscle_groups_created_user_id");

                    b.HasIndex("ExerciseId")
                        .HasName("ix_muscle_groups_exercise_id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("ix_muscle_groups_name");

                    b.ToTable("muscle_groups");
                });

            modelBuilder.Entity("DoYouEvenLiftBro.DAL.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnName("normalized_name")
                        .HasMaxLength(256);

                    b.HasKey("Id")
                        .HasName("pk_asp_net_roles");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("role_name_index");

                    b.ToTable("asp_net_roles");
                });

            modelBuilder.Entity("DoYouEvenLiftBro.DAL.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnName("access_failed_count");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnName("email_confirmed");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnName("lockout_end");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnName("normalized_email")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnName("normalized_user_name")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("SecurityStamp")
                        .HasColumnName("security_stamp");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasColumnName("user_name")
                        .HasMaxLength(256);

                    b.HasKey("Id")
                        .HasName("pk_asp_net_users");

                    b.HasIndex("NormalizedEmail")
                        .HasName("email_index");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("user_name_index");

                    b.ToTable("asp_net_users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value");

                    b.Property<long>("RoleId")
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_role_claims");

                    b.HasIndex("RoleId")
                        .HasName("ix_asp_net_role_claims_role_id");

                    b.ToTable("asp_net_role_claims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ClaimType")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnName("claim_value");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_asp_net_user_claims");

                    b.HasIndex("UserId")
                        .HasName("ix_asp_net_user_claims_user_id");

                    b.ToTable("asp_net_user_claims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider");

                    b.Property<string>("ProviderKey")
                        .HasColumnName("provider_key");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnName("provider_display_name");

                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("pk_asp_net_user_logins");

                    b.HasIndex("UserId")
                        .HasName("ix_asp_net_user_logins_user_id");

                    b.ToTable("asp_net_user_logins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.Property<long>("RoleId")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_asp_net_user_roles");

                    b.HasIndex("RoleId")
                        .HasName("ix_asp_net_user_roles_role_id");

                    b.ToTable("asp_net_user_roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnName("user_id");

                    b.Property<string>("LoginProvider")
                        .HasColumnName("login_provider");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasColumnName("value");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("pk_asp_net_user_tokens");

                    b.ToTable("asp_net_user_tokens");
                });

            modelBuilder.Entity("DoYouEvenLiftBro.DAL.Entities.Exercise", b =>
                {
                    b.HasOne("DoYouEvenLiftBro.DAL.Entities.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId")
                        .HasConstraintName("fk_exercises_asp_net_users_created_user_id");
                });

            modelBuilder.Entity("DoYouEvenLiftBro.DAL.Entities.MuscleGroup", b =>
                {
                    b.HasOne("DoYouEvenLiftBro.DAL.Entities.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId")
                        .HasConstraintName("fk_muscle_groups_asp_net_users_created_user_id");

                    b.HasOne("DoYouEvenLiftBro.DAL.Entities.Exercise")
                        .WithMany("MuscleGroups")
                        .HasForeignKey("ExerciseId")
                        .HasConstraintName("fk_muscle_groups_exercises_exercise_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("DoYouEvenLiftBro.DAL.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_asp_net_role_claims_asp_net_roles_role_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("DoYouEvenLiftBro.DAL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_asp_net_user_claims_asp_net_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("DoYouEvenLiftBro.DAL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_asp_net_user_logins_asp_net_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("DoYouEvenLiftBro.DAL.Entities.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("fk_asp_net_user_roles_asp_net_roles_role_id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DoYouEvenLiftBro.DAL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_asp_net_user_roles_asp_net_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("DoYouEvenLiftBro.DAL.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("fk_asp_net_user_tokens_asp_net_users_user_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}