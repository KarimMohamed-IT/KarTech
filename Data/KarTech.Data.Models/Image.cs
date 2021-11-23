namespace KarTech.Data.Models
{
    using System;

    using KarTech.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Extension { get; set; }

        public string ComputerId { get; set; }

        public virtual Computer Computer { get; set; }

        public string AddedByUsedId { get; set; }

        public ApplicationUser AddedByUser { get; set; }
    }
}
