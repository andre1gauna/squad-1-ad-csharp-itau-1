﻿using ItaLog.Data.Maps;
using ItaLog.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ItaLog.Data.Context
{
    public class ItaLogContext : DbContext
    {
        public ItaLogContext(DbContextOptions<ItaLogContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Environment> Environments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new LogMap());
            modelBuilder.ApplyConfiguration(new LevelMap());
            modelBuilder.ApplyConfiguration(new EnvironmentMap());
            modelBuilder.ApplyConfiguration(new EventMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserRoleMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

