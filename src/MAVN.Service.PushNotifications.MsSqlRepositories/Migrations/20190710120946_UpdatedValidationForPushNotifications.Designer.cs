// <auto-generated />
using System;
using MAVN.Service.PushNotifications.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAVN.Service.PushNotifications.MsSqlRepositories.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190710120946_UpdatedValidationForPushNotifications")]
    partial class UpdatedValidationForPushNotifications
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("push_notifications")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAVN.Service.PushNotifications.Domain.PushNotificationRegistration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("newid()");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("InfobipToken")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("SYSUTCDATETIME()");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("push_notification_registrations");
                });
#pragma warning restore 612, 618
        }
    }
}
