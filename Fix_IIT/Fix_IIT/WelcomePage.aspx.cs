using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fix_IIT
{
    public partial class WelcomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }


            protected void ButtonLogout_Click(object sender, EventArgs e)
            {
                Session["New"] = null;
                Response.Redirect("Login.aspx");
            }
        }
    }
