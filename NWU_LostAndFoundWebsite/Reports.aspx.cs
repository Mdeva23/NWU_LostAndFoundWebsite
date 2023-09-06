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
        public int value;

        public void loadAll()
        {
            try
            {
                using (con = new SqlConnection(conString))
                {
                    con.Open();
                    command = new SqlCommand("SELECT * tblReports", con);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind the DataTable to the GridView
                    GridViewReport.DataSource = dt;
                    GridViewReport.DataBind();

                    con.Close();

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
                using (con = new SqlConnection(conString))
                {
                    con.Open();
                    if (value == 0)
                    {
                        loadAll();
                    }
                    else if (value == 1)
                    {
                        command = new SqlCommand("SELECT * tblItems", con);
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Bind the DataTable to the GridView
                        GridViewReport.DataSource = dt;
                        GridViewReport.DataBind();
                    }
                    else if (value == 3)
                    {
                        command = new SqlCommand("SELECT * tblUsers", con);
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Bind the DataTable to the GridView
                        GridViewReport.DataSource = dt;
                        GridViewReport.DataBind();
                    }
                    else
                    {
                        Console.WriteLine("Please select report type");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = RadioButtonList1.SelectedValue;

            switch (selectedValue)
            {
                case "VDR":
                    value = 0;
                    break;

                case "VRI":
                    value = 1;
                    break;

                case "VCI":
                    value = 2;
                    break;
            }
        }
    }
}