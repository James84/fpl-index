using FantasyLeague.Domain.Enums;
using System;
using FantasyLeague.Domain;

namespace FantasyLeague.Models
{
    public class PlayerModel
    {
        public long Id { get; set; }

        public string Photo { get; set; }

        public string WebName { get; set; }

        public long TeamCode { get; set; }

        public string Status { get; set; }

        public long Code { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public long? SquadNumber { get; set; }

        public string News { get; set; }

        public long NowCost { get; set; }

        public DateTimeOffset? NewsAdded { get; set; }

        public long? ChanceOfPlayingThisRound { get; set; }

        public long? ChanceOfPlayingNextRound { get; set; }

        public string ValueForm { get; set; }

        public string ValueSeason { get; set; }

        public long CostChangeStart { get; set; }

        public long CostChangeEvent { get; set; }

        public long CostChangeStartFall { get; set; }

        public long CostChangeEventFall { get; set; }

        public bool InDreamteam { get; set; }

        public long DreamteamCount { get; set; }

        public string SelectedByPercent { get; set; }

        public string Form { get; set; }

        public long TransfersOut { get; set; }

        public long TransfersIn { get; set; }

        public long TransfersOutEvent { get; set; }

        public long TransfersInEvent { get; set; }

        public long LoansIn { get; set; }

        public long LoansOut { get; set; }

        public long LoanedIn { get; set; }

        public long LoanedOut { get; set; }

        public long TotalPoints { get; set; }

        public long EventPoints { get; set; }

        public string PointsPerGame { get; set; }

        public string EpThis { get; set; }

        public string EpNext { get; set; }

        public bool Special { get; set; }

        public long Minutes { get; set; }

        public long GoalsScored { get; set; }

        public long Assists { get; set; }

        public long CleanSheets { get; set; }

        public long GoalsConceded { get; set; }

        public long OwnGoals { get; set; }

        public long PenaltiesSaved { get; set; }

        public long PenaltiesMissed { get; set; }

        public long YellowCards { get; set; }

        public long RedCards { get; set; }

        public long Saves { get; set; }

        public long Bonus { get; set; }

        public long Bps { get; set; }

        public string Influence { get; set; }

        public string Creativity { get; set; }

        public string Threat { get; set; }

        public string IctIndex { get; set; }

        public long EaIndex { get; set; }

        public Position ElementType { get; set; }

        public Teams Team { get; set; }

        public PlayerSummaryModel PlayerSummary { get; set; }
    }
}
