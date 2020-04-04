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
    [Migration("20191127141908_RenamedSentTimestamp")]
    partial class RenamedSentTimestamp
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

            modelBuilder.Entity("MAVN.Service.PushNotifications.MsSqlRepositories.Entities.NotificationMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CreationTimestamp")
                        .HasColumnName("creation_timestamp");

                    b.Property<string>("CustomPayload")
                        .IsRequired()
                        .HasColumnName("custom_payload")
                        .HasMaxLength(4000);

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id")
                        .HasMaxLength(50);

                    b.Property<bool>("IsRead")
                        .HasColumnName("is_read");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnName("message")
                        .HasMaxLength(10000);

                    b.Property<string>("MessageGroupId")
                        .IsRequired()
                        .HasColumnName("message_group_id")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CreationTimestamp");

                    b.HasIndex("CustomerId");

                    b.HasIndex("IsRead");

                    b.HasIndex("MessageGroupId");

                    b.ToTable("NotificationMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
