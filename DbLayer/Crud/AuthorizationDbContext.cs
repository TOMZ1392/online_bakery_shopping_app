using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBakeryShopper.Models.Authorization;
using TheBakeryShopper.Models.Users;

namespace TheBakeryShopper.DbLayer.Crud
{
    public class AuthorizationDbContext:DbContext
    {

        public AuthorizationDbContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<ActionRole> ActionRoles { get; set; }
        public DbSet<LoginDetails> ApplicationUsers { get; set; }
    }
}
