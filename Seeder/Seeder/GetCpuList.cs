using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using KarTech.Data.Models;

namespace KarTech.Seeder
{
    public class GetCpuList
    {
       
        private List<CPU> listCpu;
        private readonly string path = @"Seeder\Files\AllCpu.csv";
        public GetCpuList()
        {
            listCpu = new List<CPU>();
        }
        public async Task<List<CPU>> CpuList()
        {
            using var cpuStreamReader = new StreamReader(path);
            var titleGetter = await cpuStreamReader.ReadLineAsync();

            while (!cpuStreamReader.EndOfStream)
            {
                var line = await cpuStreamReader.ReadLineAsync();
                var values = line.Split(",");

                CPU cpu = new CPU()
                {
                    Brand = values[2],
                    Model = values[3],
                    Rank = int.Parse(values[4]),
                    Benchmark = float.Parse($"{values[5]:f2}")
                };
                lock (this)
                {
                    listCpu.Add(cpu);
                }
            }
            return listCpu;
        }
    }
}
