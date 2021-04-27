using Microsoft.EntityFrameworkCore;
using NaturalSelection.Domain.Entities;
using NaturalSelection.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Persistance
{
    public class NaturalSelectionDbContext : DbContext
    {
        public NaturalSelectionDbContext(DbContextOptions<NaturalSelectionDbContext> options) : base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<CommentReply> CommentReplies { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Forum> Forums { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
