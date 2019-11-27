﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiDevMedia.Models
{
    public class DevMediaContext: DbContext
    {
        public DevMediaContext() : base("DevMediaLocal")
        {
            
        }

        public DbSet<Curso> Cursos { get; set; }
    }
}