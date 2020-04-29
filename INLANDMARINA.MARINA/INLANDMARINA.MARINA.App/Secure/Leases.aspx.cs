using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INLANDMARINA.MARINA.App
{
    public partial class Leases : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnLeased.SlipSelect += UnLeased_SlipSelect;
            
        }

        private void UnLeased_SlipSelect(object sender, Controls.SlipsEventArgs e)
        {
            uxId.Text     = e.ID;
            uxWidth.Text  = e.Width;
            uxLength.Text = e.Length;
            uxDockID.Text = e.DockID;
        }
    }
}