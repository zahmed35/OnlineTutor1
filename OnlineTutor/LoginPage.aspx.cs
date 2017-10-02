using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTutor
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=zia;Integrated Security=True;Initial Catalog=OnlineTutor");

            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[LoginUser] where [userid]=@username and [userpwd]=@password and [usertype]=@usertype", con);
            cmd.Parameters.AddWithValue("@username", TextBox1.Text);
            cmd.Parameters.AddWithValue("password", TextBox2.Text);
            cmd.Parameters.AddWithValue("usertype", DropDownList1.SelectedValue);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {
                if (DropDownList1.SelectedValue == "1")
                    Response.Redirect("Admin.aspx");
                else if (DropDownList1.SelectedValue == "2")
                    Response.Redirect("Tutor.aspx");
                else if (DropDownList1.SelectedValue == "3")
                    Response.Redirect("Student.aspx");
            }

            else
            {
                Label1.Text = "You're username and password is incorrect";
                Label1.ForeColor = System.Drawing.Color.Red;

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistartionPage.aspx");
        }
    }
}