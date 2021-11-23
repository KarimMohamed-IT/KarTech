namespace KarTech.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using KarTech.Common;
    using KarTech.Data.Models;

    public class GpuSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.GraphicsCards.Any())
            {
                return;
            }

            using (var reader = new StreamReader(GlobalConstants.GpuPath))
            {
                var line = await reader.ReadLineAsync();
                while (!reader.EndOfStream)
                {
                    line = await reader.ReadLineAsync();
                    var values = line.Split(',');

                    var gpu = new GraphicsCard
                    {
                        Brand = values[2],
                        Model = values[3],
                        Rank = int.Parse(values[4]),
                        Benchmark = float.Parse(values[5]),
                    };

                    await dbContext.GraphicsCards.AddAsync(gpu);
                }

                await dbContext.SaveChangesAsync();
            }
        }
    }
}
