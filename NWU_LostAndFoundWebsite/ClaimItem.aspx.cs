using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml.Linq;


namespace NWU_LostAndFoundWebsite
{
    public partial class ClaimItem : System.Web.UI.Page
    {
        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\David\Dropbox\PC\Desktop\CMPG223\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\App_Data\LostAndFound.mdf;Integrated Security=True";
       
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                connection = new SqlConnection(conString);
                connection.Open();

                command = new SqlCommand("SELECT * FROM ", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListBoxClaimedItem.Items.Add(reader.GetValue(0).ToString());
                }
                

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

                //To be confirmed with the database
                command = new SqlCommand("INSERT INTO () VALUES()", connection);
                command.Parameters.AddWithValue();
                command.Parameters.AddWithValue();
                


                command.ExecuteNonQuery();
                connection.Close();
            }catch (Exception ex)
            {
                // change to proper exeptional handling for user once the interface is done
                Console.WriteLine(ex.Message);
            }
         


        }

       
    }
}