using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryIncreaseTest.Code
{
    public class DbProxy
    {
        private readonly string _connectionString = $@"Server=(localdb)\mssqllocaldb;AttachDbFilename={System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(),"MyDatabase.mdf")};Trusted_Connection=True;MultipleActiveResultSets=true;";

        public async Task Insert(byte[] data) 
        {
            //using var con = new SqlConnection(_connectionString);
            //await con.OpenAsync();
            //using var cmd = new SqlCommand("INSERT INTO dbo.MyTable(Id, ReceivedData) VALUES(@Id, @ReceivedData)", con);
            //cmd.Parameters.AddWithValue("@Id", Guid.NewGuid());
            //cmd.Parameters.AddWithValue("@ReceivedData", data);
            //await cmd.ExecuteNonQueryAsync();

            await Task.Delay(50);

        }

    }
}
