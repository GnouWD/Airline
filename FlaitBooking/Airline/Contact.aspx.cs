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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-H0R2B3V0\SQLEXPRESS;Initial Catalog=maybay;Integrated Security=True;");

        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "insert into tblContact values('"+txtName.Text+"','"+txtEmail.Text+"','"+txtSubject.Text+"','"+txtMessage.Text+"')";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                Response.Write("<script>alert('Feedback Send Successfully')</script>");
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
    }
}