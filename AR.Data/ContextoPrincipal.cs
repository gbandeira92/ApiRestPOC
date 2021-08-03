using System;
using Microsoft.EntityFrameworkCore;

namespace AR.Data
{
    public class ContextoPrincipal : DbContext
    {
        public ContextoPrincipal(DbContextOptions options)
            : base(options);
    }
}
