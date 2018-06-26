using System;
using System.Collections.Generic;

namespace FantasyLeague.Models
{
    public class PlayerSummaryModel
    {
        public HistoryPastModel[] HistoryPast { get; set; }

        public object[] FixturesSummary { get; set; }

        public ExplainCollectionModel[] Explain { get; set; }

        public HistoryModel[] HistorySummary { get; set; }

        public object[] Fixtures { get; set; }

        public HistoryModel[] History { get; set; }
    }

    public class ExplainCollectionModel
    {
        public ExplainModel Explain { get; set; }

        public FixtureModel Fixture { get; set; }
    }

    public class ExplainModel
    {
        public MinutesModel Minutes { get; set; }
    }

    public class MinutesModel
    {
        public long Points { get; set; }

        public string Name { get; set; }

        public long Value { get; set; }
    }

    public class FixtureModel
    {
        public long Id { get; set; }

        public string KickoffTimeFormatted { get; set; }

        public bool Started { get; set; }

        public long EventDay { get; set; }

        public DateTimeOffset DeadlineTime { get; set; }

        public string DeadlineTimeFormatted { get; set; }

        public Dictionary<string, StatModel>[] Stats { get; set; }

        public long Code { get; set; }

        public DateTimeOffset KickoffTime { get; set; }

        public long TeamHomeScore { get; set; }

        public long TeamAwayScore { get; set; }

        public bool Finished { get; set; }

        public long Minutes { get; set; }

        public bool ProvisionalStartTime { get; set; }

        public bool FinishedProvisional { get; set; }

        public long Event { get; set; }

        public long TeamAway { get; set; }

        public long TeamHome { get; set; }
    }

    public class StatModel
    {
        public AwayModel[] Away { get; set; }

        public AwayModel[] Home { get; set; }
    }

    public class AwayModel
    {
        public long Value { get; set; }

        public long Element { get; set; }
    }

    public class HistoryModel
    {
        public long Id { get; set; }

        public DateTimeOffset KickoffTime { get; set; }

        public string KickoffTimeFormatted { get; set; }

        public long TeamHomeScore { get; set; }

        public long TeamAwayScore { get; set; }

        public bool WasHome { get; set; }

        public long Round { get; set; }

        public long TotalPoints { get; set; }

        public long Value { get; set; }

        public long TransfersBalance { get; set; }

        public long Selected { get; set; }

        public long TransfersIn { get; set; }

        public long TransfersOut { get; set; }

        public long LoanedIn { get; set; }

        public long LoanedOut { get; set; }

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

        public long OpenPlayCrosses { get; set; }

        public long BigChancesCreated { get; set; }

        public long ClearancesBlocksInterceptions { get; set; }

        public long Recoveries { get; set; }

        public long KeyPasses { get; set; }

        public long Tackles { get; set; }

        public long WinningGoals { get; set; }

        public long AttemptedPasses { get; set; }

        public long CompletedPasses { get; set; }

        public long PenaltiesConceded { get; set; }

        public long BigChancesMissed { get; set; }

        public long ErrorsLeadingToGoal { get; set; }

        public long ErrorsLeadingToGoalAttempt { get; set; }

        public long Tackled { get; set; }

        public long Offside { get; set; }

        public long TargetMissed { get; set; }

        public long Fouls { get; set; }

        public long Dribbles { get; set; }

        public long Element { get; set; }

        public long Fixture { get; set; }

        public long OpponentTeam { get; set; }
    }

    public class HistoryPastModel
    {
        public long Id { get; set; }

        public string SeasonName { get; set; }

        public long ElementCode { get; set; }

        public long StartCost { get; set; }

        public long EndCost { get; set; }

        public long TotalPoints { get; set; }

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

        public long Season { get; set; }
    }
}
