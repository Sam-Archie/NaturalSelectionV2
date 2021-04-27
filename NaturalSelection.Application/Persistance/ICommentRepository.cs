﻿using NaturalSelection.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalSelection.Application.Persistance
{
    public interface ICommentRepository : IAsyncRepository<Comment>
    {
    }
}