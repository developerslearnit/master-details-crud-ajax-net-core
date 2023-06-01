using MasterDetailsCrudAjax.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterDetailsCrudAjax.ServiceInstaller
{
    public class DbContextInstaller : IInstaller
    {
        public void InstallServices(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                      options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"),
                        sqlServerOptionsAction: sqlOptions =>
                        {
                            sqlOptions.EnableRetryOnFailure(
                                maxRetryCount: 10,
                                maxRetryDelay: TimeSpan.FromSeconds(30),
                                errorNumbersToAdd: null
                                );
                        }));
        }
    }
}
