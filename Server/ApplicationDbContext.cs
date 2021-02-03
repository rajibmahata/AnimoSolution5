using Microsoft.EntityFrameworkCore;
using Model.Shared;
using Model.Shared.Entities;
using Model.Shared.DTOs;

namespace AnimoWeb.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPhotos>().HasKey(x => new { x.UserId, x.PhotoId });
            modelBuilder.Entity<ProjectImages>().HasKey(x => new { x.ProjectId, x.ImageId });
            modelBuilder.Entity<ProjectTecnos>().HasKey(x => new { x.ProjectId, x.TecnoId });
            modelBuilder.Entity<NewsGraphs>().HasKey(x => new { x.NewsId, x.GraphId });
            modelBuilder.Entity<SocialLinks>().HasKey(x => new { x.SocialId, x.GlobalConfigId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Firmas> Firmas { get; set; }
        public DbSet<Landes> Landes { get; set; }
        public DbSet<Photos> Photos { get; set; }
        public DbSet<Logos> Logos { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Tecnos> Tecnos { get; set; }
        public DbSet<Downloads> Downloads { get; set; }
        public DbSet<MimeType> MimeTypes { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<SocialLinks> SocialLinks { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Graphs> Graphs { get; set; }
        public DbSet<GlobalConfig> GlobalConfig { get; set; }
        public DbSet<GlobalLocations> GlobalLocations { get; set; }
        public DbSet<Bilboard> Bilboards { get; set; }

        //Many to Many
        public DbSet<UserPhotos> UserPhotos { get; set; }
        public DbSet<ProjectImages> ProjectImages { get; set; }
        public DbSet<ProjectTecnos> ProjectTecnos { get; set; }
        public DbSet<NewsGraphs> NewsGraphs { get; set; }
        public DbSet<Model.Shared.DTOs.ContactFormDTO> ContactFormDTO { get; set; }



    }
}
