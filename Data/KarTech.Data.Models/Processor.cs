namespace KarTech.Data.Models
{
    using KarTech.Data.Common.Models;

    public class Processor : BaseDeletableModel<int>
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Rank { get; set; }

        public float Benchmark { get; set; }
    }
}
