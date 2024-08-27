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
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-H0R2B3V0\SQLEXPRESS;Initial Catalog=F:\asp.net\FlaitBooking\FlaitBooking\App_Data\Airline.mdf;Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtUsername1.Text == "jayesh" && txtPassword1.Text == "123456")
            {
                //Response.Write("<script>alert('check username or password')</script>");
                Response.Redirect("~/Booking/Booking.aspx");
            }
            else
            {

            }

            //try
            //{

            //    string str1 = "select * from tbtUsers where email='" + txtUsername1.Text + "' and pass='" + txtPassword1.Text + "'";
            //    da = new SqlDataAdapter(str1, con);
            //    da.Fill(dt);

            //    if (dt.Rows.Count > 0)
            //    {
            //        Response.Redirect("~/Booking/Booking.aspx");
            //    }


            //}
            //catch (Exception ex)
            //{

            //}
            //finally
            //{
            //    con.Close();
            //}
        }

        protected void LinkButtonSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
    }
}