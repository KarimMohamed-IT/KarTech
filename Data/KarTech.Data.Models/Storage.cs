namespace KarTech.Data.Models
{
    using KarTech.Data.Common.Models;

    public class Storage : BaseDeletableModel<int>
    {
        public int Capacity { get; set; }

        public bool IsSSD { get; set; }

        public string ComputerId { get; set; }

        public Computer Computer { get; set; }
    }
}
