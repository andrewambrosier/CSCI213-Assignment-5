using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSCI213___Assignment_5.Models;

namespace CSCI213___Assignment_5.Data
{
    public class CSCI213___Assignment_5Context : DbContext
    {
        public CSCI213___Assignment_5Context (DbContextOptions<CSCI213___Assignment_5Context> options)
            : base(options)
        {
        }

        public DbSet<Song> Song { get; set; } = default!;

        public DbSet<MusicGenre> MusicGenre { get; set; } = default!;
    }
}
