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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\David\Dropbox\PC\Desktop\CMPG223\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\App_Data\LostAndFound.mdf;Integrated Security=True");
            SqlDataAdapter adapt = new SqlDataAdapter("Select (*) from tblUsers where userName = '" + txtLoginEmail.Text + "' and userPassword = '" + txtLoginPassword.Text, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Response.Redirect("newsFeed.aspx");
            }
            else
            {
                lblEmailOrPassIncorrect.Text = "Email or password is incorrect please try again";
                string str = Request.Cookies["mycookie"].Value;
                Response.Write(str);
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateAccount.aspx");
        }
    }
}