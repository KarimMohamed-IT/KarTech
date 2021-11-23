namespace KarTech.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using KarTech.Data.Models;

    public class RamSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.RAMs.Any())
            {
                return;
            }

            await dbContext.RAMs.AddAsync(new RAM() { Gb = 2 });
            await dbContext.RAMs.AddAsync(new RAM() { Gb = 4 });
            await dbContext.RAMs.AddAsync(new RAM() { Gb = 6 });
            await dbContext.RAMs.AddAsync(new RAM() { Gb = 8 });
            await dbContext.RAMs.AddAsync(new RAM() { Gb = 10 });
            await dbContext.RAMs.AddAsync(new RAM() { Gb = 12 });
            await dbContext.RAMs.AddAsync(new RAM() { Gb = 16 });
            await dbContext.RAMs.AddAsync(new RAM() { Gb = 24 });
            await dbContext.RAMs.AddAsync(new RAM() { Gb = 36 });
            await dbContext.SaveChangesAsync();
        }
    }
}
