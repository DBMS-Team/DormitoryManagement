using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace DormitoryManagement
{
   public static class DataProvider
   {
      //private static string connectionString = @"Data Source=DESKTOP-VJSMPL6;Initial Catalog=DormitoryManagement;Integrated Security=True";
      //private static string connectionString = @"Data Source=Hiae\HOHUYHOANG;Initial Catalog=DormitoryManagement;Integrated Security=True";
      //private static string connectionString = @"Data Source=(local);Initial Catalog=DormitoryManagement;Integrated Security=True";

      private static string connectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

      public static DataTable ExcuteQuery(string query, object[] parameter = null)
      {
         DataTable data = new DataTable();

         try
         {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();

               SqlCommand command = new SqlCommand(query, connection);
               SetParameters(query, command, parameter);
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(data);

               connection.Close();
            }
         }
         catch (System.Exception e)
         {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

         return data;
      }

      public static int ExcuteNonQuery(string query, object[] parameter = null)
      {
         int data = 0;

         try
         {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();

               SqlCommand command = new SqlCommand(query, connection);
               SetParameters(query, command, parameter);
               data = command.ExecuteNonQuery();

               connection.Close();
            }
         }
         catch (System.Exception e)
         {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         
         return data;
      }

      public static object ExcuteScalar(string query, object[] parameter = null)
      {
         object data = 0;

         try
         {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();

               SqlCommand command = new SqlCommand(query, connection);
               SetParameters(query, command, parameter);
               data = command.ExecuteScalar();

               connection.Close();
            }
         }
         catch (System.Exception e)
         {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

         return data;
      }

      private static void SetParameters(string query, SqlCommand command, object[] parameter = null)
      {
         if (parameter != null)
         {
            string[] ListPara = query.Split(' ');// cắt chuỗi theo khoảng trắng
            int i = 0;
            foreach (string item in ListPara)
            {
               if (item.Contains('@'))
               {
                  command.Parameters.AddWithValue(item, parameter[i]);
                  i++;
               }
            }
         }
      }
   }
}