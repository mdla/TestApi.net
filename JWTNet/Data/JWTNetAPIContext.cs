using JWTNet.Models.CV;
using JWTNet.Models.Security;
using Microsoft.EntityFrameworkCore;
using System;

namespace JWTNet.API.Repository
{
    public class JWTNetAPIContext : DbContext
    {
        public JWTNetAPIContext(DbContextOptions<JWTNetAPIContext> options)
            : base(options)
        {
        }

        #region "Entidades"

        public DbSet<JWTNet.Models.CV.Category> Category { get; set; }
        public DbSet<JWTNet.Models.CV.Skill> Skill { get; set; }
        public DbSet<JWTNet.Models.CV.Job> Job { get; set; }

        public DbSet<JWTNet.Models.Security.User> User { get; set; }

        #endregion

        #region overrides

        /// <summary>
        /// Seed del proyecto
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { Id = Guid.NewGuid(), Nickname = "Mauro", Name = "Mauro", Lastname = "Luna Ayala", Email = "mauro.dario.luna.ayala@gmail.com", Rol = "adm" }
                );

            Category net = new Category() { Id = Guid.NewGuid(), Description = ".NET", Title=".NET", Image="net.png" };
            Category dbCategory = new Category() { Id = Guid.NewGuid(), Description = "Base de datos", Title = "Base de datos", Image = "db.png" };
            Category framework = new Category() { Id = Guid.NewGuid(), Description = "Frameworks", Title = "Frameworks", Image = "frw.png" };

            modelBuilder.Entity<Category>().HasData(
                net, dbCategory, framework
                );

            modelBuilder.Entity<Skill>().HasData(
                new Skill() { Id = Guid.NewGuid(), Title = "Web API", Description = "Web API" },
                new Skill() { Id = Guid.NewGuid(), Title = "ASP.NET", Description = "ASP.NET" },
                new Skill() { Id = Guid.NewGuid(), Title = "WCF", Description = "WCF" },
                new Skill() { Id = Guid.NewGuid(), Title = "SQL Server", Description = "SQL Server" },
                new Skill() { Id = Guid.NewGuid(), Title = "Oracle", Description = "Oracle" },
                new Skill() { Id = Guid.NewGuid(), Title = "AngularJS", Description = "AngularJS" }
                );
        }

        #endregion
    }
}
