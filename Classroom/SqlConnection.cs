using System;

namespace Classroom
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection)
            : base(connection)
        {
            Console.WriteLine("Set up MS SQL connection object");
        }

        public override void ConnOpen()
        {
            Console.WriteLine("Connected to MS SQL");
        }

        public override void ConnClose()
        {
            Console.WriteLine("Disconnected from MS SQL");
        }
    }

}


