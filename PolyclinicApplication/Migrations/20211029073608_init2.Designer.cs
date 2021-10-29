﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolyclinicApplication.Data.Models;

namespace PolyclinicApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211029073608_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PolyclinicApplication.Data.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("PolyclinicApplication.Data.Models.MedicineCard", b =>
                {
                    b.Property<int>("MedicineCardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfDiagnosis")
                        .HasColumnType("datetime2");

                    b.Property<string>("Disease")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("MethodOfTreatment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("MedicineCardId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("MedicineCards");
                });

            modelBuilder.Entity("PolyclinicApplication.Data.Models.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PassportDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PassportExtraditionPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PolyclinicApplication.Data.Models.Reception", b =>
                {
                    b.Property<int>("ReceptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfAssignment")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("HealthComplaint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("ReceptionId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Receptions");
                });

            modelBuilder.Entity("PolyclinicApplication.Data.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FridayEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FridayStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MondayEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MondayStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SaturdayEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SaturdayStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SundayEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SundayStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThursdayEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThursdayStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TuesdayEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TuesdayStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WednesdayEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WednesdayStart")
                        .HasColumnType("datetime2");

                    b.HasKey("ScheduleId");

                    b.HasIndex("DoctorId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("PolyclinicApplication.Data.Models.Specialization", b =>
                {
                    b.Property<int>("SpecializationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecializationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecializationId");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("PolyclinicApplication.Data.Models.Doctor", b =>
                {
                    b.HasOne("PolyclinicApplication.Data.Models.Specialization", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("PolyclinicApplication.Data.Models.MedicineCard", b =>
                {
                    b.HasOne("PolyclinicApplication.Data.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolyclinicApplication.Data.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PolyclinicApplication.Data.Models.Reception", b =>
                {
                    b.HasOne("PolyclinicApplication.Data.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PolyclinicApplication.Data.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PolyclinicApplication.Data.Models.Schedule", b =>
                {
                    b.HasOne("PolyclinicApplication.Data.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });
#pragma warning restore 612, 618
        }
    }
}