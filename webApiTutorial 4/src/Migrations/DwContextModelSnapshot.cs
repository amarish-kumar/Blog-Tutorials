﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using webApiTutorial.DatabaseContexts;

namespace webApiTutorial.Migrations
{
    [DbContext(typeof(DwContext))]
    partial class DwContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("webApiTutorial.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BookDescription");

                    b.Property<string>("BookIsbn10");

                    b.Property<string>("BookIsbn13");

                    b.Property<string>("BookName");

                    b.Property<int>("BookOrdinal");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("webApiTutorial.Models.BookCharacter", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("CharacterId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.HasKey("BookId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("BookCharacters");
                });

            modelBuilder.Entity("webApiTutorial.Models.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CharacterName");

                    b.Property<int>("CharacterOrdinal");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("webApiTutorial.Models.BookCharacter", b =>
                {
                    b.HasOne("webApiTutorial.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("webApiTutorial.Models.Character", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
