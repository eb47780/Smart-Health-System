﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("Domain.Allergy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Causes")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommonFoodTriggers")
                        .HasColumnType("TEXT");

                    b.Property<string>("Info")
                        .HasColumnType("TEXT");

                    b.Property<string>("NaturalRemedies")
                        .HasColumnType("TEXT");

                    b.Property<string>("Treatments")
                        .HasColumnType("TEXT");

                    b.Property<string>("doctorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.ToTable("Allergies");
                });

            modelBuilder.Entity("Domain.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AppUser");
                });

            modelBuilder.Entity("Domain.Appointments", b =>
                {
                    b.Property<Guid>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dateOfAppointment")
                        .HasColumnType("TEXT");

                    b.Property<string>("doctorNameId")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentId");

                    b.HasIndex("doctorNameId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Domain.Height", b =>
                {
                    b.Property<Guid>("heightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("myHeight")
                        .HasColumnType("REAL");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("heightId");

                    b.HasIndex("patientId");

                    b.ToTable("Heights");
                });

            modelBuilder.Entity("Domain.LabResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProblemProportion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Result")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResultProportion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sample")
                        .HasColumnType("TEXT");

                    b.Property<string>("doctorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.Property<string>("status")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.ToTable("LabResults");
                });

            modelBuilder.Entity("Domain.Prescription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Dose")
                        .HasColumnType("TEXT");

                    b.Property<string>("Frequency")
                        .HasColumnType("TEXT");

                    b.Property<string>("Medication")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Prescribed")
                        .HasColumnType("TEXT");

                    b.Property<string>("Provider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("doctorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("Domain.Vitals", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("bloodPressure")
                        .HasColumnType("REAL");

                    b.Property<double>("bodyTemperature")
                        .HasColumnType("REAL");

                    b.Property<int>("heartRate")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Vitals");
                });

            modelBuilder.Entity("Domain.WaterIntake", b =>
                {
                    b.Property<Guid>("waterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("literPerHour")
                        .HasColumnType("INTEGER");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("waterId");

                    b.HasIndex("patientId");

                    b.ToTable("WaterIntakes");
                });

            modelBuilder.Entity("Domain.Weight", b =>
                {
                    b.Property<Guid>("weightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("myWeight")
                        .HasColumnType("REAL");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("weightId");

                    b.HasIndex("patientId");

                    b.ToTable("Weights");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Doctor", b =>
                {
                    b.HasBaseType("Domain.AppUser");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Education")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Qualification")
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialization")
                        .HasColumnType("TEXT");

                    b.Property<int?>("YearsExperience")
                        .HasColumnType("INTEGER");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("Domain.Patient", b =>
                {
                    b.HasBaseType("Domain.AppUser");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("Patient_BirthDate");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT")
                        .HasColumnName("Patient_LastName");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("Patient_Name");

                    b.Property<string>("Profession")
                        .HasColumnType("TEXT");

                    b.Property<string>("doctorId")
                        .HasColumnType("TEXT");

                    b.HasIndex("doctorId");

                    b.HasDiscriminator().HasValue("Patient");
                });

            modelBuilder.Entity("Domain.Allergy", b =>
                {
                    b.HasOne("Domain.Doctor", "doctor")
                        .WithMany("postingAllergies")
                        .HasForeignKey("doctorId");

                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("Allergies")
                        .HasForeignKey("patientId");

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Domain.Appointments", b =>
                {
                    b.HasOne("Domain.Doctor", "doctorName")
                        .WithMany()
                        .HasForeignKey("doctorNameId");

                    b.Navigation("doctorName");
                });

            modelBuilder.Entity("Domain.Height", b =>
                {
                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("Height")
                        .HasForeignKey("patientId");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Domain.LabResult", b =>
                {
                    b.HasOne("Domain.Doctor", "doctor")
                        .WithMany("PostingResults")
                        .HasForeignKey("doctorId");

                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("LabResults")
                        .HasForeignKey("patientId");

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Domain.Prescription", b =>
                {
                    b.HasOne("Domain.Doctor", "doctor")
                        .WithMany("Prescribed")
                        .HasForeignKey("doctorId");

                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("patientId");

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Domain.WaterIntake", b =>
                {
                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("WaterIntake")
                        .HasForeignKey("patientId");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Domain.Weight", b =>
                {
                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("Weight")
                        .HasForeignKey("patientId");

                    b.Navigation("patient");
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
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
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

                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Patient", b =>
                {
                    b.HasOne("Domain.Doctor", "doctor")
                        .WithMany("Patients")
                        .HasForeignKey("doctorId");

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("Domain.Doctor", b =>
                {
                    b.Navigation("Patients");

                    b.Navigation("postingAllergies");

                    b.Navigation("PostingResults");

                    b.Navigation("Prescribed");
                });

            modelBuilder.Entity("Domain.Patient", b =>
                {
                    b.Navigation("Allergies");

                    b.Navigation("Height");

                    b.Navigation("LabResults");

                    b.Navigation("Prescriptions");

                    b.Navigation("WaterIntake");

                    b.Navigation("Weight");
                });
#pragma warning restore 612, 618
        }
    }
}
