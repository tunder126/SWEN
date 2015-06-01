using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelonixRegia_HMS_.Class
{
    class DbManager
    {
        //#1 Method insertCustomer
        public static int insertCustomer(string firstName)
        {
            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["EWDTdbConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO [Customer](F_Name) VALUES (@firstName)";
                comm.Parameters.AddWithValue("@firstname", firstName);

                rowsinserted = comm.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }

        //#2 Method insertBooking

        //#3 Method updateRoomInformationTable
    }
}
