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
    public partial class ReportItem : System.Web.UI.Page
    {

        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LostAndFound.mdf;Integrated Security=True";
        public SqlCommand command;
        public SqlConnection connect;
        public SqlDataAdapter adapter;
        public SqlDataReader dataReader;
        protected void Page_Load(object sender, EventArgs e)
        {

            DropDownListCategory.Items.Add("Cellphone");
            DropDownListCategory.Items.Add("Student Card");
            DropDownListCategory.Items.Add("Keys");
            DropDownListCategory.Items.Add("Peripherals");
            DropDownListCategory.Items.Add("Others");
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            
        }

        protected void DropDownListCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUploadPicture.HasFile)
                {

                    string str = FileUploadPicture.FileName;
                    FileUploadPicture.PostedFile.SaveAs(Server.MapPath("~/Upload/" + str));
                    string Image = "~/Upload/" + str.ToString();
                    string cartegory = DropDownListCategory.SelectedValue.Trim();
                    string Description = txtItemDescription.Text.Trim();

                    connect = new SqlConnection(conString);
                    connect.Open();

                    command = new SqlCommand("INSERT INTO tblItems(itemName, itemDescription, picture ) VALUES(@cartegory, @Description, @Image)", connect);   //INSERTING VALUES INTO THE TABLES
                    command.Parameters.AddWithValue("@cartegory", cartegory);
                    command.Parameters.AddWithValue("@Description", Description);
                    //command.Parameters.AddWithValue("@Image", Image);

                    SqlParameter imageParameter = new SqlParameter("@Image", SqlDbType.Image);
                    imageParameter.Value = DBNull.Value;
                    command.Parameters.Add(imageParameter);


                    command.ExecuteNonQuery();

                    connect.Close();

                    Label1.Text = "Item Uploaded";
                    Label1.ForeColor = System.Drawing.Color.ForestGreen;

                }

                else
                {
                    Label1.Text = "Please Upload your Image";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }


            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
                Label1.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}