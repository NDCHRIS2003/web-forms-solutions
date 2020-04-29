using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INLANDMARINA.MARINA.App.Secure
{
    public partial class UpdateRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Registration.IsUpdate = true;
        }
    }
}