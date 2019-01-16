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
        optionsBuilder.UseNpgsql(this._connStr);
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
}