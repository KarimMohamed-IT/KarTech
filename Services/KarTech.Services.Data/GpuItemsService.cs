namespace KarTech.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using KarTech.Data.Common.Repositories;
    using KarTech.Data.Models;

    public class GpuItemsService : IGpuItemsService
    {
        private readonly IDeletableEntityRepository<GraphicsCard> graphicsCardRepository;

        public GpuItemsService(IDeletableEntityRepository<GraphicsCard> graphicsCardRepository)
        {
            this.graphicsCardRepository = graphicsCardRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllGpuItems()
        {
            return this.graphicsCardRepository.All().OrderBy(x => x.Rank).Select(x =>
            new { x.Id, x.Model, x.Brand }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(),$"{x.Brand} {x.Model}"));
        }
    }
}
