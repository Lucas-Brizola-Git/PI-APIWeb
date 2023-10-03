﻿using APILogin.Models;
using Microsoft.EntityFrameworkCore;

namespace APILogin.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base( options ) { }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
