using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Sql;
using SlimmingCenter2.Models.ClientModel;
using SlimmingCenter2.Models.Info;
using SlimmingCenter2.Models.Info.MedicalInfo;
using SlimmingCenter2.Models.Users;

namespace SlimmingCenter2.Models.Context
{
    public class CenterContext :DbContext
    {    

        public DbSet<Client> Clients { get; set; }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<DModel> DModels { get; set; }
        public DbSet<Fitness> Fitnesses { get; set; }
        public DbSet<FitnessLesson> FitnessLessons { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<StayInfo> StayInfoes { get; set; }
        public DbSet<BloodTest> BloodTests { get; set; }
        public DbSet<Cardiogram> Cardiograms { get; set; }
        public DbSet<HealthIssues> HealthIssues { get; set; }
        public DbSet<MakeupBody> MakeupBodies { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<MedicalData> MedicalDatas { get; set; }
        public DbSet<Sonography> Sonographies { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<User> Users {get;set;}

        public CenterContext()
            : base("SlimmingCenter")
        { }  

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasMany(c => c.users).WithMany(s => s.clients)
                .Map(t => t.MapLeftKey("ClientId").MapRightKey("usersId").ToTable("ClientUser"));
            modelBuilder.Entity<User>().HasMany(c => c.Roles).WithMany(s => s.users)
                .Map(t => t.MapLeftKey("UserId").MapRightKey("RoleId").ToTable("UsersRole"));
            modelBuilder.Entity<User>().HasMany(c => c.Positions).WithMany(s => s.users)
                .Map(t => t.MapLeftKey("UserId").MapRightKey("PositionId").ToTable("UsersPosition"));
            modelBuilder.Entity<Role>().HasMany(c => c.Rules).WithMany(s => s.Roles)
                .Map(t => t.MapLeftKey("RoleId").MapRightKey("RuleId").ToTable("RoleRule"));
            }
    }
}