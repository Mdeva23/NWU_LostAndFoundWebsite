using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace NWU_LostAndFoundWebsite
{
    public partial class ClaimItem : System.Web.UI.Page
    {
        public string conString = @"";
        public string conStringReader = @"";
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                connection = new SqlConnection(conStringReader);
                connection.Open();




                connection.Close();
            }
            catch(Exception ex)
            {
                // change to proper exeptional handling for user once the interface is done
                Console.WriteLine(ex.Message);
            }

        }

       

        

        protected void btnAddToDatabase_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text.Trim();
            string time = txtTime.Text.Trim();
            string date = txtDate.Text.Trim();


            try
            {
                connection = new SqlConnection(conString);
                connection.Open();






                connection.Close();
            }catch (Exception ex)
            {
                // change to proper exeptional handling for user once the interface is done
                Console.WriteLine(ex.Message);
            }
         


        }

       
    }
}