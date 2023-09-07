using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace NWU_LostAndFoundWebsite
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            HttpCookie cookie = new HttpCookie("mycookie");
            cookie.Value = txtLoginPassword.Text;
            cookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(cookie);
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LostAndFound.mdf;Integrated Security=True"))
                {
                    con.Open();

                    // Use a parameterized query to avoid SQL injection
                    string query = "SELECT COUNT(*) FROM tblUsers WHERE userEmail = @userEmail";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userEmail", txtLoginEmail.Text);

                    int userCount = (int)cmd.ExecuteScalar();

                    if (userCount == 1)
                    {
                        // User found, you would typically check the password here
                        Response.Redirect("newsFeed.aspx");
                    }
                    else
                    {
                        lblEmailOrPassIncorrect.Text = "Email or password is incorrect. Please try again.";
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any database-related exceptions here
                lblEmailOrPassIncorrect.Text = "An error occurred while processing your request.";
                // Log the exception for debugging purposes, don't display the error message to users
                // You can use ex.ToString() to get the complete error message for logging.
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {

            Response.Redirect("CreateAccount.aspx");
        }
    }
}