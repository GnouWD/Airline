using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace FlaitBooking.Airline
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-H0R2B3V0\SQLEXPRESS;Initial Catalog=maybay;Integrated Security=True;"); SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void LinkButtonSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "INSERT INTO tblUsers (name, mobile, email, pass) VALUES (@name, @mobile, @email, @pass)";
                cmd = new SqlCommand(str, con);

                // Sử dụng tham số hoá
                cmd.Parameters.AddWithValue("@name", txt_user_name.Text);
                cmd.Parameters.AddWithValue("@mobile", txt_user_mobile.Text);
                cmd.Parameters.AddWithValue("@email", txt_user_email.Text);
                cmd.Parameters.AddWithValue("@pass", txt_pass.Text);

                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Registration Successful')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('An error occurred')</script>");
                Response.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

    }
}