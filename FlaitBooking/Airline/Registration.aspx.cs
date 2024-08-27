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
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-H0R2B3V0\SQLEXPRESS;Initial Catalog=F:\asp.net\FlaitBooking\FlaitBooking\App_Data\Airline.mdf;Integrated Security=True;");
        SqlCommand cmd;
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
                string str = "insert into tblUsers values('"+txt_user_name.Text+"',"+txt_user_mobile.Text+",'"+txt_user_email.Text+"','"+txt_pass.Text+")";
                cmd= new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Registration Successfull')</script>");


            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Registration Successfull')</script>");
                Response.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}