using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using NaturalSelection.Domain.Entities;
using NaturalSelection.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Identity
{
    public class NaturalSelectionIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public NaturalSelectionIdentityDbContext()
        {

        }
    }
}
