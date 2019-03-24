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
            try
            {
                //Catch any errors

                bool flag = false;
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["RegistrationConnectionString"].ConnectionString);
                con.Open();                                                                             //whenever you open the database, remeber to close the database
                string insertQuery = "insert into UserData (FirstName, LastName,Email,Password,Country) values (@firstname, @lastname, @email, @password, @country)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@firstname", TextBoxFN.Text); //execute the query
                cmd.Parameters.AddWithValue("@lastname", TextBoxLN.Text);
                cmd.Parameters.AddWithValue("@email", TextBoxEM.Text);
                cmd.Parameters.AddWithValue("@password", TextBoxPW.Text);
                cmd.Parameters.AddWithValue("@country", DropDownListCountry.SelectedItem.ToString());

                cmd.CommandText = "select * from UserData";
                cmd.Connection = con;

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    if (rd[3].ToString() == TextBoxEM.Text)
                        flag = true;
                        break;
                }
                rd.Close();

                if(flag == true)
                {
                    Response.Write("Email already exists");
                }
                cmd.ExecuteNonQuery();
                Response.Redirect("Manager.aspx");
                Response.Write("Registration is succesful! ");

                con.Close();
            }
            catch(Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
            
            }

 
    }
}