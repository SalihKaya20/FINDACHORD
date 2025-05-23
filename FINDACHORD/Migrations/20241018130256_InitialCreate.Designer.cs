﻿// <auto-generated />
using System;
using FINDACHORD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FINDACHORD.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241018130256_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ChordSong", b =>
                {
                    b.Property<int>("ChordsChordId")
                        .HasColumnType("integer");

                    b.Property<int>("SongsSongId")
                        .HasColumnType("integer");

                    b.HasKey("ChordsChordId", "SongsSongId");

                    b.HasIndex("SongsSongId");

                    b.ToTable("ChordSong");
                });

            modelBuilder.Entity("FINDACHORD.Entity.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ArtistId"));

                    b.Property<string>("ArtistName")
                        .HasColumnType("text");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("FINDACHORD.Entity.Chord", b =>
                {
                    b.Property<int>("ChordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ChordId"));

                    b.Property<string>("ChordName")
                        .HasColumnType("text");

                    b.HasKey("ChordId");

                    b.ToTable("Chords");
                });

            modelBuilder.Entity("FINDACHORD.Entity.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SongId"));

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ArtistId")
                        .HasColumnType("integer");

                    b.Property<string>("LyricsWithChords")
                        .HasColumnType("text");

                    b.Property<string>("SongName")
                        .HasColumnType("text");

                    b.Property<int>("ViewCount")
                        .HasColumnType("integer");

                    b.HasKey("SongId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("ChordSong", b =>
                {
                    b.HasOne("FINDACHORD.Entity.Chord", null)
                        .WithMany()
                        .HasForeignKey("ChordsChordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FINDACHORD.Entity.Song", null)
                        .WithMany()
                        .HasForeignKey("SongsSongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FINDACHORD.Entity.Song", b =>
                {
                    b.HasOne("FINDACHORD.Entity.Artist", "Artist")
                        .WithMany("Songs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("FINDACHORD.Entity.Artist", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
