namespace KarTech.Data.Models
{
    using KarTech.Data.Common.Models;

    public class RAM : BaseDeletableModel<int>
    {
        public byte Gb { get; set; }
    }
}
