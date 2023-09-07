using System;
using System.Web.UI;
using System.Data.SqlClient;

namespace NWU_LostAndFoundWebsite
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        // Define your SqlConnection and SqlCommand as class members
        private string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\David\Dropbox\PC\Desktop\CMPG223\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\App_Data\LostAndFound.mdf;Integrated Security=True";
        private SqlConnection con;
        private SqlCommand command;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Add any necessary code for Page_Load if needed
        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string email = txtEmail.Text;
                string contact = txtContact.Text;
                string password = txtPassword.Text;
                string reEnterPassword = txtReEnterPass.Text;

                if (password == reEnterPassword)
                {
                    using (con = new SqlConnection(conString))
                    {
                        con.Open();
                        // Use parameterized query to prevent SQL injection
                        //string insertQuery = "INSERT INTO tblUsers(userName, userSurname, userEmail, userContact, userPassword) VALUES(@name, @surname, @email, @contact, @pass)";
                        string insertQuery = "INSERT INTO tblUsers(userName, userSurname, userEmail, userContact) VALUES(@name, @surname, @email, @contact)";
                        command = new SqlCommand(insertQuery, con);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@contact", contact);
                        //command.Parameters.AddWithValue("@pass", password);
                        command.ExecuteNonQuery();

                        // Use Response.Write to display messages on the web page
                        Response.Write("Successfully created an account");

                        con.Close();
                    }
                    // Redirect after successful account creation
                    Response.Redirect("LoginPage.aspx");
                }
                else
                {
                    lblPassNotMatch.Text = "The passwords entered do not match. Please try again";
                }
            }
            catch (Exception ex)
            {
                // Use Response.Write to display error messages on the web page
                Response.Write("An error occurred: " + ex.Message);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}
