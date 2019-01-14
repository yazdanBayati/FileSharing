using Core;
using Microsoft.EntityFrameworkCore;

public class FileSharingContext : DbContext, IUnitOfWork
{
    
    public FileSharingContext(DbContextOptions<FileSharingContext> options):base(options)
    {
        
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