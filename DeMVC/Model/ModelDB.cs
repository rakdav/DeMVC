using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DeMVC.Model
{
    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {
        }

        public virtual DbSet<Compexity> Compexity { get; set; }
        public virtual DbSet<Graide> Graide { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<Work> Work { get; set; }
        public virtual DbSet<Worker> Worker { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Compexity>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Compexity)
                .HasForeignKey(e => e.idComp);

            modelBuilder.Entity<Graide>()
                .HasMany(e => e.Work)
                .WithRequired(e => e.Graide)
                .HasForeignKey(e => e.idGraide)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manager>()
                .HasMany(e => e.Work)
                .WithRequired(e => e.Manager)
                .HasForeignKey(e => e.loginManager)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Tasks)
                .WithOptional(e => e.Status)
                .HasForeignKey(e => e.idStatus);

            modelBuilder.Entity<Worker>()
                .HasMany(e => e.Tasks)
                .WithRequired(e => e.Worker)
                .HasForeignKey(e => e.LoginWorker)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Worker>()
                .HasMany(e => e.Work)
                .WithRequired(e => e.Worker)
                .HasForeignKey(e => e.loginWorker)
                .WillCascadeOnDelete(false);
        }
    }
}
