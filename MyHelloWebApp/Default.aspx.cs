using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace MyHelloWebApp
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
            string query = "select * from dbo.Product";

            using (SqlConnection sqlConnection = new SqlConnection(conString))
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                try
                {
                    sqlConnection.Open();
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    DataSet dataSet = new DataSet("set");
                    sqlDataAdapter.Fill(dataSet);

                    lblProducts.Text = dataSet.Tables[0].Rows[0]["Name"].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}