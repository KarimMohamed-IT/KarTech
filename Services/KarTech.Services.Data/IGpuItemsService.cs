namespace KarTech.Services.Data
{
    using System.Collections.Generic;

    public interface IGpuItemsService
    {
        public IEnumerable<KeyValuePair<string, string>> GetAllGpuItems ();
    }
}
