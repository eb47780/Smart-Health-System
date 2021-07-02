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
                .HasAnnotation("ProductVersion", "5.0.7");

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

            modelBuilder.Entity("Domain.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Place")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReasonOfVisit")
                        .HasColumnType("TEXT");

                    b.Property<string>("doctorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Domain.CBC", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float>("BandForms")
                        .HasColumnType("REAL");

                    b.Property<float>("Basoghilis")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<float>("Hematocrit")
                        .HasColumnType("REAL");

                    b.Property<float>("Hemoglobin")
                        .HasColumnType("REAL");

                    b.Property<float>("Lymphocytes")
                        .HasColumnType("REAL");

                    b.Property<float>("Monocytes")
                        .HasColumnType("REAL");

                    b.Property<float>("PlateletCount")
                        .HasColumnType("REAL");

                    b.Property<float>("SegmentedNeutrofilis")
                        .HasColumnType("REAL");

                    b.Property<float>("WBC")
                        .HasColumnType("REAL");

                    b.Property<string>("doctorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.ToTable("CBCs");
                });

            modelBuilder.Entity("Domain.Height", b =>
                {
                    b.Property<Guid>("heightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<float>("myHeight")
                        .HasColumnType("REAL");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("heightId");

                    b.HasIndex("patientId");

                    b.ToTable("Heights");
                });

            modelBuilder.Entity("Domain.LiverPanel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float>("AlkalinePhosPhatase")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<float>("DirectBiliRubin")
                        .HasColumnType("REAL");

                    b.Property<float>("SGOT")
                        .HasColumnType("REAL");

                    b.Property<float>("SGPT")
                        .HasColumnType("REAL");

                    b.Property<float>("TotalBiliRubin")
                        .HasColumnType("REAL");

                    b.Property<string>("doctorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.ToTable("LiverPanels");
                });

            modelBuilder.Entity("Domain.MetabolicPanel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float>("Albumin")
                        .HasColumnType("REAL");

                    b.Property<float>("Bun")
                        .HasColumnType("REAL");

                    b.Property<float>("Calcium")
                        .HasColumnType("REAL");

                    b.Property<float>("CarbonDioxide")
                        .HasColumnType("REAL");

                    b.Property<float>("Globulin")
                        .HasColumnType("REAL");

                    b.Property<float>("Glucose")
                        .HasColumnType("REAL");

                    b.Property<float>("Protein")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("doctorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.ToTable("MetabolicPanels");
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

            modelBuilder.Entity("Domain.Symptoms", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Result")
                        .HasColumnType("TEXT");

                    b.Property<string>("Symptom1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Symptom2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Symptom3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Symptom4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Symptom5")
                        .HasColumnType("TEXT");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("patientId");

                    b.ToTable("Symptoms");
                });

            modelBuilder.Entity("Domain.Urinalysis", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<float>("BloodUreaNitrogen")
                        .HasColumnType("REAL");

                    b.Property<float>("Calcium")
                        .HasColumnType("REAL");

                    b.Property<float>("Chloride")
                        .HasColumnType("REAL");

                    b.Property<float>("Creatinine")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<float>("FastingGlucose")
                        .HasColumnType("REAL");

                    b.Property<float>("HCO3")
                        .HasColumnType("REAL");

                    b.Property<float>("Magnesium")
                        .HasColumnType("REAL");

                    b.Property<float>("Phosphate")
                        .HasColumnType("REAL");

                    b.Property<float>("Potassium")
                        .HasColumnType("REAL");

                    b.Property<float>("Sodium")
                        .HasColumnType("REAL");

                    b.Property<string>("doctorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.ToTable("UrinalysisList");
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

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<int>("heartRate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("patientId");

                    b.ToTable("Vitals");
                });

            modelBuilder.Entity("Domain.WaterIntake", b =>
                {
                    b.Property<Guid>("waterintakeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<float>("literPerHour")
                        .HasColumnType("REAL");

                    b.Property<string>("patientId")
                        .HasColumnType("TEXT");

                    b.HasKey("waterintakeId");

                    b.HasIndex("patientId");

                    b.ToTable("WaterIntakes");
                });

            modelBuilder.Entity("Domain.Weight", b =>
                {
                    b.Property<Guid>("weightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<float>("myWeight")
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

                    b.Property<string>("Area")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("Patient_BirthDate");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Information")
                        .HasColumnType("TEXT");

                    b.Property<string>("Language")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT")
                        .HasColumnName("Patient_LastName");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasColumnName("Patient_Name");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

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

            modelBuilder.Entity("Domain.Appointment", b =>
                {
                    b.HasOne("Domain.Doctor", "doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("doctorId");

                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("Appointments")
                        .HasForeignKey("patientId");

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Domain.CBC", b =>
                {
                    b.HasOne("Domain.Doctor", "doctor")
                        .WithMany("CBCsAdded")
                        .HasForeignKey("doctorId");

                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("CBCs")
                        .HasForeignKey("patientId");

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Domain.Height", b =>
                {
                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("Height")
                        .HasForeignKey("patientId");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Domain.LiverPanel", b =>
                {
                    b.HasOne("Domain.Doctor", "doctor")
                        .WithMany("LiverPanelsAdded")
                        .HasForeignKey("doctorId");

                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("LiverPanels")
                        .HasForeignKey("patientId");

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Domain.MetabolicPanel", b =>
                {
                    b.HasOne("Domain.Doctor", "doctor")
                        .WithMany("MetabolicPanelsAdded")
                        .HasForeignKey("doctorId");

                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("MetabolicPanels")
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

            modelBuilder.Entity("Domain.Symptoms", b =>
                {
                    b.HasOne("Domain.Patient", null)
                        .WithMany("Symptoms")
                        .HasForeignKey("patientId");
                });

            modelBuilder.Entity("Domain.Urinalysis", b =>
                {
                    b.HasOne("Domain.Doctor", "doctor")
                        .WithMany("UrinalysisListAdded")
                        .HasForeignKey("doctorId");

                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("UrinalysisList")
                        .HasForeignKey("patientId");

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Domain.Vitals", b =>
                {
                    b.HasOne("Domain.Patient", "patient")
                        .WithMany("Vitals")
                        .HasForeignKey("patientId");

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
                    b.Navigation("Appointments");

                    b.Navigation("CBCsAdded");

                    b.Navigation("LiverPanelsAdded");

                    b.Navigation("MetabolicPanelsAdded");

                    b.Navigation("Patients");

                    b.Navigation("postingAllergies");

                    b.Navigation("Prescribed");

                    b.Navigation("UrinalysisListAdded");
                });

            modelBuilder.Entity("Domain.Patient", b =>
                {
                    b.Navigation("Allergies");

                    b.Navigation("Appointments");

                    b.Navigation("CBCs");

                    b.Navigation("Height");

                    b.Navigation("LiverPanels");

                    b.Navigation("MetabolicPanels");

                    b.Navigation("Prescriptions");

                    b.Navigation("Symptoms");

                    b.Navigation("UrinalysisList");

                    b.Navigation("Vitals");

                    b.Navigation("WaterIntake");

                    b.Navigation("Weight");
                });
#pragma warning restore 612, 618
        }
    }
}
