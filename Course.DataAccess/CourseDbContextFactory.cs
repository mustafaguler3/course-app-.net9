using Course.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SQLitePCL;

namespace Course.DataAccess;

public class CourseDbContextFactory : IDesignTimeDbContextFactory<CourseDbContext>
{
    public CourseDbContext CreateDbContext(string[] args)
    {
        
        
        Batteries.Init();
        
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("/Users/mustafa/Projects/course-app/Course.API/appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<CourseDbContext>();
            optionsBuilder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));

            return new CourseDbContext(optionsBuilder.Options);
        
    }
}