using DataAccess.Repositories;

public class FileRepository: BaseRepository<File>, IFileRepository  {
   public FileRepository(FileSharingContext ctx): base(ctx)
   {
       
   }
}