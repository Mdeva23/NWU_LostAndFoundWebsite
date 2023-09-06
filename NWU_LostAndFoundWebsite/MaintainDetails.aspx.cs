using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace NWU_LostAndFoundWebsite
{
    public partial class MaintainDetails : System.Web.UI.Page
    {
        //declare public variables
        String connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LostAndFound.mdf;Integrated Security=True";
        SqlConnection cnn;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(connectionstring);
                cnn.Open();
                //this is to update the user details
                cmd = new SqlCommand("UPDATE tblUsers SET userEmail = '" + txtEmail.Text + "', 'userContact = '" + txtContact.Text + "', userPassword = '" + txtPassword.Text + "' WHERE userName = '" + txtName.Text + "' AND userSurname = '" + txtSurname.Text + "' ", cnn);
                adapter = new SqlDataAdapter();
                adapter.UpdateCommand = cmd;
                adapter.UpdateCommand.ExecuteNonQuery();


            }
            catch (SqlException error)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + error.Message + "');", true);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(connectionstring);
                cnn.Open();
                //Delete the account existing user
                cmd = new SqlCommand("DELETE FROM tblUsers WHERE userName = '" + txtName.Text + "'", cnn);
                adapter = new SqlDataAdapter();
                adapter.DeleteCommand = cmd;
                adapter.DeleteCommand.ExecuteNonQuery();


                cnn.Close();
            }
            catch (SqlException error)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + error.Message + "');", true);
            }

        }
        protected void btnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx"); //go to login page

        }

    }
}