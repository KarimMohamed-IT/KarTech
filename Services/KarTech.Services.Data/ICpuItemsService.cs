namespace KarTech.Services.Data
{
    using System.Collections.Generic;

    public interface ICpuItemsService
    {
        public IEnumerable<KeyValuePair<string, string>> GetAllCpuItems ();
    }
}
