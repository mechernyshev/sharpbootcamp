using System;

namespace Classroom
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection)
            : base (connection)
        {
            Console.WriteLine("Set up Oracle connection object");
        }

        public override void ConnOpen()
        {
            Console.WriteLine("Connected to Oracle");
        }

        public override void ConnClose()
        {
            Console.WriteLine("Disconnected from Oracle");
        }
    }

}


