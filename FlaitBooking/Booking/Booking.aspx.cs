using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace FlaitBooking.Booking
{
    public partial class Booking : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-H0R2B3V0\SQLEXPRESS;Initial Catalog=maybay;Integrated Security=True;"); SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "insert into tblBooking values('"+txtDepartureCity.Text+"','"+txtDestinationCity.Text+"','"+txtDate.Text+"','"+txtDateReturn.Text+"','"+DropDownList1.SelectedValue.ToString()+"')";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Confirm Booking Successfully')</script>");
            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnSubmit3_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Confirm Booking Successfully')</script>");
        }

        protected void btnSubmit2_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Confirm Booking Successfully')</script>");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Airline/Home.aspx");
        }
    }
}