using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace FantasyLeague.Domain
{
    public class PlayerSummary
    {
        [JsonProperty("history_past")]
        public HistoryPast[] HistoryPast { get; set; }

        [JsonProperty("fixtures_summary")]
        public object[] FixturesSummary { get; set; }

        [JsonProperty("explain")]
        public ExplainCollection[] Explain { get; set; }

        [JsonProperty("history_summary")]
        public History[] HistorySummary { get; set; }

        [JsonProperty("fixtures")]
        public object[] Fixtures { get; set; }

        [JsonProperty("history")]
        public History[] History { get; set; }
    }

    public class ExplainCollection
    {
        [JsonProperty("explain")]
        public Explain Explain { get; set; }

        [JsonProperty("fixture")]
        public Fixture Fixture { get; set; }
    }

    public class Explain
    {
        [JsonProperty("minutes")]
        public Minutes Minutes { get; set; }
    }

    public class Minutes
    {
        [JsonProperty("points")]
        public long Points { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }

    public class Fixture
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("kickoff_time_formatted")]
        public string KickoffTimeFormatted { get; set; }

        [JsonProperty("started")]
        public bool Started { get; set; }

        [JsonProperty("event_day")]
        public long EventDay { get; set; }

        [JsonProperty("deadline_time")]
        public DateTimeOffset DeadlineTime { get; set; }

        [JsonProperty("deadline_time_formatted")]
        public string DeadlineTimeFormatted { get; set; }

        [JsonProperty("stats")]
        public Dictionary<string, Stat>[] Stats { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("kickoff_time")]
        public DateTimeOffset KickoffTime { get; set; }

        [JsonProperty("team_h_score")]
        public long TeamHomeScore { get; set; }

        [JsonProperty("team_a_score")]
        public long TeamAwayScore { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("minutes")]
        public long Minutes { get; set; }

        [JsonProperty("provisional_start_time")]
        public bool ProvisionalStartTime { get; set; }

        [JsonProperty("finished_provisional")]
        public bool FinishedProvisional { get; set; }

        [JsonProperty("event")]
        public long Event { get; set; }

        [JsonProperty("team_a")]
        public long TeamAway { get; set; }

        [JsonProperty("team_h")]
        public long TeamHome { get; set; }
    }

    public class Stat
    {
        [JsonProperty("a")]
        public Away[] Away { get; set; }

        [JsonProperty("h")]
        public Away[] Home { get; set; }
    }

    public class Away
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("element")]
        public long Element { get; set; }
    }

    public class History
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("kickoff_time")]
        public DateTimeOffset KickoffTime { get; set; }

        [JsonProperty("kickoff_time_formatted")]
        public string KickoffTimeFormatted { get; set; }

        [JsonProperty("team_h_score")]
        public long TeamHomeScore { get; set; }

        [JsonProperty("team_a_score")]
        public long TeamAwayScore { get; set; }

        [JsonProperty("was_home")]
        public bool WasHome { get; set; }

        [JsonProperty("round")]
        public long Round { get; set; }

        [JsonProperty("total_points")]
        public long TotalPoints { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("transfers_balance")]
        public long TransfersBalance { get; set; }

        [JsonProperty("selected")]
        public long Selected { get; set; }

        [JsonProperty("transfers_in")]
        public long TransfersIn { get; set; }

        [JsonProperty("transfers_out")]
        public long TransfersOut { get; set; }

        [JsonProperty("loaned_in")]
        public long LoanedIn { get; set; }

        [JsonProperty("loaned_out")]
        public long LoanedOut { get; set; }

        [JsonProperty("minutes")]
        public long Minutes { get; set; }

        [JsonProperty("goals_scored")]
        public long GoalsScored { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("clean_sheets")]
        public long CleanSheets { get; set; }

        [JsonProperty("goals_conceded")]
        public long GoalsConceded { get; set; }

        [JsonProperty("own_goals")]
        public long OwnGoals { get; set; }

        [JsonProperty("penalties_saved")]
        public long PenaltiesSaved { get; set; }

        [JsonProperty("penalties_missed")]
        public long PenaltiesMissed { get; set; }

        [JsonProperty("yellow_cards")]
        public long YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public long RedCards { get; set; }

        [JsonProperty("saves")]
        public long Saves { get; set; }

        [JsonProperty("bonus")]
        public long Bonus { get; set; }

        [JsonProperty("bps")]
        public long Bps { get; set; }

        [JsonProperty("influence")]
        public string Influence { get; set; }

        [JsonProperty("creativity")]
        public string Creativity { get; set; }

        [JsonProperty("threat")]
        public string Threat { get; set; }

        [JsonProperty("ict_index")]
        public string IctIndex { get; set; }

        [JsonProperty("ea_index")]
        public long EaIndex { get; set; }

        [JsonProperty("open_play_crosses")]
        public long OpenPlayCrosses { get; set; }

        [JsonProperty("big_chances_created")]
        public long BigChancesCreated { get; set; }

        [JsonProperty("clearances_blocks_interceptions")]
        public long ClearancesBlocksInterceptions { get; set; }

        [JsonProperty("recoveries")]
        public long Recoveries { get; set; }

        [JsonProperty("key_passes")]
        public long KeyPasses { get; set; }

        [JsonProperty("tackles")]
        public long Tackles { get; set; }

        [JsonProperty("winning_goals")]
        public long WinningGoals { get; set; }

        [JsonProperty("attempted_passes")]
        public long AttemptedPasses { get; set; }

        [JsonProperty("completed_passes")]
        public long CompletedPasses { get; set; }

        [JsonProperty("penalties_conceded")]
        public long PenaltiesConceded { get; set; }

        [JsonProperty("big_chances_missed")]
        public long BigChancesMissed { get; set; }

        [JsonProperty("errors_leading_to_goal")]
        public long ErrorsLeadingToGoal { get; set; }

        [JsonProperty("errors_leading_to_goal_attempt")]
        public long ErrorsLeadingToGoalAttempt { get; set; }

        [JsonProperty("tackled")]
        public long Tackled { get; set; }

        [JsonProperty("offside")]
        public long Offside { get; set; }

        [JsonProperty("target_missed")]
        public long TargetMissed { get; set; }

        [JsonProperty("fouls")]
        public long Fouls { get; set; }

        [JsonProperty("dribbles")]
        public long Dribbles { get; set; }

        [JsonProperty("element")]
        public long Element { get; set; }

        [JsonProperty("fixture")]
        public long Fixture { get; set; }

        [JsonProperty("opponent_team")]
        public long OpponentTeam { get; set; }
    }

    public class HistoryPast
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("season_name")]
        public string SeasonName { get; set; }

        [JsonProperty("element_code")]
        public long ElementCode { get; set; }

        [JsonProperty("start_cost")]
        public long StartCost { get; set; }

        [JsonProperty("end_cost")]
        public long EndCost { get; set; }

        [JsonProperty("total_points")]
        public long TotalPoints { get; set; }

        [JsonProperty("minutes")]
        public long Minutes { get; set; }

        [JsonProperty("goals_scored")]
        public long GoalsScored { get; set; }

        [JsonProperty("assists")]
        public long Assists { get; set; }

        [JsonProperty("clean_sheets")]
        public long CleanSheets { get; set; }

        [JsonProperty("goals_conceded")]
        public long GoalsConceded { get; set; }

        [JsonProperty("own_goals")]
        public long OwnGoals { get; set; }

        [JsonProperty("penalties_saved")]
        public long PenaltiesSaved { get; set; }

        [JsonProperty("penalties_missed")]
        public long PenaltiesMissed { get; set; }

        [JsonProperty("yellow_cards")]
        public long YellowCards { get; set; }

        [JsonProperty("red_cards")]
        public long RedCards { get; set; }

        [JsonProperty("saves")]
        public long Saves { get; set; }

        [JsonProperty("bonus")]
        public long Bonus { get; set; }

        [JsonProperty("bps")]
        public long Bps { get; set; }

        [JsonProperty("influence")]
        public string Influence { get; set; }

        [JsonProperty("creativity")]
        public string Creativity { get; set; }

        [JsonProperty("threat")]
        public string Threat { get; set; }

        [JsonProperty("ict_index")]
        public string IctIndex { get; set; }

        [JsonProperty("ea_index")]
        public long EaIndex { get; set; }

        [JsonProperty("season")]
        public long Season { get; set; }
    }
}
