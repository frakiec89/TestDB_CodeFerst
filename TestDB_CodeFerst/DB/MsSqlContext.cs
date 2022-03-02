using Microsoft.EntityFrameworkCore;


namespace TestDB_CodeFerst.DB
{
    public class MsSqlContext :DbContext
    {
        static string adress = "192.168.10.134";
        static string name = "AgtyamovTestDb_IS_20_03"; //так будет  называться бд - у каждого своя
        static string login = "stud";
        static string password = "stud";

        string connectionString = $"Server = {adress}; Database = {name}; User Id = {login}; Password = {password};";
        

     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Record> Records { get; set; }
    }
}
