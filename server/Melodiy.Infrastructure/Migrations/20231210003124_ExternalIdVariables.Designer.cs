﻿// <auto-generated />
using System;
using Melodiy.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Melodiy.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231210003124_ExternalIdVariables")]
    partial class ExternalIdVariables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AlbumArtist", b =>
                {
                    b.Property<int>("AlbumsId")
                        .HasColumnType("integer");

                    b.Property<int>("ArtistsId")
                        .HasColumnType("integer");

                    b.HasKey("AlbumsId", "ArtistsId");

                    b.HasIndex("ArtistsId");

                    b.ToTable("AlbumArtist");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExternalSearchId")
                        .HasColumnType("text");

                    b.Property<int?>("ImageId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.Property<bool>("Verified")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("ExternalSearchId")
                        .IsUnique();

                    b.HasIndex("ImageId");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExternalSearchId")
                        .HasColumnType("text");

                    b.Property<int?>("ImageId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.Property<bool>("Verified")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("ExternalSearchId")
                        .IsUnique();

                    b.HasIndex("ImageId");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Path")
                        .HasColumnType("text");

                    b.Property<int>("Source")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ImageId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("boolean");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.PlaylistTrack", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("integer");

                    b.Property<int>("PlaylistId")
                        .HasColumnType("integer");

                    b.Property<int>("Position")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("TrackId", "PlaylistId", "Position");

                    b.HasIndex("PlaylistId");

                    b.ToTable("PlaylistTracks");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AlbumId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("ExternalSearchId")
                        .HasColumnType("text");

                    b.Property<string>("ExternalStreamId")
                        .HasColumnType("text");

                    b.Property<string>("FilePath")
                        .HasColumnType("text");

                    b.Property<int?>("ImageId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("boolean");

                    b.Property<int>("Position")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Source")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("Views")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("ExternalSearchId")
                        .IsUnique();

                    b.HasIndex("ImageId");

                    b.HasIndex("Slug")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.TrackArtist", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("integer");

                    b.Property<int>("ArtistId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsPrimary")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("TrackId", "ArtistId");

                    b.HasIndex("ArtistId");

                    b.ToTable("TracksArtists");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AlbumArtist", b =>
                {
                    b.HasOne("Melodiy.Domain.Entities.Album", null)
                        .WithMany()
                        .HasForeignKey("AlbumsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Melodiy.Domain.Entities.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Album", b =>
                {
                    b.HasOne("Melodiy.Domain.Entities.Image", "Image")
                        .WithMany("Albums")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Melodiy.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Artist", b =>
                {
                    b.HasOne("Melodiy.Domain.Entities.Image", "Image")
                        .WithMany("Artists")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Melodiy.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Image", b =>
                {
                    b.HasOne("Melodiy.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Playlist", b =>
                {
                    b.HasOne("Melodiy.Domain.Entities.Image", "Image")
                        .WithMany("Playlists")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Melodiy.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.PlaylistTrack", b =>
                {
                    b.HasOne("Melodiy.Domain.Entities.Playlist", "Playlist")
                        .WithMany("PlaylistTracks")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Melodiy.Domain.Entities.Track", "Track")
                        .WithMany("PlaylistTracks")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Playlist");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Track", b =>
                {
                    b.HasOne("Melodiy.Domain.Entities.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId");

                    b.HasOne("Melodiy.Domain.Entities.Image", "Image")
                        .WithMany("Tracks")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Melodiy.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Album");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.TrackArtist", b =>
                {
                    b.HasOne("Melodiy.Domain.Entities.Artist", "Artist")
                        .WithMany("TrackArtists")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Melodiy.Domain.Entities.Track", "Track")
                        .WithMany("TrackArtists")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Artist", b =>
                {
                    b.Navigation("TrackArtists");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Image", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Artists");

                    b.Navigation("Playlists");

                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Playlist", b =>
                {
                    b.Navigation("PlaylistTracks");
                });

            modelBuilder.Entity("Melodiy.Domain.Entities.Track", b =>
                {
                    b.Navigation("PlaylistTracks");

                    b.Navigation("TrackArtists");
                });
#pragma warning restore 612, 618
        }
    }
}
