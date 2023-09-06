using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace NWU_LostAndFoundWebsite
{
    public partial class GenerateReport : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
       

        protected void btnAdminUser_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\David\Dropbox\PC\Desktop\CMPG223\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\App_Data\LostAndFound.mdf;Integrated Security=True");
            SqlDataAdapter adapt = new SqlDataAdapter("Select (*) from tblAdministrator where administratorEmail = '" + txtAdminEmail.Text, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (dt.Rows[0].ToString() == "1")
            {
                Response.Redirect("Reports.aspx");
            }
            else
            {
                lblincorrectEmail.Text = "incorrect email or password";
                
            }
        }

    
    }
}