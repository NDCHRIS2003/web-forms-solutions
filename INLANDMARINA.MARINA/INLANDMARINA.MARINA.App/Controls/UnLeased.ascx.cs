using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using INLANDMARINA.MARINA.Data;

namespace INLANDMARINA.MARINA.App.Controls
{
    public partial class UnLeased : System.Web.UI.UserControl
    {
        // to declare event we invoke our slip selector method
        public event SlipSelectorHandler SlipSelect;

        // slip pfroperty to someone can sign up for it

        public Slip Slip { get; set; }

        // Boolean property to set AutoPostBack

        public bool AllowPosBack { get { return UxLeases.AutoPostBack; } set { UxLeases.AutoPostBack = value; } }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                var mgr = new MarinaManager();
                UxLeases.DataSource = mgr.GetUnleasedSlip();                
                UxLeases.DataValueField = "dkId";
                UxLeases.DataBind();
                //UxLeases.SelectedIndex = 0;
                //UxLeases_SelectedIndexChanged(this, e);


            }
        }

        protected void UxLeases_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this is what invokes the event on selection when slip is selected

            if (SlipSelect != null)
            {
                // the the selected DockID and cast it to an intiger
                var dkId = Convert.ToInt32(UxLeases.SelectedValue);

                // call the manager class to get the slip object
                Slip slp = MarinaManager.Find(dkId);
                // instantiate the SlipsEventArgs class
                var arg = new SlipsEventArgs
                {
                    ID     = slp.ID.ToString(),
                    Width  = slp.Width.ToString(),
                    Length = slp.Length.ToString(),
                    DockID = slp.DockID.ToString(),
                };

                // invoke the event and pass the param values
                SlipSelect.Invoke(this, arg);
            }
        }
    }
}