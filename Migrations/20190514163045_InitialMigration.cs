using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UFPCore.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false),
                    CTitle = table.Column<int>(nullable: false),
                    CRunnerUp = table.Column<int>(nullable: false),
                    CPlayoff1 = table.Column<int>(nullable: false),
                    CPlayoff2 = table.Column<int>(nullable: false),
                    CPlayoff3 = table.Column<int>(nullable: false),
                    CPlayoff4 = table.Column<int>(nullable: false),
                    CPlayoffWinner = table.Column<int>(nullable: false),
                    CRelegation1 = table.Column<int>(nullable: false),
                    CRelegation2 = table.Column<int>(nullable: false),
                    CRelegation3 = table.Column<int>(nullable: false),
                    CLQF1 = table.Column<int>(nullable: false),
                    CLQF2 = table.Column<int>(nullable: false),
                    CLQF3 = table.Column<int>(nullable: false),
                    CLQF4 = table.Column<int>(nullable: false),
                    CLQF5 = table.Column<int>(nullable: false),
                    CLQF6 = table.Column<int>(nullable: false),
                    CLQF7 = table.Column<int>(nullable: false),
                    CLQF8 = table.Column<int>(nullable: false),
                    CLSF1 = table.Column<int>(nullable: false),
                    CLSF2 = table.Column<int>(nullable: false),
                    CLSF3 = table.Column<int>(nullable: false),
                    CLSF4 = table.Column<int>(nullable: false),
                    CLWinner = table.Column<int>(nullable: false),
                    CLRunnerUp = table.Column<int>(nullable: false),
                    TopScoreTeam = table.Column<int>(nullable: false),
                    TopScorePlayer = table.Column<string>(nullable: true),
                    Top = table.Column<int>(nullable: false),
                    Bottom = table.Column<int>(nullable: false),
                    ManagersOut = table.Column<int>(nullable: false),
                    PointsDifference = table.Column<int>(nullable: false),
                    PointsClear = table.Column<int>(nullable: false),
                    FACQF1 = table.Column<int>(nullable: false),
                    FACQF2 = table.Column<int>(nullable: false),
                    FACQF3 = table.Column<int>(nullable: false),
                    FACQF4 = table.Column<int>(nullable: false),
                    FACQF5 = table.Column<int>(nullable: false),
                    FACQF6 = table.Column<int>(nullable: false),
                    FACQF7 = table.Column<int>(nullable: false),
                    FACQF8 = table.Column<int>(nullable: false),
                    FACSF1 = table.Column<int>(nullable: false),
                    FACSF2 = table.Column<int>(nullable: false),
                    FACSF3 = table.Column<int>(nullable: false),
                    FACSF4 = table.Column<int>(nullable: false),
                    FACWinner = table.Column<int>(nullable: false),
                    FACRunnerUp = table.Column<int>(nullable: false),
                    FirstScore25 = table.Column<int>(nullable: false),
                    FirstScore50 = table.Column<int>(nullable: false),
                    FirstScore75 = table.Column<int>(nullable: false),
                    FirstScore100 = table.Column<int>(nullable: false),
                    Con25 = table.Column<int>(nullable: false),
                    Con50 = table.Column<int>(nullable: false),
                    Con75 = table.Column<int>(nullable: false),
                    Con100 = table.Column<int>(nullable: false),
                    TeamHattrick = table.Column<int>(nullable: false),
                    TeamLoseManager = table.Column<int>(nullable: false),
                    Score5in1 = table.Column<int>(nullable: false),
                    Con5in1 = table.Column<int>(nullable: false),
                    Win5inRow = table.Column<int>(nullable: false),
                    Lose5inRow = table.Column<int>(nullable: false),
                    TwoReds = table.Column<int>(nullable: false),
                    Win20 = table.Column<int>(nullable: false),
                    LOTitle = table.Column<int>(nullable: false),
                    LORunnerUp = table.Column<int>(nullable: false),
                    LOPlayoff1 = table.Column<int>(nullable: false),
                    LOPlayoff2 = table.Column<int>(nullable: false),
                    LOPlayoff3 = table.Column<int>(nullable: false),
                    LOPlayoff4 = table.Column<int>(nullable: false),
                    LOPlayoffWinner = table.Column<int>(nullable: false),
                    LORelegation1 = table.Column<int>(nullable: false),
                    LORelegation2 = table.Column<int>(nullable: false),
                    LORelegation3 = table.Column<int>(nullable: false),
                    LTTitle = table.Column<int>(nullable: false),
                    LTRunnerUp = table.Column<int>(nullable: false),
                    LTPlayoff1 = table.Column<int>(nullable: false),
                    LTPlayoff2 = table.Column<int>(nullable: false),
                    LTPlayoff3 = table.Column<int>(nullable: false),
                    LTPlayoff4 = table.Column<int>(nullable: false),
                    LTPlayoffWinner = table.Column<int>(nullable: false),
                    LTRelegation1 = table.Column<int>(nullable: false),
                    LTRelegation2 = table.Column<int>(nullable: false),
                    LTRelegation3 = table.Column<int>(nullable: false),
                    NLTitle = table.Column<int>(nullable: false),
                    NLPlayoffWinner = table.Column<int>(nullable: false),
                    Score1 = table.Column<int>(nullable: false),
                    Score2 = table.Column<int>(nullable: false),
                    Score3 = table.Column<int>(nullable: false),
                    Score4 = table.Column<int>(nullable: false),
                    Score5 = table.Column<int>(nullable: false),
                    Score6 = table.Column<int>(nullable: false),
                    Score7 = table.Column<int>(nullable: false),
                    Score8 = table.Column<int>(nullable: false),
                    Score9 = table.Column<int>(nullable: false),
                    Score10 = table.Column<int>(nullable: false),
                    Score11 = table.Column<int>(nullable: false),
                    Score12 = table.Column<int>(nullable: false),
                    Score13 = table.Column<int>(nullable: false),
                    Score14 = table.Column<int>(nullable: false),
                    Score15 = table.Column<int>(nullable: false),
                    Score16 = table.Column<int>(nullable: false),
                    Score17 = table.Column<int>(nullable: false),
                    Score18 = table.Column<int>(nullable: false),
                    Score19 = table.Column<int>(nullable: false),
                    Score20 = table.Column<int>(nullable: false),
                    Score21 = table.Column<int>(nullable: false),
                    Score22 = table.Column<int>(nullable: false),
                    Score23 = table.Column<int>(nullable: false),
                    Score24 = table.Column<int>(nullable: false),
                    Score25 = table.Column<int>(nullable: false),
                    Score26 = table.Column<int>(nullable: false),
                    Score27 = table.Column<int>(nullable: false),
                    Score28 = table.Column<int>(nullable: false),
                    Score29 = table.Column<int>(nullable: false),
                    Score30 = table.Column<int>(nullable: false),
                    Score31 = table.Column<int>(nullable: false),
                    Score32 = table.Column<int>(nullable: false),
                    Score33 = table.Column<int>(nullable: false),
                    Score34 = table.Column<int>(nullable: false),
                    Score35 = table.Column<int>(nullable: false),
                    Score36 = table.Column<int>(nullable: false),
                    Score37 = table.Column<int>(nullable: false),
                    Score38 = table.Column<int>(nullable: false),
                    Score39 = table.Column<int>(nullable: false),
                    Score40 = table.Column<int>(nullable: false),
                    Score41 = table.Column<int>(nullable: false),
                    Score42 = table.Column<int>(nullable: false),
                    Score43 = table.Column<int>(nullable: false),
                    Score44 = table.Column<int>(nullable: false),
                    Score45 = table.Column<int>(nullable: false),
                    Score46 = table.Column<int>(nullable: false),
                    Score47 = table.Column<int>(nullable: false),
                    Score48 = table.Column<int>(nullable: false),
                    Score49 = table.Column<int>(nullable: false),
                    Score50 = table.Column<int>(nullable: false),
                    Score51 = table.Column<int>(nullable: false),
                    Score52 = table.Column<int>(nullable: false),
                    Score53 = table.Column<int>(nullable: false),
                    Score54 = table.Column<int>(nullable: false),
                    Score55 = table.Column<int>(nullable: false),
                    Score56 = table.Column<int>(nullable: false),
                    Score57 = table.Column<int>(nullable: false),
                    Score58 = table.Column<int>(nullable: false),
                    Score59 = table.Column<int>(nullable: false),
                    Score60 = table.Column<int>(nullable: false),
                    Score61 = table.Column<int>(nullable: false),
                    Score62 = table.Column<int>(nullable: false),
                    Score63 = table.Column<int>(nullable: false),
                    Score64 = table.Column<int>(nullable: false),
                    Score65 = table.Column<int>(nullable: false),
                    Score66 = table.Column<int>(nullable: false),
                    Score67 = table.Column<int>(nullable: false),
                    Score68 = table.Column<int>(nullable: false),
                    Score69 = table.Column<int>(nullable: false),
                    Score70 = table.Column<int>(nullable: false),
                    Score71 = table.Column<int>(nullable: false),
                    Score72 = table.Column<int>(nullable: false),
                    Score73 = table.Column<int>(nullable: false),
                    Score74 = table.Column<int>(nullable: false),
                    Score75 = table.Column<int>(nullable: false),
                    Score76 = table.Column<int>(nullable: false),
                    Score77 = table.Column<int>(nullable: false),
                    Score78 = table.Column<int>(nullable: false),
                    Place1 = table.Column<int>(nullable: false),
                    Place2 = table.Column<int>(nullable: false),
                    Place3 = table.Column<int>(nullable: false),
                    Place4 = table.Column<int>(nullable: false),
                    Place5 = table.Column<int>(nullable: false),
                    Place6 = table.Column<int>(nullable: false),
                    Place7 = table.Column<int>(nullable: false),
                    Place8 = table.Column<int>(nullable: false),
                    Place9 = table.Column<int>(nullable: false),
                    Place10 = table.Column<int>(nullable: false),
                    Place11 = table.Column<int>(nullable: false),
                    Place12 = table.Column<int>(nullable: false),
                    Place13 = table.Column<int>(nullable: false),
                    Place14 = table.Column<int>(nullable: false),
                    Place15 = table.Column<int>(nullable: false),
                    Place16 = table.Column<int>(nullable: false),
                    Place17 = table.Column<int>(nullable: false),
                    Place18 = table.Column<int>(nullable: false),
                    Place19 = table.Column<int>(nullable: false),
                    Place20 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    InvitedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Championship",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    Title = table.Column<int>(nullable: false),
                    RunnerUp = table.Column<int>(nullable: false),
                    Playoff1 = table.Column<int>(nullable: false),
                    Playoff2 = table.Column<int>(nullable: false),
                    Playoff3 = table.Column<int>(nullable: false),
                    Playoff4 = table.Column<int>(nullable: false),
                    PlayoffWinner = table.Column<int>(nullable: false),
                    Relegation1 = table.Column<int>(nullable: false),
                    Relegation2 = table.Column<int>(nullable: false),
                    Relegation3 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championship", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChampionsLge",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    QF1 = table.Column<int>(nullable: false),
                    QF2 = table.Column<int>(nullable: false),
                    QF3 = table.Column<int>(nullable: false),
                    QF4 = table.Column<int>(nullable: false),
                    QF5 = table.Column<int>(nullable: false),
                    QF6 = table.Column<int>(nullable: false),
                    QF7 = table.Column<int>(nullable: false),
                    QF8 = table.Column<int>(nullable: false),
                    SF1 = table.Column<int>(nullable: false),
                    SF2 = table.Column<int>(nullable: false),
                    SF3 = table.Column<int>(nullable: false),
                    SF4 = table.Column<int>(nullable: false),
                    Winner = table.Column<int>(nullable: false),
                    RunnerUp = table.Column<int>(nullable: false),
                    TopScoreTeam = table.Column<int>(nullable: false),
                    TopScorePlayer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionsLge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChristmasPredictions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    Top = table.Column<int>(nullable: false),
                    Bottom = table.Column<int>(nullable: false),
                    ManagersOut = table.Column<int>(nullable: false),
                    PointsDifference = table.Column<int>(nullable: false),
                    PointsClear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChristmasPredictions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Completions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    ScoresCom = table.Column<bool>(nullable: false),
                    FirstsCom = table.Column<bool>(nullable: false),
                    FinalCom = table.Column<bool>(nullable: false),
                    EoSCom = table.Column<bool>(nullable: false),
                    ChampionsLgeCom = table.Column<bool>(nullable: false),
                    FACupCom = table.Column<bool>(nullable: false),
                    ChampionshipCom = table.Column<bool>(nullable: false),
                    LeagueOneCom = table.Column<bool>(nullable: false),
                    LeagueTwoCom = table.Column<bool>(nullable: false),
                    NationalLeagueCom = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Completions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FACup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    QF1 = table.Column<int>(nullable: false),
                    QF2 = table.Column<int>(nullable: false),
                    QF3 = table.Column<int>(nullable: false),
                    QF4 = table.Column<int>(nullable: false),
                    QF5 = table.Column<int>(nullable: false),
                    QF6 = table.Column<int>(nullable: false),
                    QF7 = table.Column<int>(nullable: false),
                    QF8 = table.Column<int>(nullable: false),
                    SF1 = table.Column<int>(nullable: false),
                    SF2 = table.Column<int>(nullable: false),
                    SF3 = table.Column<int>(nullable: false),
                    SF4 = table.Column<int>(nullable: false),
                    Winner = table.Column<int>(nullable: false),
                    RunnerUp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FACup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Firsts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    Score25 = table.Column<int>(nullable: false),
                    Score50 = table.Column<int>(nullable: false),
                    Score75 = table.Column<int>(nullable: false),
                    Score100 = table.Column<int>(nullable: false),
                    Con25 = table.Column<int>(nullable: false),
                    Con50 = table.Column<int>(nullable: false),
                    Con75 = table.Column<int>(nullable: false),
                    Con100 = table.Column<int>(nullable: false),
                    TeamHattrick = table.Column<int>(nullable: false),
                    TeamLoseManager = table.Column<int>(nullable: false),
                    Score5in1 = table.Column<int>(nullable: false),
                    Con5in1 = table.Column<int>(nullable: false),
                    Win5inRow = table.Column<int>(nullable: false),
                    Lose5inRow = table.Column<int>(nullable: false),
                    TwoReds = table.Column<int>(nullable: false),
                    Win20 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firsts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeagueOne",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    Title = table.Column<int>(nullable: false),
                    RunnerUp = table.Column<int>(nullable: false),
                    Playoff1 = table.Column<int>(nullable: false),
                    Playoff2 = table.Column<int>(nullable: false),
                    Playoff3 = table.Column<int>(nullable: false),
                    Playoff4 = table.Column<int>(nullable: false),
                    PlayoffWinner = table.Column<int>(nullable: false),
                    Relegation1 = table.Column<int>(nullable: false),
                    Relegation2 = table.Column<int>(nullable: false),
                    Relegation3 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueOne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeagueTwo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    Title = table.Column<int>(nullable: false),
                    RunnerUp = table.Column<int>(nullable: false),
                    Playoff1 = table.Column<int>(nullable: false),
                    Playoff2 = table.Column<int>(nullable: false),
                    Playoff3 = table.Column<int>(nullable: false),
                    Playoff4 = table.Column<int>(nullable: false),
                    PlayoffWinner = table.Column<int>(nullable: false),
                    Relegation1 = table.Column<int>(nullable: false),
                    Relegation2 = table.Column<int>(nullable: false),
                    Relegation3 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueTwo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NationalLeague",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    Title = table.Column<int>(nullable: false),
                    PlayoffWinner = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalLeague", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentConfirmations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsersId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentConfirmations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    Score1 = table.Column<int>(nullable: false),
                    Score2 = table.Column<int>(nullable: false),
                    Score3 = table.Column<int>(nullable: false),
                    Score4 = table.Column<int>(nullable: false),
                    Score5 = table.Column<int>(nullable: false),
                    Score6 = table.Column<int>(nullable: false),
                    Score7 = table.Column<int>(nullable: false),
                    Score8 = table.Column<int>(nullable: false),
                    Score9 = table.Column<int>(nullable: false),
                    Score10 = table.Column<int>(nullable: false),
                    Score11 = table.Column<int>(nullable: false),
                    Score12 = table.Column<int>(nullable: false),
                    Score13 = table.Column<int>(nullable: false),
                    Score14 = table.Column<int>(nullable: false),
                    Score15 = table.Column<int>(nullable: false),
                    Score16 = table.Column<int>(nullable: false),
                    Score17 = table.Column<int>(nullable: false),
                    Score18 = table.Column<int>(nullable: false),
                    Score19 = table.Column<int>(nullable: false),
                    Score20 = table.Column<int>(nullable: false),
                    Score21 = table.Column<int>(nullable: false),
                    Score22 = table.Column<int>(nullable: false),
                    Score23 = table.Column<int>(nullable: false),
                    Score24 = table.Column<int>(nullable: false),
                    Score25 = table.Column<int>(nullable: false),
                    Score26 = table.Column<int>(nullable: false),
                    Score27 = table.Column<int>(nullable: false),
                    Score28 = table.Column<int>(nullable: false),
                    Score29 = table.Column<int>(nullable: false),
                    Score30 = table.Column<int>(nullable: false),
                    Score31 = table.Column<int>(nullable: false),
                    Score32 = table.Column<int>(nullable: false),
                    Score33 = table.Column<int>(nullable: false),
                    Score34 = table.Column<int>(nullable: false),
                    Score35 = table.Column<int>(nullable: false),
                    Score36 = table.Column<int>(nullable: false),
                    Score37 = table.Column<int>(nullable: false),
                    Score38 = table.Column<int>(nullable: false),
                    Score39 = table.Column<int>(nullable: false),
                    Score40 = table.Column<int>(nullable: false),
                    Score41 = table.Column<int>(nullable: false),
                    Score42 = table.Column<int>(nullable: false),
                    Score43 = table.Column<int>(nullable: false),
                    Score44 = table.Column<int>(nullable: false),
                    Score45 = table.Column<int>(nullable: false),
                    Score46 = table.Column<int>(nullable: false),
                    Score47 = table.Column<int>(nullable: false),
                    Score48 = table.Column<int>(nullable: false),
                    Score49 = table.Column<int>(nullable: false),
                    Score50 = table.Column<int>(nullable: false),
                    Score51 = table.Column<int>(nullable: false),
                    Score52 = table.Column<int>(nullable: false),
                    Score53 = table.Column<int>(nullable: false),
                    Score54 = table.Column<int>(nullable: false),
                    Score55 = table.Column<int>(nullable: false),
                    Score56 = table.Column<int>(nullable: false),
                    Score57 = table.Column<int>(nullable: false),
                    Score58 = table.Column<int>(nullable: false),
                    Score59 = table.Column<int>(nullable: false),
                    Score60 = table.Column<int>(nullable: false),
                    Score61 = table.Column<int>(nullable: false),
                    Score62 = table.Column<int>(nullable: false),
                    Score63 = table.Column<int>(nullable: false),
                    Score64 = table.Column<int>(nullable: false),
                    Score65 = table.Column<int>(nullable: false),
                    Score66 = table.Column<int>(nullable: false),
                    Score67 = table.Column<int>(nullable: false),
                    Score68 = table.Column<int>(nullable: false),
                    Score69 = table.Column<int>(nullable: false),
                    Score70 = table.Column<int>(nullable: false),
                    Score71 = table.Column<int>(nullable: false),
                    Score72 = table.Column<int>(nullable: false),
                    Score73 = table.Column<int>(nullable: false),
                    Score74 = table.Column<int>(nullable: false),
                    Score75 = table.Column<int>(nullable: false),
                    Score76 = table.Column<int>(nullable: false),
                    Score77 = table.Column<int>(nullable: false),
                    Score78 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    User = table.Column<string>(nullable: true),
                    Place1 = table.Column<int>(nullable: false),
                    Place2 = table.Column<int>(nullable: false),
                    Place3 = table.Column<int>(nullable: false),
                    Place4 = table.Column<int>(nullable: false),
                    Place5 = table.Column<int>(nullable: false),
                    Place6 = table.Column<int>(nullable: false),
                    Place7 = table.Column<int>(nullable: false),
                    Place8 = table.Column<int>(nullable: false),
                    Place9 = table.Column<int>(nullable: false),
                    Place10 = table.Column<int>(nullable: false),
                    Place11 = table.Column<int>(nullable: false),
                    Place12 = table.Column<int>(nullable: false),
                    Place13 = table.Column<int>(nullable: false),
                    Place14 = table.Column<int>(nullable: false),
                    Place15 = table.Column<int>(nullable: false),
                    Place16 = table.Column<int>(nullable: false),
                    Place17 = table.Column<int>(nullable: false),
                    Place18 = table.Column<int>(nullable: false),
                    Place19 = table.Column<int>(nullable: false),
                    Place20 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UpdateInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false),
                    CurrentUpdate = table.Column<int>(nullable: false),
                    ChFinalTable = table.Column<int>(nullable: false),
                    ChPlayoffs = table.Column<int>(nullable: false),
                    CLQFs = table.Column<int>(nullable: false),
                    CLSFs = table.Column<int>(nullable: false),
                    CLFinalResults = table.Column<int>(nullable: false),
                    Christmas = table.Column<int>(nullable: false),
                    FACQFs = table.Column<int>(nullable: false),
                    FACSFs = table.Column<int>(nullable: false),
                    FACFinalResults = table.Column<int>(nullable: false),
                    PLFinalResults = table.Column<int>(nullable: false),
                    Score25 = table.Column<int>(nullable: false),
                    Score50 = table.Column<int>(nullable: false),
                    Score75 = table.Column<int>(nullable: false),
                    Score100 = table.Column<int>(nullable: false),
                    Con25 = table.Column<int>(nullable: false),
                    Con50 = table.Column<int>(nullable: false),
                    Con75 = table.Column<int>(nullable: false),
                    Con100 = table.Column<int>(nullable: false),
                    TeamHattrick = table.Column<int>(nullable: false),
                    TeamLoseManager = table.Column<int>(nullable: false),
                    Score5in1 = table.Column<int>(nullable: false),
                    Con5in1 = table.Column<int>(nullable: false),
                    Win5inRow = table.Column<int>(nullable: false),
                    Lose5inRow = table.Column<int>(nullable: false),
                    TwoReds = table.Column<int>(nullable: false),
                    Win20 = table.Column<int>(nullable: false),
                    Match1 = table.Column<int>(nullable: false),
                    Match2 = table.Column<int>(nullable: false),
                    Match3 = table.Column<int>(nullable: false),
                    Match4 = table.Column<int>(nullable: false),
                    Match5 = table.Column<int>(nullable: false),
                    Match6 = table.Column<int>(nullable: false),
                    Match7 = table.Column<int>(nullable: false),
                    Match8 = table.Column<int>(nullable: false),
                    Match9 = table.Column<int>(nullable: false),
                    Match10 = table.Column<int>(nullable: false),
                    Match11 = table.Column<int>(nullable: false),
                    Match12 = table.Column<int>(nullable: false),
                    Match13 = table.Column<int>(nullable: false),
                    Match14 = table.Column<int>(nullable: false),
                    Match15 = table.Column<int>(nullable: false),
                    Match16 = table.Column<int>(nullable: false),
                    Match17 = table.Column<int>(nullable: false),
                    Match18 = table.Column<int>(nullable: false),
                    Match19 = table.Column<int>(nullable: false),
                    Match20 = table.Column<int>(nullable: false),
                    Match21 = table.Column<int>(nullable: false),
                    Match22 = table.Column<int>(nullable: false),
                    Match23 = table.Column<int>(nullable: false),
                    Match24 = table.Column<int>(nullable: false),
                    Match25 = table.Column<int>(nullable: false),
                    Match26 = table.Column<int>(nullable: false),
                    Match27 = table.Column<int>(nullable: false),
                    Match28 = table.Column<int>(nullable: false),
                    Match29 = table.Column<int>(nullable: false),
                    Match30 = table.Column<int>(nullable: false),
                    Match31 = table.Column<int>(nullable: false),
                    Match32 = table.Column<int>(nullable: false),
                    Match33 = table.Column<int>(nullable: false),
                    Match34 = table.Column<int>(nullable: false),
                    Match35 = table.Column<int>(nullable: false),
                    Match36 = table.Column<int>(nullable: false),
                    Match37 = table.Column<int>(nullable: false),
                    Match38 = table.Column<int>(nullable: false),
                    Match39 = table.Column<int>(nullable: false),
                    LOFinalTable = table.Column<int>(nullable: false),
                    LOPlayoffs = table.Column<int>(nullable: false),
                    LTFinalTable = table.Column<int>(nullable: false),
                    LTPlayoffs = table.Column<int>(nullable: false),
                    NLFinalTable = table.Column<int>(nullable: false),
                    NLPlayoffs = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserPoints",
                columns: table => new
                {
                    UFPId = table.Column<string>(nullable: false),
                    CurrentScore = table.Column<float>(nullable: false),
                    Update01 = table.Column<float>(nullable: false),
                    Update02 = table.Column<float>(nullable: false),
                    Update03 = table.Column<float>(nullable: false),
                    Update04 = table.Column<float>(nullable: false),
                    Update05 = table.Column<float>(nullable: false),
                    Update06 = table.Column<float>(nullable: false),
                    Update07 = table.Column<float>(nullable: false),
                    Update08 = table.Column<float>(nullable: false),
                    Update09 = table.Column<float>(nullable: false),
                    Update10 = table.Column<float>(nullable: false),
                    Update11 = table.Column<float>(nullable: false),
                    Update12 = table.Column<float>(nullable: false),
                    Update13 = table.Column<float>(nullable: false),
                    Update14 = table.Column<float>(nullable: false),
                    Update15 = table.Column<float>(nullable: false),
                    Update16 = table.Column<float>(nullable: false),
                    Update17 = table.Column<float>(nullable: false),
                    Update18 = table.Column<float>(nullable: false),
                    Update19 = table.Column<float>(nullable: false),
                    Update20 = table.Column<float>(nullable: false),
                    Update21 = table.Column<float>(nullable: false),
                    Update22 = table.Column<float>(nullable: false),
                    Update23 = table.Column<float>(nullable: false),
                    Update24 = table.Column<float>(nullable: false),
                    Update25 = table.Column<float>(nullable: false),
                    Update26 = table.Column<float>(nullable: false),
                    Update27 = table.Column<float>(nullable: false),
                    Update28 = table.Column<float>(nullable: false),
                    Update29 = table.Column<float>(nullable: false),
                    Update30 = table.Column<float>(nullable: false),
                    Update31 = table.Column<float>(nullable: false),
                    Update32 = table.Column<float>(nullable: false),
                    Update33 = table.Column<float>(nullable: false),
                    Update34 = table.Column<float>(nullable: false),
                    Update35 = table.Column<float>(nullable: false),
                    Update36 = table.Column<float>(nullable: false),
                    Update37 = table.Column<float>(nullable: false),
                    Update38 = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPoints", x => x.UFPId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Championship");

            migrationBuilder.DropTable(
                name: "ChampionsLge");

            migrationBuilder.DropTable(
                name: "ChristmasPredictions");

            migrationBuilder.DropTable(
                name: "Completions");

            migrationBuilder.DropTable(
                name: "FACup");

            migrationBuilder.DropTable(
                name: "Firsts");

            migrationBuilder.DropTable(
                name: "LeagueOne");

            migrationBuilder.DropTable(
                name: "LeagueTwo");

            migrationBuilder.DropTable(
                name: "NationalLeague");

            migrationBuilder.DropTable(
                name: "PaymentConfirmations");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "UpdateInfos");

            migrationBuilder.DropTable(
                name: "UserPoints");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
