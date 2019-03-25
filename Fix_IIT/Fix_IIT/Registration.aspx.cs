using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //Provide all the classes of the SQL
using System.Configuration;


namespace Fix_IIT
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            //{
            //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
            //    con.Open();                                                                             //whenever you open the database, remeber to close the database
            //    string checkuser = "select count(*) from UserData where Email='"+ TextBoxEM.Text +"'"; //query language writing for the database
            //    SqlCommand com = new SqlCommand(checkuser, con);                                         //Here you can add to make sure users dont have the same email address's     
            //    int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            //    if (temp == 1)
            //    {
            //        Response.Write("User with this email already exists");
            //    }

            //    con.Close();
            //}
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                con.Open();
                string userInvalid = "You have already registered, please click to login.";
                string checkuser = "select count(*) from UserData where Email='" + TextBoxEM.Text + "'"; //query language writing for the database
                SqlCommand command = new SqlCommand(checkuser, con);
                command.Parameters.AddWithValue("@email", TextBoxEM.Text);
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();



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
                    catch
                    {
                        con.Close();
                        string insertQuery = "insert into UserData (FirstName, LastName,Email,Password,Country) values (@firstname, @lastname, @email, @password, @country)";
                        SqlCommand cmd = new SqlCommand(insertQuery, con); //Insert command

                        con.Open();
                        cmd.Parameters.AddWithValue("@firstname", TextBoxFN.Text); //execute the query
                        cmd.Parameters.AddWithValue("@lastname", TextBoxLN.Text);
                        cmd.Parameters.AddWithValue("@email", TextBoxEM.Text);
                        cmd.Parameters.AddWithValue("@password", TextBoxPW.Text);
                        cmd.Parameters.AddWithValue("@country", DropDownListCountry.SelectedItem.ToString());

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

        protected void TextBoxEM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

