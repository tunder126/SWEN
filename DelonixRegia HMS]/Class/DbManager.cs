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
        public static int insertCustomer(string RoomNumber, string firstName, string lastName, string PhoneNum, string Email, string streetAdd, string postalCode, string countryofOrigin)
        {
            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO [Customer](F_Name, L_Name, Phone_No, Email, Street_Add, Postal_Code, Country_Origin) ( VALUES (@firstName, @lastName, @PhoneNum, @Email, @streetAddress, @postalCode, @countryofOrigin)";
                comm.Parameters.AddWithValue("@lastname", lastName);              
                comm.Parameters.AddWithValue("@firstname", firstName);
                comm.Parameters.AddWithValue("@phonenumber", PhoneNum);
                comm.Parameters.AddWithValue("@email", Email);
                comm.Parameters.AddWithValue("@streetAddress", streetAdd);
                comm.Parameters.AddWithValue("@postalcode", postalCode);
                comm.Parameters.AddWithValue("@countryoforigin", countryofOrigin);
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

