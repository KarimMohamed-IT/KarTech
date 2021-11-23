namespace KarTech.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using KarTech.Data.Common.Repositories;
    using KarTech.Data.Models;

    public class CpuItemsService : ICpuItemsService
    {
        private readonly IDeletableEntityRepository<Processor> processorRepository;

        public CpuItemsService(IDeletableEntityRepository<Processor> processorRepository)
        {
            this.processorRepository = processorRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllCpuItems()
        {
            return this.processorRepository.All().OrderBy(x => x.Rank).Select(x =>
            new { x.Id, x.Model, x.Brand }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), $"{x.Brand} {x.Model}"));
        }
    }
}
