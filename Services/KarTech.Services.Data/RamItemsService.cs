namespace KarTech.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using KarTech.Data.Common.Repositories;
    using KarTech.Data.Models;

    public class RamItemsService : IRamItemsService
    {
        private readonly IDeletableEntityRepository<RAM> ramRepository;

        public RamItemsService(IDeletableEntityRepository<RAM> ramRepository)
        {
            this.ramRepository = ramRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllRamItems()
        {
            return this.ramRepository.All().Select(x => new { x.Id, x.Gb }).ToList().OrderBy(x => x.Gb).Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Gb.ToString() + " GB."));
        }
    }
}
