using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace adoDotNet
{
    class Program13
    {
        static void Main(string[] args)
        {
            new Program13().CreateTable();
            Console.Read();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=Student; integrated security=SSPI");
                String s_id, s_name;
                con.Open();
                do
                {
                    Console.WriteLine("please enter id");
                    s_id = Console.ReadLine();
                    Console.WriteLine("please enter name");
                    s_name = Console.ReadLine();
                    SqlCommand cm = new SqlCommand("insert into student2 VALUES("+ s_id + ",'" + s_name + "')", con);
                    cm.ExecuteNonQuery();
                    Console.WriteLine("do you want to insert one more(yes/no)?");

                }
                while ("yes".Equals(Console.ReadLine()));

                Console.WriteLine("Records Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }

            finally
            {
                con.Close();
            }
        }
    }
}
