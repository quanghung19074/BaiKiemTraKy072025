
using KTMVC.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Person> Person { get; set; }
}
//dotnet aspnet-codegenerator controller -name PersonController -m Person -dc KTMVC.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

//dotnet aspnet-codegenerator controller -name PersonController -m KTMVC.Models.Person -dc KTMVC.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
