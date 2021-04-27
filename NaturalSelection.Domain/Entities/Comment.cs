using NaturalSelection.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Domain.Entities
{
    public class Comment : AuditableEntity
    {
        public Guid Id { get; set; }
        [ForeignKey("ApplicationUserName")]
        public string AppicationUserUserName { get; set; }
        public string Content { get; set; }
        public Post Post { get; set; }
        public int Likes { get; set; }
        public List<CommentReply> Replies { get; set; } = new List<CommentReply>();
    }
}
