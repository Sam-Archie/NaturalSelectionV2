using Microsoft.AspNetCore.Identity;
using NaturalSelection.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { 
            get
            {
                return $"{FirstName}, {LastName}";
            }
        }
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Forum> Forums { get; set; } = new List<Forum>();
        public List<CommentReply> Replies { get; set; } = new List<CommentReply>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
