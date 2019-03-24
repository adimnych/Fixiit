using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Fix_IIT
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            con.Open();                                                                             //whenever you open the database, remeber to close the database
            string checkuser = "select count(*) from UserData where Email='" + TextBoxEmail.Text + "'"; //query language writing for the database
            SqlCommand com = new SqlCommand(checkuser, con);                                         //Here you can add to make sure users dont have the same email address's     
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());





            con.Close();   //important to close the page so it takes you to the next one. 
            if (temp >= 1)
            {
                con.Open();
                string checkPasswordQuery = "select password from UserData where Password='" + TextBoxPassword.Text + "'";
                SqlCommand pass = new SqlCommand(checkPasswordQuery, con);
                string password = pass.ExecuteScalar().ToString().Replace(" ",""); // if there is spaces in the password, take them out
                if (password == TextBoxPassword.Text)
                {
                    Session["New"] = TextBoxEmail.Text;
                    Response.Write("Password is good"); // we know password is correct
                    Response.Redirect("WelcomePage.aspx"); // if password is good, redirect them to this page. 
                }
                else
                {
                    Response.Write("Password is bad"); // BAD PASSWORD
                }
            }
            else
            {
                Response.Write("Email is not correct");
            }
        }
    }
}