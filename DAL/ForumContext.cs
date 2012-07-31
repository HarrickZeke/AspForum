using System;
using System.Collections.Generic;
using System.Data.Entity;
using AspForum.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AspForum.DAL
{
    public class ForumContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}