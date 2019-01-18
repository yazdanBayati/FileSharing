using System.Threading.Tasks;
using Core;
using Microsoft.EntityFrameworkCore;

public class FileSharingContext : DbContext, IUintOfWork
{
    
    private string _connStr;
    public FileSharingContext(string connStr)
    {
        this._connStr = connStr;
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=123;Database=FileSharing;");
    }

    public DbSet<File> Files {get; set;}
    public void Commit()
    {
        this.SaveChanges();
    }

    public void Commit(int userId)
    {
        throw new System.NotImplementedException();
    }

    public void Start()
    {
        throw new System.NotImplementedException();
    }

    public Task StartAsync()
    {
        throw new System.NotImplementedException();
    }

    public async Task CommitAsync()
    {
        await this.SaveChangesAsync();
    }

    public Task CommitAsync(int userId)
    {
        throw new System.NotImplementedException();
    }
}