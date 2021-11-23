using System.Collections.Generic;

namespace KarTech.Services.Data
{
    public interface IRamItemsService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllRamItems();
    }
}