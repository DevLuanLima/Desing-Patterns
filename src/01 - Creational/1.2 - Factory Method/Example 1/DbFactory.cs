namespace DesignPatterns._01___Creational._1._2___Factory_Method.Example_1
{
    // Abstract Creator
    public abstract class DbFactory
    {
        // Factory Method
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase dataBase)
        {
            if (dataBase == DataBase.SqlServer)
                return new SqlFactory();
            if (dataBase == DataBase.Oracle)
                return new OracleFactory();

            throw new ApplicationException("Banco de dados não reconhecido.");
        }
    }
}
