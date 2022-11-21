﻿// <auto-generated />
using System;
using Conectify.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Conectify.Database.Migrations;

[DbContext(typeof(ConectifyDb))]
[Migration("20221024041721_CoordsForRules")]
partial class CoordsForRules
{
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "6.0.10")
            .HasAnnotation("Relational:MaxIdentifierLength", 63);

        NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

        modelBuilder.Entity("Conectify.Database.Models.ActivityService.Rule", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<Guid?>("DestinationActuatorId")
                    .HasColumnType("uuid");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<string>("ParametersJson")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<Guid>("RuleType")
                    .HasColumnType("uuid");

                b.Property<Guid?>("SourceSensorId")
                    .HasColumnType("uuid");

                b.Property<int>("X")
                    .HasColumnType("integer");

                b.Property<int>("Y")
                    .HasColumnType("integer");

                b.HasKey("Id");

                b.HasIndex("DestinationActuatorId");

                b.HasIndex("SourceSensorId");

                b.ToTable("Rules");
            });

        modelBuilder.Entity("Conectify.Database.Models.ActivityService.RuleConnector", b =>
            {
                b.Property<Guid>("PreviousRuleId")
                    .HasColumnType("uuid");

                b.Property<Guid>("ContinuingRuleId")
                    .HasColumnType("uuid");

                b.HasKey("PreviousRuleId", "ContinuingRuleId");

                b.HasIndex("ContinuingRuleId");

                b.ToTable("RuleConnector");
            });

        modelBuilder.Entity("Conectify.Database.Models.Actuator", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<bool>("IsKnown")
                    .HasColumnType("boolean");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<Guid>("SensorId")
                    .HasColumnType("uuid");

                b.Property<Guid>("SourceDeviceId")
                    .HasColumnType("uuid");

                b.HasKey("Id");

                b.HasIndex("SensorId");

                b.HasIndex("SourceDeviceId");

                b.ToTable("Actuators");
            });

        modelBuilder.Entity("Conectify.Database.Models.Device", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<string>("IPAdress")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<bool>("IsKnown")
                    .HasColumnType("boolean");

                b.Property<string>("MacAdress")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<Guid?>("PositionId")
                    .HasColumnType("uuid");

                b.Property<bool>("SubscribeToAll")
                    .HasColumnType("boolean");

                b.HasKey("Id");

                b.HasIndex("PositionId");

                b.ToTable("Devices");
            });

        modelBuilder.Entity("Conectify.Database.Models.Metadata", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.ToTable("Metadatas");
            });

        modelBuilder.Entity("Conectify.Database.Models.MetadataConnector<Conectify.Database.Models.Actuator>", b =>
            {
                b.Property<Guid>("DeviceId")
                    .HasColumnType("uuid");

                b.Property<Guid>("MetadataId")
                    .HasColumnType("uuid");

                b.Property<float?>("MaxVal")
                    .HasColumnType("real");

                b.Property<float?>("MinVal")
                    .HasColumnType("real");

                b.Property<float?>("NumericValue")
                    .HasColumnType("real");

                b.Property<string>("StringValue")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<int?>("TypeValue")
                    .HasColumnType("integer");

                b.Property<string>("Unit")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("DeviceId", "MetadataId");

                b.HasIndex("MetadataId");

                b.ToTable("ActuatorMetadatas");
            });

        modelBuilder.Entity("Conectify.Database.Models.MetadataConnector<Conectify.Database.Models.Device>", b =>
            {
                b.Property<Guid>("DeviceId")
                    .HasColumnType("uuid");

                b.Property<Guid>("MetadataId")
                    .HasColumnType("uuid");

                b.Property<float?>("MaxVal")
                    .HasColumnType("real");

                b.Property<float?>("MinVal")
                    .HasColumnType("real");

                b.Property<float?>("NumericValue")
                    .HasColumnType("real");

                b.Property<string>("StringValue")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<int?>("TypeValue")
                    .HasColumnType("integer");

                b.Property<string>("Unit")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("DeviceId", "MetadataId");

                b.HasIndex("MetadataId");

                b.ToTable("DeviceMetadata");
            });

        modelBuilder.Entity("Conectify.Database.Models.MetadataConnector<Conectify.Database.Models.Sensor>", b =>
            {
                b.Property<Guid>("DeviceId")
                    .HasColumnType("uuid");

                b.Property<Guid>("MetadataId")
                    .HasColumnType("uuid");

                b.Property<float?>("MaxVal")
                    .HasColumnType("real");

                b.Property<float?>("MinVal")
                    .HasColumnType("real");

                b.Property<float?>("NumericValue")
                    .HasColumnType("real");

                b.Property<string>("StringValue")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<int?>("TypeValue")
                    .HasColumnType("integer");

                b.Property<string>("Unit")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("DeviceId", "MetadataId");

                b.HasIndex("MetadataId");

                b.ToTable("SensorMetadata");
            });

        modelBuilder.Entity("Conectify.Database.Models.Position", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<float>("Lat")
                    .HasColumnType("real");

                b.Property<float>("Long")
                    .HasColumnType("real");

                b.HasKey("Id");

                b.ToTable("Position");
            });

        modelBuilder.Entity("Conectify.Database.Models.Preference", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<Guid?>("ActuatorId")
                    .HasColumnType("uuid");

                b.Property<Guid?>("DeviceId")
                    .HasColumnType("uuid");

                b.Property<Guid?>("SensorId")
                    .HasColumnType("uuid");

                b.Property<bool>("SubToActionResponse")
                    .HasColumnType("boolean");

                b.Property<bool>("SubToActions")
                    .HasColumnType("boolean");

                b.Property<bool>("SubToCommandResponse")
                    .HasColumnType("boolean");

                b.Property<bool>("SubToCommands")
                    .HasColumnType("boolean");

                b.Property<bool>("SubToValues")
                    .HasColumnType("boolean");

                b.Property<Guid>("SubscriberId")
                    .HasColumnType("uuid");

                b.HasKey("Id");

                b.HasIndex("ActuatorId");

                b.HasIndex("DeviceId");

                b.HasIndex("SensorId");

                b.HasIndex("SubscriberId");

                b.ToTable("Preference");
            });

        modelBuilder.Entity("Conectify.Database.Models.Sensor", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<bool>("IsKnown")
                    .HasColumnType("boolean");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<Guid>("SourceDeviceId")
                    .HasColumnType("uuid");

                b.HasKey("Id");

                b.HasIndex("SourceDeviceId");

                b.ToTable("Sensors");
            });

        modelBuilder.Entity("Conectify.Database.Models.Values.Action", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<Guid?>("DestinationId")
                    .HasColumnType("uuid");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<float?>("NumericValue")
                    .HasColumnType("real");

                b.Property<Guid>("SourceId")
                    .HasColumnType("uuid");

                b.Property<string>("StringValue")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<long>("TimeCreated")
                    .HasColumnType("bigint");

                b.Property<string>("Unit")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.HasIndex("DestinationId");

                b.HasIndex("SourceId");

                b.ToTable("Actions");
            });

        modelBuilder.Entity("Conectify.Database.Models.Values.ActionResponse", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<Guid>("ActionId1")
                    .HasColumnType("uuid");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<float?>("NumericValue")
                    .HasColumnType("real");

                b.Property<Guid>("SourceId")
                    .HasColumnType("uuid");

                b.Property<string>("StringValue")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<long>("TimeCreated")
                    .HasColumnType("bigint");

                b.Property<string>("Unit")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.HasIndex("ActionId1");

                b.HasIndex("SourceId");

                b.ToTable("ActionResponses");
            });

        modelBuilder.Entity("Conectify.Database.Models.Values.Command", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<Guid>("DestinationId")
                    .HasColumnType("uuid");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<float?>("NumericValue")
                    .HasColumnType("real");

                b.Property<Guid>("SourceId")
                    .HasColumnType("uuid");

                b.Property<string>("StringValue")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<long>("TimeCreated")
                    .HasColumnType("bigint");

                b.Property<string>("Unit")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.HasIndex("DestinationId");

                b.HasIndex("SourceId");

                b.ToTable("Commands");
            });

        modelBuilder.Entity("Conectify.Database.Models.Values.CommandResponse", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<Guid>("CommandId")
                    .HasColumnType("uuid");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<float?>("NumericValue")
                    .HasColumnType("real");

                b.Property<Guid>("SourceId")
                    .HasColumnType("uuid");

                b.Property<string>("StringValue")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<long>("TimeCreated")
                    .HasColumnType("bigint");

                b.Property<string>("Unit")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.HasIndex("CommandId");

                b.HasIndex("SourceId");

                b.ToTable("CommandResponses");
            });

        modelBuilder.Entity("Conectify.Database.Models.Values.Value", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("uuid");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<float?>("NumericValue")
                    .HasColumnType("real");

                b.Property<Guid>("SourceId")
                    .HasColumnType("uuid");

                b.Property<string>("StringValue")
                    .IsRequired()
                    .HasColumnType("text");

                b.Property<long>("TimeCreated")
                    .HasColumnType("bigint");

                b.Property<string>("Unit")
                    .IsRequired()
                    .HasColumnType("text");

                b.HasKey("Id");

                b.HasIndex("SourceId");

                b.ToTable("Values");
            });

        modelBuilder.Entity("Conectify.Database.Models.ActivityService.Rule", b =>
            {
                b.HasOne("Conectify.Database.Models.Actuator", "DestinationActuator")
                    .WithMany()
                    .HasForeignKey("DestinationActuatorId");

                b.HasOne("Conectify.Database.Models.Sensor", "SourceSensor")
                    .WithMany()
                    .HasForeignKey("SourceSensorId");

                b.Navigation("DestinationActuator");

                b.Navigation("SourceSensor");
            });

        modelBuilder.Entity("Conectify.Database.Models.ActivityService.RuleConnector", b =>
            {
                b.HasOne("Conectify.Database.Models.ActivityService.Rule", "ContinuingRule")
                    .WithMany("ContinuingRules")
                    .HasForeignKey("ContinuingRuleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Conectify.Database.Models.ActivityService.Rule", "PreviousRule")
                    .WithMany("PreviousRules")
                    .HasForeignKey("PreviousRuleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("ContinuingRule");

                b.Navigation("PreviousRule");
            });

        modelBuilder.Entity("Conectify.Database.Models.Actuator", b =>
            {
                b.HasOne("Conectify.Database.Models.Sensor", "Sensor")
                    .WithMany()
                    .HasForeignKey("SensorId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Conectify.Database.Models.Device", "SourceDevice")
                    .WithMany("Actuators")
                    .HasForeignKey("SourceDeviceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Sensor");

                b.Navigation("SourceDevice");
            });

        modelBuilder.Entity("Conectify.Database.Models.Device", b =>
            {
                b.HasOne("Conectify.Database.Models.Position", "Position")
                    .WithMany()
                    .HasForeignKey("PositionId");

                b.Navigation("Position");
            });

        modelBuilder.Entity("Conectify.Database.Models.MetadataConnector<Conectify.Database.Models.Actuator>", b =>
            {
                b.HasOne("Conectify.Database.Models.Actuator", "Device")
                    .WithMany("Metadata")
                    .HasForeignKey("DeviceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Conectify.Database.Models.Metadata", "Metadata")
                    .WithMany()
                    .HasForeignKey("MetadataId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Device");

                b.Navigation("Metadata");
            });

        modelBuilder.Entity("Conectify.Database.Models.MetadataConnector<Conectify.Database.Models.Device>", b =>
            {
                b.HasOne("Conectify.Database.Models.Device", "Device")
                    .WithMany("Metadata")
                    .HasForeignKey("DeviceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Conectify.Database.Models.Metadata", "Metadata")
                    .WithMany()
                    .HasForeignKey("MetadataId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Device");

                b.Navigation("Metadata");
            });

        modelBuilder.Entity("Conectify.Database.Models.MetadataConnector<Conectify.Database.Models.Sensor>", b =>
            {
                b.HasOne("Conectify.Database.Models.Sensor", "Device")
                    .WithMany("Metadata")
                    .HasForeignKey("DeviceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Conectify.Database.Models.Metadata", "Metadata")
                    .WithMany()
                    .HasForeignKey("MetadataId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Device");

                b.Navigation("Metadata");
            });

        modelBuilder.Entity("Conectify.Database.Models.Preference", b =>
            {
                b.HasOne("Conectify.Database.Models.Actuator", "Actuator")
                    .WithMany()
                    .HasForeignKey("ActuatorId");

                b.HasOne("Conectify.Database.Models.Device", "Device")
                    .WithMany()
                    .HasForeignKey("DeviceId");

                b.HasOne("Conectify.Database.Models.Sensor", "Sensor")
                    .WithMany()
                    .HasForeignKey("SensorId");

                b.HasOne("Conectify.Database.Models.Device", "Subscriber")
                    .WithMany("Preferences")
                    .HasForeignKey("SubscriberId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Actuator");

                b.Navigation("Device");

                b.Navigation("Sensor");

                b.Navigation("Subscriber");
            });

        modelBuilder.Entity("Conectify.Database.Models.Sensor", b =>
            {
                b.HasOne("Conectify.Database.Models.Device", "SourceDevice")
                    .WithMany("Sensors")
                    .HasForeignKey("SourceDeviceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("SourceDevice");
            });

        modelBuilder.Entity("Conectify.Database.Models.Values.Action", b =>
            {
                b.HasOne("Conectify.Database.Models.Actuator", "Destination")
                    .WithMany()
                    .HasForeignKey("DestinationId");

                b.HasOne("Conectify.Database.Models.Sensor", "Source")
                    .WithMany()
                    .HasForeignKey("SourceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Destination");

                b.Navigation("Source");
            });

        modelBuilder.Entity("Conectify.Database.Models.Values.ActionResponse", b =>
            {
                b.HasOne("Conectify.Database.Models.Values.Action", "Action")
                    .WithMany()
                    .HasForeignKey("ActionId1")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Conectify.Database.Models.Actuator", "Source")
                    .WithMany()
                    .HasForeignKey("SourceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Action");

                b.Navigation("Source");
            });

        modelBuilder.Entity("Conectify.Database.Models.Values.Command", b =>
            {
                b.HasOne("Conectify.Database.Models.Device", "Destination")
                    .WithMany()
                    .HasForeignKey("DestinationId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Conectify.Database.Models.Device", "Source")
                    .WithMany()
                    .HasForeignKey("SourceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Destination");

                b.Navigation("Source");
            });

        modelBuilder.Entity("Conectify.Database.Models.Values.CommandResponse", b =>
            {
                b.HasOne("Conectify.Database.Models.Values.Command", "Command")
                    .WithMany()
                    .HasForeignKey("CommandId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Conectify.Database.Models.Device", "Source")
                    .WithMany()
                    .HasForeignKey("SourceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Command");

                b.Navigation("Source");
            });

        modelBuilder.Entity("Conectify.Database.Models.Values.Value", b =>
            {
                b.HasOne("Conectify.Database.Models.Sensor", "Source")
                    .WithMany()
                    .HasForeignKey("SourceId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Source");
            });

        modelBuilder.Entity("Conectify.Database.Models.ActivityService.Rule", b =>
            {
                b.Navigation("ContinuingRules");

                b.Navigation("PreviousRules");
            });

        modelBuilder.Entity("Conectify.Database.Models.Actuator", b =>
            {
                b.Navigation("Metadata");
            });

        modelBuilder.Entity("Conectify.Database.Models.Device", b =>
            {
                b.Navigation("Actuators");

                b.Navigation("Metadata");

                b.Navigation("Preferences");

                b.Navigation("Sensors");
            });

        modelBuilder.Entity("Conectify.Database.Models.Sensor", b =>
            {
                b.Navigation("Metadata");
            });
#pragma warning restore 612, 618
    }
}
