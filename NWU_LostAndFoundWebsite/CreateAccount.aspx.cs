using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace NWU_LostAndFoundWebsite
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\David\Dropbox\PC\Desktop\CMPG223\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\App_Data\LostAndFound.mdf;Integrated Security=True";
        SqlCommand command;
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlDataReader dataReader;


        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARING THE VARIABLES REQUIRED TO CREATE ACCOUNT
                String name = txtName.Text;
                String surname = txtSurname.Text;
                String email = txtEmail.Text;
                String contact = txtContact.Text;
                String password = txtPassword.Text;
                String reEnterPassword = txtReEnterPass.Text;

                if(password == reEnterPassword)    //CHECKING IF THE PASSWORDS MATCH
                {
                    using(con = new SqlConnection(conString))
                    {
                        con.Open();      //OPENING THE SQL CONNECTION
                        command = new SqlCommand("INSERT INTO tblUsers(userID, userName, userSurname, userEmail, userContact, userPassword) VALUES(@id, @name, @surname, @email, @contact, @pass)", con);   //INSERTING VALUES INTO THE TABLES
                        command.Parameters.AddWithValue("@id", "Value");
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@contact", contact);
                        command.Parameters.AddWithValue("@pass", password);
                        command.ExecuteNonQuery();

                        con.Close();      //CLOSING THE CONNECTION
                    }
                }
                else
                {
                    lblPassNotMatch.Text = "The passwords entered do not match. Please try again";  //MESSAGE TO MAKE USER AWARE OF DIFFERENT PASSWORDS
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}