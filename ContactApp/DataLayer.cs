using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp
{
    public static class DataLayer
    {
        public const string constring = "Data Source=localhost;Initial Catalog=ContactDb1;Integrated Security=SSPI";
        private static SqlConnection conn = new SqlConnection(constring);
        private static SqlCommand cmd = new SqlCommand("", conn);
        private static SqlDataReader reader = null;
        public static List<AddressList> GetAddressList()
        {
            List<AddressList> list = new List<AddressList>();
            try
            {
                conn.Open();
                cmd.CommandText = "SELECT * FROM AddressList";
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AddressList addr = new AddressList();
                    addr.AddressId = Convert.ToInt16(reader["addressId"]);
                    addr.AddressName = Convert.ToString(reader["addressName"]);
                    addr.PostalCode = Convert.ToString(reader["postalCode"]);
                    list.Add(addr);
                }
                conn.Close();

            }
            catch (Exception e)
            {
                {
                    MessageBox.Show(e.Message);
                }
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return list;
        }
    }
}
