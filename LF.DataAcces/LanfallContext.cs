using LF.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LF.DataAccess
{
    public class LanfallContext : DbContext
    {
        public LanfallContext() : base("name=LF2")
        {
            
        }

        public DbSet<Clan> Clans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Clan>()
                .HasOptional(x => x.Founder)
                .WithRequired(x => x.FounderOfClan);

            modelBuilder.Entity<Clan>()
                .HasMany(x => x.Members)
                .WithOptional(x => x.Clan);

            modelBuilder.Entity<User>()
                .HasRequired(x => x.UserDetail)
                .WithRequiredPrincipal(x => x.User);

            modelBuilder.Entity<Seat>()
                .HasRequired(x => x.SeatType)
                .WithMany(x => x.Seats);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Seats)
                .WithOptional(x => x.User);

            modelBuilder.Entity<User>()
                 .HasMany(x => x.Roles)
                 .WithMany(x => x.Users)
                 .Map(x =>
                 {
                     x.MapLeftKey("UserId");
                     x.MapRightKey("RoleId");
                     x.ToTable("UserRole");
                 });

            modelBuilder.Entity<Competition>()
                .HasRequired(x => x.CompetitionType)
                .WithMany(x => x.Competitions);


            modelBuilder.Entity<User>()
                .HasMany(x => x.AdminOfCompetitions)
                .WithRequired(x => x.User);

            modelBuilder.Entity<Competition>()
                .HasMany(x => x.CompetitionAdmins)
                .WithRequired(x => x.Competition);


            modelBuilder.Entity<Competition>()
                .HasMany(x => x.ParticipatingUsers)
                .WithMany(x => x.Competitions)
                                 .Map(x =>
                                 {
                                     x.MapLeftKey("CompetitionId");
                                     x.MapRightKey("UserId");
                                     x.ToTable("CompetitionUser");
                                 });

            modelBuilder.Entity<Competition>()
                .HasMany(x => x.ParticipatingClans)
                .WithMany(x => x.Competitions)
                                 .Map(x =>
                                 {
                                     x.MapLeftKey("CompetitionId");
                                     x.MapRightKey("ClanId");
                                     x.ToTable("CompetitionClan");
                                 });

            modelBuilder.Entity<Competition>()
                .HasOptional(x => x.Game)
                .WithMany(x => x.Competitions);

            modelBuilder.Entity<Edition>()
                .HasMany(x => x.Competitions)
                .WithRequired(x => x.Edition);
        }
    }
}
