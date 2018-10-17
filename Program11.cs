using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adoDotNet
{
    class Program11
    {
        static void Main(string[] args)
        {
            new Program11().CreateTable();
            Console.Read();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("data source=.; database=student; integrated security=SSPI");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student2 (s_id, s_name)values('1', 'hari')", con);
                SqlCommand cm1 = new SqlCommand("insert into student2 (s_id, s_name)values('2', 'anji')", con);
                SqlCommand cm2 = new SqlCommand("insert into student2 (s_id, s_name)values('3', 'manu')", con);
                SqlCommand cm3 = new SqlCommand("insert into student2 (s_id, s_name)values('4', 'venu')", con);
                SqlCommand cm4 = new SqlCommand("insert into student2 (s_id, s_name)values('5', 'ganesh')", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                cm1.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm4.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
