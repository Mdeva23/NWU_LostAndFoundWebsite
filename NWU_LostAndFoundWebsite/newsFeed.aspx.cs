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
    public partial class newsFeed : System.Web.UI.Page
    {
        //declare public variables
        String connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LostAndFound.mdf;Integrated Security=True";
        SqlConnection cnn;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            //when page loads
            

                try
                {
                    cnn = new SqlConnection(connectionstring);
                    cnn.Open(); //open connection
                    
                // fill in the list
                cmd = new SqlCommand("SELECT itemName, itemDescription FROM tblItems ", cnn); 
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListBoxItems.Items.Add(reader.GetString(0) + "\t" + reader.GetString(1)); //get item name and description
                    
                }


                cnn.Close();
                }
                catch (SqlException error)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + error.Message + "');", true);
                }


            
        
    }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //this button is to search according to item
            try
            {
                cnn = new SqlConnection(connectionstring);
                cnn.Open();
                //filter according to name of item
                cmd = new SqlCommand("SELECT itemName, itemDescription FROM tblItems WHERE itemName LIKE '%" + txtSearchForItem.Text + "%'", cnn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListBoxItems.Items.Add(reader.GetString(0) + "\t" + reader.GetString(1)); //get item name and description

                }
                cnn.Close();
            }
            catch (SqlException error)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + error.Message + "');", true);
            }

        }

        protected void btnReportItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReportItem.aspx"); //view the report item page
        }

        protected void btnClaim_Click(object sender, EventArgs e)
        {
            Response.Redirect("ClaimItem.aspx"); //view the claim item page
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx"); //view the login page
        }
    }
}