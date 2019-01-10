using System;


public interface IDateTime{
  DateTime Now { get; }
}


public class SystemDateTime : IDateTime
{
    public SystemDateTime()
    {
        
    }
    public DateTime Now => DateTime.Now;
}