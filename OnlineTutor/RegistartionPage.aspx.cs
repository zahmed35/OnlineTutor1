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
    public partial class RegistartionPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=zia;Initial Catalog=OnlineTutor;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into LoginUser values('" + UserId.Text + "','" + Pswd1.Text + "','" + UserType.SelectedValue + "','" + FirstName.Text + "','" + LastName.Text + "','" + Email.Text + "','" + PhoneNo.Text + "')";
            cmd.ExecuteNonQuery();




            int i = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}