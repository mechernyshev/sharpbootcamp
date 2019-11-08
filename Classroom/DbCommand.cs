using System;

namespace Classroom
{
    public class DbCommand
    {
        private DbConnection _dbConnection;

        public DbCommand(DbConnection dbConnection)
        {
            if (!(dbConnection is null))
            {
                Console.WriteLine("command instantiated");
                _dbConnection = dbConnection;
            }
            else
            {
                throw new NullReferenceException("missing connection to the database");
            }
        }

        public void Execute (string command)
        {
            this._dbConnection.ConnOpen();
            Console.WriteLine("Command {0} is executed", command);
            this._dbConnection.ConnClose();
        }
    }


}


