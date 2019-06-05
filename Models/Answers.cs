using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UFPCore.Models
{
    public class Answers
    {
        [Key]
        public int Id { get; set; }
        public int Year { get; set; }
        public ChampionshipTeamsEnum CTitle { get; set; }
        public ChampionshipTeamsEnum CRunnerUp { get; set; }
        public ChampionshipTeamsEnum CPlayoff1 { get; set; }
        public ChampionshipTeamsEnum CPlayoff2 { get; set; }
        public ChampionshipTeamsEnum CPlayoff3 { get; set; }
        public ChampionshipTeamsEnum CPlayoff4 { get; set; }
        public ChampionshipTeamsEnum CPlayoffWinner { get; set; }
        public ChampionshipTeamsEnum CRelegation1 { get; set; }
        public ChampionshipTeamsEnum CRelegation2 { get; set; }
        public ChampionshipTeamsEnum CRelegation3 { get; set; }

        public ChampionsTeamsEnum CLQF1 { get; set; }
        public ChampionsTeamsEnum CLQF2 { get; set; }
        public ChampionsTeamsEnum CLQF3 { get; set; }
        public ChampionsTeamsEnum CLQF4 { get; set; }
        public ChampionsTeamsEnum CLQF5 { get; set; }
        public ChampionsTeamsEnum CLQF6 { get; set; }
        public ChampionsTeamsEnum CLQF7 { get; set; }
        public ChampionsTeamsEnum CLQF8 { get; set; }
        public ChampionsTeamsEnum CLSF1 { get; set; }
        public ChampionsTeamsEnum CLSF2 { get; set; }
        public ChampionsTeamsEnum CLSF3 { get; set; }
        public ChampionsTeamsEnum CLSF4 { get; set; }
        public ChampionsTeamsEnum CLWinner { get; set; }
        public ChampionsTeamsEnum CLRunnerUp { get; set; }
        public ChampionsTeamsEnum TopScoreTeam { get; set; }
        public string TopScorePlayer { get; set; }

        public TeamsEnum Top { get; set; }
        public TeamsEnum Bottom { get; set; }
        public int ManagersOut { get; set; }
        public int PointsDifference { get; set; }
        public int PointsClear { get; set; }

        public CupTeamsEnum FACQF1 { get; set; }
        public CupTeamsEnum FACQF2 { get; set; }
        public CupTeamsEnum FACQF3 { get; set; }
        public CupTeamsEnum FACQF4 { get; set; }
        public CupTeamsEnum FACQF5 { get; set; }
        public CupTeamsEnum FACQF6 { get; set; }
        public CupTeamsEnum FACQF7 { get; set; }
        public CupTeamsEnum FACQF8 { get; set; }
        public CupTeamsEnum FACSF1 { get; set; }
        public CupTeamsEnum FACSF2 { get; set; }
        public CupTeamsEnum FACSF3 { get; set; }
        public CupTeamsEnum FACSF4 { get; set; }
        public CupTeamsEnum FACWinner { get; set; }
        public CupTeamsEnum FACRunnerUp { get; set; }

        public TeamsEnum FirstScore25 { get; set; }
        public TeamsEnum FirstScore50 { get; set; }
        public TeamsEnum FirstScore75 { get; set; }
        public TeamsEnum FirstScore100 { get; set; }
        public TeamsEnum Con25 { get; set; }
        public TeamsEnum Con50 { get; set; }
        public TeamsEnum Con75 { get; set; }
        public TeamsEnum Con100 { get; set; }
        public TeamsEnum TeamHattrick { get; set; }
        public TeamsEnum TeamLoseManager { get; set; }
        public TeamsEnum Score5in1 { get; set; }
        public TeamsEnum Con5in1 { get; set; }
        public TeamsEnum Win5inRow { get; set; }
        public TeamsEnum Lose5inRow { get; set; }
        public TeamsEnum TwoReds { get; set; }
        public TeamsEnum Win20 { get; set; }

        public LeagueOneTeamsEnum LOTitle { get; set; }
        public LeagueOneTeamsEnum LORunnerUp { get; set; }
        public LeagueOneTeamsEnum LOPlayoff1 { get; set; }
        public LeagueOneTeamsEnum LOPlayoff2 { get; set; }
        public LeagueOneTeamsEnum LOPlayoff3 { get; set; }
        public LeagueOneTeamsEnum LOPlayoff4 { get; set; }
        public LeagueOneTeamsEnum LOPlayoffWinner { get; set; }
        public LeagueOneTeamsEnum LORelegation1 { get; set; }
        public LeagueOneTeamsEnum LORelegation2 { get; set; }
        public LeagueOneTeamsEnum LORelegation3 { get; set; }

        public LeagueTwoTeamsEnum LTTitle { get; set; }
        public LeagueTwoTeamsEnum LTRunnerUp { get; set; }
        public LeagueTwoTeamsEnum LTPlayoff1 { get; set; }
        public LeagueTwoTeamsEnum LTPlayoff2 { get; set; }
        public LeagueTwoTeamsEnum LTPlayoff3 { get; set; }
        public LeagueTwoTeamsEnum LTPlayoff4 { get; set; }
        public LeagueTwoTeamsEnum LTPlayoffWinner { get; set; }
        public LeagueTwoTeamsEnum LTRelegation1 { get; set; }
        public LeagueTwoTeamsEnum LTRelegation2 { get; set; }
        public LeagueTwoTeamsEnum LTRelegation3 { get; set; }

        public NationalLeagueTeamsEnum NLTitle { get; set; }
        public NationalLeagueTeamsEnum NLPlayoffWinner { get; set; }

        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public int Score3 { get; set; }
        public int Score4 { get; set; }
        public int Score5 { get; set; }
        public int Score6 { get; set; }
        public int Score7 { get; set; }
        public int Score8 { get; set; }
        public int Score9 { get; set; }
        public int Score10 { get; set; }
        public int Score11 { get; set; }
        public int Score12 { get; set; }
        public int Score13 { get; set; }
        public int Score14 { get; set; }
        public int Score15 { get; set; }
        public int Score16 { get; set; }
        public int Score17 { get; set; }
        public int Score18 { get; set; }
        public int Score19 { get; set; }
        public int Score20 { get; set; }
        public int Score21 { get; set; }
        public int Score22 { get; set; }
        public int Score23 { get; set; }
        public int Score24 { get; set; }
        public int Score25 { get; set; }
        public int Score26 { get; set; }
        public int Score27 { get; set; }
        public int Score28 { get; set; }
        public int Score29 { get; set; }
        public int Score30 { get; set; }
        public int Score31 { get; set; }
        public int Score32 { get; set; }
        public int Score33 { get; set; }
        public int Score34 { get; set; }
        public int Score35 { get; set; }
        public int Score36 { get; set; }
        public int Score37 { get; set; }
        public int Score38 { get; set; }
        public int Score39 { get; set; }
        public int Score40 { get; set; }
        public int Score41 { get; set; }
        public int Score42 { get; set; }
        public int Score43 { get; set; }
        public int Score44 { get; set; }
        public int Score45 { get; set; }
        public int Score46 { get; set; }
        public int Score47 { get; set; }
        public int Score48 { get; set; }
        public int Score49 { get; set; }
        public int Score50 { get; set; }
        public int Score51 { get; set; }
        public int Score52 { get; set; }
        public int Score53 { get; set; }
        public int Score54 { get; set; }
        public int Score55 { get; set; }
        public int Score56 { get; set; }
        public int Score57 { get; set; }
        public int Score58 { get; set; }
        public int Score59 { get; set; }
        public int Score60 { get; set; }
        public int Score61 { get; set; }
        public int Score62 { get; set; }
        public int Score63 { get; set; }
        public int Score64 { get; set; }
        public int Score65 { get; set; }
        public int Score66 { get; set; }
        public int Score67 { get; set; }
        public int Score68 { get; set; }
        public int Score69 { get; set; }
        public int Score70 { get; set; }
        public int Score71 { get; set; }
        public int Score72 { get; set; }
        public int Score73 { get; set; }
        public int Score74 { get; set; }
        public int Score75 { get; set; }
        public int Score76 { get; set; }
        public int Score77 { get; set; }
        public int Score78 { get; set; }

        public TeamsEnum Place1 { get; set; }
        public TeamsEnum Place2 { get; set; }
        public TeamsEnum Place3 { get; set; }
        public TeamsEnum Place4 { get; set; }
        public TeamsEnum Place5 { get; set; }
        public TeamsEnum Place6 { get; set; }
        public TeamsEnum Place7 { get; set; }
        public TeamsEnum Place8 { get; set; }
        public TeamsEnum Place9 { get; set; }
        public TeamsEnum Place10 { get; set; }
        public TeamsEnum Place11 { get; set; }
        public TeamsEnum Place12 { get; set; }
        public TeamsEnum Place13 { get; set; }
        public TeamsEnum Place14 { get; set; }
        public TeamsEnum Place15 { get; set; }
        public TeamsEnum Place16 { get; set; }
        public TeamsEnum Place17 { get; set; }
        public TeamsEnum Place18 { get; set; }
        public TeamsEnum Place19 { get; set; }
        public TeamsEnum Place20 { get; set; }
    }
}
