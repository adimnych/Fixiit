using System;
using System.Data;
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
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_login_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                con.Open();
                string userInvalid = "You have already registered, click click to login.";

                string checkUser = "SELECT count(*) FROM UserData where Email = TextBoxEmail.Text AND Password = TextBoxPassword.Text";
                SqlCommand com = new SqlCommand(checkUser, con);          //connect to the database                             
                com.Parameters.AddWithValue("@email", TextBoxEmail.Text);
                com.Parameters.AddWithValue("@password", TextBoxPassword.Text);

                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    outputlabel.Text = userInvalid;
                    reader.Close();
                }

                else
                {
                    try
                    {
                        con.Open();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        string checkLoginQuery = "Insert into  UserData(FirstName, LastName, Email, Password, Country) Values (@firstname, @lastname, @email, @password, @country) ";
                        SqlCommand cmd = new SqlCommand(checkLoginQuery, con);

                        con.Open();

                        //cmd.Parameters.AddWithValue("@firstname", TextBoxFN.Text); //execute the query
                        //cmd.Parameters.AddWithValue("@lastname", TextBoxLN.Text);
                        cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text);
                        cmd.Parameters.AddWithValue("@password", TextBoxPassword.Text);
                        //cmd.Parameters.AddWithValue("@country", DropDownListCountry.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        con.Close();

                        Response.Redirect("Manager.aspx");
                        Response.Write("Registration is succesful! ");

                    }
                    finally
                    {
                        con.Close();



                    }

                }
            }
        }

    }
}

//                con.Close();   //important to close the page so it takes you to the next one. 
//                if (temp >= 1)
//                {
//                    con.Open();
//                    string checkPasswordQuery = "select password from UserData where Password='" + TextBoxPassword.Text + "'";
//                    SqlCommand pass = new SqlCommand(checkPasswordQuery, con);
//                    string password = pass.ExecuteScalar().ToString().Replace(" ", ""); // if there is spaces in the password, take them out
//                    if (password == TextBoxPassword.Text)
//                    {
//                        Session["New"] = TextBoxEmail.Text;
//                        Response.Write("Password is good"); // we know password is correct
//                        Response.Redirect("WelcomePage.aspx"); // if password is good, redirect them to this page. 
//                    }
//                    else
//                    {
//                        Response.Write("Password is bad"); // BAD PASSWORD
//                    }
//                }
//                else
//                {
//                    Response.Write("Email is not correct");
//                }
//            }
//        }
//    }
//}