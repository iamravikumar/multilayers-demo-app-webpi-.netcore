﻿using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Models;
using MyMusic.Data.Configurations;

namespace MyMusic.Data
{
    public class MyMusicDbContext : DbContext
    {
        public MyMusicDbContext(DbContextOptions<MyMusicDbContext> options) : base(options)
        { }

        public DbSet<Music> Musics { get; set; }
        public DbSet<Artist> Artists { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new MusicConfiguration());

            builder
                .ApplyConfiguration(new ArtistConfiguration());
        }
    }
}
