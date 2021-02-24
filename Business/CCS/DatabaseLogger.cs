using System;

namespace Business.CCS
{
    public class DatabaseLogger : ILoger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
