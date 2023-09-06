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
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\David\Dropbox\PC\Desktop\CMPG223\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\NWU_LostAndFoundWebsite\App_Data\LostAndFound.mdf;Integrated Security=True";
        SqlCommand command;
        SqlConnection con;
        //SqlDataAdapter adapter;
        //SqlDataReader dataReader;

        public void loadAll()
        {
            try
            {
                using(con = new SqlConnection(conString))
                {
                    con.Open();
                    command = new SqlCommand("SELECT * tblReports", con);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the GridView
                    GridViewReport.DataSource = dt;
                    GridViewReport.DataBind();

                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
            }
        }

        protected void btnFilterOrDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                using(con = new SqlConnection(conString))
                {
                    con.Open();

                }
            }
            catch(Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}