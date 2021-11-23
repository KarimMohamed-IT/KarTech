namespace KarTech.Data.Models
{
    using System;
    using System.Collections.Generic;

    using KarTech.Data.Common.Models;

    public class Computer : BaseDeletableModel<string>
    {
        public Computer()
        {
            this.Storages = new HashSet<Storage>();
            this.Id = Guid.NewGuid().ToString();
        }

        public decimal Price { get; set; }

        public Processor Processor { get; set; }

        public GraphicsCard GraphicsCard { get; set; }

        public RAM RAM { get; set; }

        public Type Type { get; set; }

        public Brand Brand { get; set; }

        public string UserId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<Storage> Storages { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}
