using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adoDotNet
{
    class Program14
    {
        static void Main(string[] args)
        {
            new Program14().CreateTable();
            Console.Read();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=.; database=Student; integrated security=SSPI");

                SqlCommand cm = new SqlCommand("SELECT * FROM Student3 INNER JOIN StudentCourse ON Student3.ROLL_NO = StudentCourse.ROLL_NO", con);

                con.Open();

                SqlDataReader sdr = cm.ExecuteReader();

                while (sdr.Read())
                {
                    Console.WriteLine(sdr["ROLL_NO"] + " " + sdr["NAME"] + " " + sdr["Age"] + " " + sdr["PHONE"] + " " + sdr["ADDRESS"] + " " + sdr["COURSE_ID"]); // Displaying Record  
                }

                Console.WriteLine("Records retrive Successfully");
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
