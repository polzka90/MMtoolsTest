using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class MMtoolsContext: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}