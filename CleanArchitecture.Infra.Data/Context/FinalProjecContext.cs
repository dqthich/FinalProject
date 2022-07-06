using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Infra.Context
{
    public class FinalProjecContext : DbContext
    {
        public FinalProjecContext(DbContextOptions<FinalProjecContext> options)
           : base(options)
        {
            Database.Migrate();
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectMember> ProjectMembers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Domain.Models.Task> Tasks { get; set; }
    }
}
