﻿// <auto-generated />
using Gossip.SQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace Gossip.SQLite.Migrations
{
    [DbContext(typeof(GossipContext))]
    [Migration("20170912074618_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Gossip.Domain.Models.Chat.Channel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Channels");
                });

            modelBuilder.Entity("Gossip.Domain.Models.Chat.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ChannelId");

                    b.Property<string>("Content");

                    b.Property<int>("Likes");

                    b.Property<int?>("ParentId");

                    b.HasKey("Id");

                    b.HasIndex("ChannelId");

                    b.HasIndex("ParentId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Gossip.Domain.Models.Chat.Message", b =>
                {
                    b.HasOne("Gossip.Domain.Models.Chat.Channel")
                        .WithMany("Messages")
                        .HasForeignKey("ChannelId");

                    b.HasOne("Gossip.Domain.Models.Chat.Message", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });
#pragma warning restore 612, 618
        }
    }
}