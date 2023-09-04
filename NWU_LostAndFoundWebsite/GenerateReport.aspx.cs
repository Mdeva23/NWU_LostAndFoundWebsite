using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace NWU_LostAndFoundWebsite
{
    public partial class GenerateReport : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\David\Dropbox\PC\Desktop\CMPG223\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\App_Data\LostAndFound.mdf;Integrated Security=True";
        SqlCommand command;
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;

        protected void btnAdminUser_Click(object sender, EventArgs e)
        {
            try
            {
                using(con = new SqlConnection(conString))
                {
                    con.Open();
                    string query1 = "SELECT * FROM tblAdministrator WHERE administratorEmail = '"+txtAdminEmail.Text+"' ";

                    
                }
            }
            catch
            {

            }
        }
    }
}