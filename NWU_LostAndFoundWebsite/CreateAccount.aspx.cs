using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWU_LostAndFoundWebsite
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String surname = txtSurname.Text;
            String email = txtEmail.Text;
            String contact = txtContact.Text;
            String password = txtPassword.Text;
            String reEnterPassword = txtReEnterPass.Text;

            if(password == reEnterPassword)
            {
                lblPassNotMatch.Text = "The passwords entered do not match. Please re enter the passowrd";
            }
            else
            {

            }
        }
    }
}