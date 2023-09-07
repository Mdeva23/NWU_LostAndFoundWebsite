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
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\David\Dropbox\PC\Desktop\CMPG223\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\App_Data\LostAndFound.mdf;Integrated Security=True"))
                {
                    con.Open();

                    // Use a parameterized query to avoid SQL injection
                    string query = "SELECT * FROM tblAdministrator WHERE administratorEmail = @adminEmail";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@adminEmail", txtAdminEmail.Text);

                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);

                    if (dt.Rows.Count == 1)
                    {
                        // Administrator found, you would typically check the password here
                        // Create a cookie that lasts for 1 minute
                        HttpCookie adminCookie = new HttpCookie("AdminCookie");
                        adminCookie.Value = "AdminLoggedIn"; // Set a value to indicate admin login
                        adminCookie.Expires = DateTime.Now.AddMinutes(1); // Set the expiration time

                        Response.Cookies.Add(adminCookie);

                        Response.Redirect("Reports.aspx");
                    }
                    else
                    {
                        lblincorrectEmail.Text = "Incorrect email or password";
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any database-related exceptions here
                lblincorrectEmail.Text = ex.Message;
            }
        }

    
    }
}