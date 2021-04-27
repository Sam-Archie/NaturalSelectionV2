﻿using NaturalSelection.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Domain.Entities
{
    public class Forum : AuditableEntity
    {
        public Guid ForumId { get; set; }
        public string Name { get; set; }
        public bool IsPrivate { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}
