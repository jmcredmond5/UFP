using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UFPCore.Areas.Identity.Pages.Account;
using UFPCore.Models;
using UFPCore.Models.Payment;
using UFPCore.Models.Predictions;


namespace UFPCore.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<PaymentConfirmation> PaymentConfirmations { get; set; }
        public DbSet<UserPoints> UserPoints { get; set; }
        public DbSet<UpdateInfo> UpdateInfos { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<Scores> Scores { get; set; }
        public DbSet<Completions> Completions { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<FirstPredictions> Firsts { get; set; }
        public DbSet<ChristmasPredictions> ChristmasPredictions { get; set; }
        public DbSet<ChampionsLge> ChampionsLge { get; set; }
        public DbSet<FACup> FACup { get; set; }
        public DbSet<Championship> Championship { get; set; }
        public DbSet<LeagueOne> LeagueOne { get; set; }
        public DbSet<LeagueTwo> LeagueTwo { get; set; }
        public DbSet<NationalLeague> NationalLeague { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }
}
