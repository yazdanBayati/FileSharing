using System.Threading.Tasks;
using Core;
using DataAccess;
using Microsoft.EntityFrameworkCore;

public class FileSharingContext : DbContext, IUintOfWork
{
    
    private string _cnnStr;
     public FileSharingContext(DbContextOptions<FileSharingContext> optionsBuilder):base(optionsBuilder)
    {
        
    }
    public FileSharingContext(string cnnStr)
    {
        this._cnnStr = cnnStr;
    }
   

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     //optionsBuilder.UseSqlServer(_cnnStr);
    //    optionsBuilder.IsConfigured
    //    optionsBuilder.
    //    optionsBuilder.UseNpgsql(_cnnStr);
    // }

    public DbSet<File> Files {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<File>()
        .ToTable("File" , "FH")  
        .HasKey(x => x.Id);
    }
   
    public int Commit(int userId)
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

    public async Task<int> CommitAsync()
    {
       return await this.SaveChangesAsync();
    }

    public Task<int> CommitAsync(int userId)
    {
        throw new System.NotImplementedException();
    }

    public int Commit()
    {
        return this.SaveChanges();
    }
    
}