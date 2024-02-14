namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class db_model : DbContext
    {
        public db_model()
            : base("name=db_model")
        {
        }

        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Social> Socials { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Education>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.Document_route)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Position)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Mode)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Skill>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Skill>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Social>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Social>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Social>()
                .Property(e => e.Link)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phrase)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
