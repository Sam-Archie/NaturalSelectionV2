using NaturalSelection.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Domain.Entities
{
    public class ApplicationUser : AuditableEntity
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Forum> Forums { get; set; } = new List<Forum>();
        public List<CommentReplies> Replies { get; set; } = new List<CommentReplies>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
