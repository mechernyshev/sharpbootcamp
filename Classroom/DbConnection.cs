using System;

namespace Classroom
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connection)
        {
            if (!String.IsNullOrWhiteSpace(connection))
            {
                ConnectionString = connection;
                Console.WriteLine("using connection string {0}", connection);
            }
            else
            {
                throw new NullReferenceException("connection string is empty");
            }   
        }


        public abstract void ConnOpen();

        public abstract void ConnClose();
        
    }


}


