namespace FantasyLeague.Models
{
    public class TeamModel
    {
        public long Id { get; set; }

        public CurrentEventFixtureModel[] CurrentEventFixture { get; set; }

        public object[] NextEventFixture { get; set; }

        public string Name { get; set; }

        public long Code { get; set; }

        public string ShortName { get; set; }

        public bool Unavailable { get; set; }

        public long Strength { get; set; }

        public long Position { get; set; }

        public long Played { get; set; }

        public long Win { get; set; }

        public long Loss { get; set; }

        public long Draw { get; set; }

        public long Points { get; set; }

        public object Form { get; set; }

        public string LinkUrl { get; set; }

        public long StrengthOverallHome { get; set; }

        public long StrengthOverallAway { get; set; }

        public long StrengthAttackHome { get; set; }

        public long StrengthAttackAway { get; set; }

        public long StrengthDefenceHome { get; set; }

        public long StrengthDefenceAway { get; set; }

        public long TeamDivision { get; set; }
    }

    public class CurrentEventFixtureModel
    {
        public bool IsHome { get; set; }

        public long Month { get; set; }

        public long EventDay { get; set; }

        public long Id { get; set; }

        public long Day { get; set; }

        public long Opponent { get; set; }
    }
}
