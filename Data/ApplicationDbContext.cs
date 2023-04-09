using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using VacationManager.Models;

namespace VacationManager.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppUser>()
                .HasOne(user => user.Team)
                .WithMany(team => team.Members)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Team>()
                .HasOne(team => team.Leader)
                .WithOne(leader => leader.TeamLed)
                .HasForeignKey<AppUser>(leader=>leader.TeamLedId);

            modelBuilder.Entity<Team>()
                .HasOne(team => team.Project)
                .WithMany(project => project.TeamsAtWork)
                .HasForeignKey(team=>team.ProjectId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Holiday>()
                .HasOne(holiday => holiday.Requester)
                .WithMany(requester => requester.RequestedHolidays);

            modelBuilder.Entity<Holiday>()
                .Property(holiday => holiday.PatientNote)
                .IsRequired(false);

            modelBuilder.Entity<AppUser>()
                .Property(user => user.TeamId)
                .IsRequired(false);

            modelBuilder.Entity<Team>()
                .Property(team => team.ProjectId)
                .IsRequired(false);
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
    }
}