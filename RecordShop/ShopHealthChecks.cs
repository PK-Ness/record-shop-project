using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Text.Json;
using RecordShop.Models;

namespace RecordShop
{
    public class ShopHealthChecks :IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var jsonFilePath = ".\\Repositories\\AlbumData.json";
            var jsonData = await File.ReadAllTextAsync(jsonFilePath);
            var albumsData = JsonSerializer.Deserialize<List<Album>>(jsonData);
            int albums = albumsData.Count();
            if (albums > 0)
            {
                return HealthCheckResult.Healthy();
            }
            else
            {
                return HealthCheckResult.Unhealthy();
            }


        }
    }
}
