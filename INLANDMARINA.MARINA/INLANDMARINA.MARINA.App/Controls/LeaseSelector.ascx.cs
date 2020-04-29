using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using INLANDMARINA.MARINA.Data;

namespace INLANDMARINA.MARINA.App.Controls
{
    public partial class LeaseSelector : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var mgr = new MarinaManager();
                uxDocks.DataSource = mgr.GetAllDocks();
                uxDocks.DataTextField = "Name";
                uxDocks.DataValueField = "ID";
                uxDocks.DataBind();
            }
        }
    }
}