using ProjetOuististiDomain.Stats;

namespace ProjetOuististiApplication.Objects
{
    public class StatisticsOutputDto
    {
        public int Additions { get; set; }
        public int Soustractions { get; set; }
        public int Multiplications { get; set; }
        public int Divisions { get; set; }

        public StatisticsOutputDto(Statistics stats) 
        {
            Additions = stats.Additions;
            Soustractions= stats.Soustractions;
            Multiplications = stats.Multiplications;
            Divisions = stats.Divisions;
        }
    }
}
