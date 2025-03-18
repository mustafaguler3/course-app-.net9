using Course.DataAccess.Context;
using Course.Entities.Concrete;

namespace Course.API;

public class SeedDataLoader : IHostedService
{
    protected readonly IServiceProvider _serviceProvider;

    public SeedDataLoader(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using (var scope = _serviceProvider.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<CourseDbContext>();
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Java", CoverUrl = "/images/java.png" },
                    new Category { Name = "Angular", CoverUrl = "/images/angular.png" },
                    new Category { Name = "C#", CoverUrl = "/images/csharp.png" },
                    new Category { Name = "React", CoverUrl= "/images/react.png" },
                    new Category { Name = "Spring Boot", CoverUrl = "/images/spring-boot.png" },
                    new Category { Name = "Docker", CoverUrl = "/images/docker.png" },
                    new Category { Name = "Swift", CoverUrl = "/images/swift.png" }
                };

                context.Categories.AddRange(categories);
                await context.SaveChangesAsync();
                Console.WriteLine("Default categories loaded!");
            }
        }
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}