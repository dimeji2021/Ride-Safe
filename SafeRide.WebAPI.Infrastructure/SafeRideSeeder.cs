
using Newtonsoft.Json;
using SafeRide.WebAPI.Domain.Models;
using SafeRide.WebAPI.Infrastructure.DataBase;

namespace SafeRide.WebAPI.Infrastructure
{
    public class SafeRideSeeder
    {
        public static void  SeedData(SafeRideContext dbContext)
        {
            var baseDir = Directory.GetCurrentDirectory();

             dbContext.Database.EnsureCreated();

            if (!dbContext.AppRatings.Any())
            {

                var path = File.ReadAllText(FilePath(baseDir, "SafeRideDB/AppRating.json"));

                var hbaUsers = JsonConvert.DeserializeObject<List<AppRating>>(path);

                 dbContext.AddRange(hbaUsers);
                dbContext.SaveChanges();
            }

        }
        static string FilePath(string folderName, string fileName)
        {
            return Path.Combine(folderName, fileName);
        }
    }

}
