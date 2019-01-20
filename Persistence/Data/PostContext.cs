using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data
{
    public class PostContext : IdentityDbContext<Author>
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        {}
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.Entity<Post>(ConfigurePost);
        }
        private void ConfigurePost(EntityTypeBuilder<Post> builder)
        {            
            builder.Property(p => p.Id).IsRequired();
            builder.Property(p => p.PublishedDateTime).IsRequired(true);
            builder.Property(p => p.Slug).IsRequired(true);
            builder.Property(p => p.Topic).IsRequired(true);
            builder.Property(p => p.Content).IsRequired(true);
        }
    }
}
