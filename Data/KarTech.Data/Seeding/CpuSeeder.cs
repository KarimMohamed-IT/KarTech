namespace KarTech.Data.Seeding
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using KarTech.Common;
    using KarTech.Data.Models;

    public class CpuSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Processors.Any())
            {
                return;
            }

            using (var reader = new StreamReader(GlobalConstants.CpuPath))
            {
                var line = await reader.ReadLineAsync();
                while (!reader.EndOfStream)
                {
                    line = await reader.ReadLineAsync();
                    var values = line.Split(',');

                    var cpu = new Processor
                    {
                        Brand = values[2],
                        Model = values[3],
                        Rank = int.Parse(values[4]),
                        Benchmark = float.Parse(values[5]),
                    };

                    await dbContext.Processors.AddAsync(cpu);
                }
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
