using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Domain.Entities
{
    public class ForumUsers
    {
        public Guid UserId { get; set; }
        public Guid ForumId { get; set; }
    }
}
