using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using INLANDMARINA.MARINA.Data;

namespace INLANDMARINA.MARINA.App
{
    public partial class SiteMaster : MasterPage
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //check if Context.User.Identity.IsAuthenticated (set innerhtml of uxLogin and uxWelcome)

            if (Context.User.Identity.IsAuthenticated)
            {
                uxWelcome.InnerText = $"Welcome {Context.User.Identity.Name}";
                uxLogin.InnerHtml = "<span class='fa fa-sign-out-alt'>";
            }
            else
            {
                uxLogin.InnerHtml = "<span class='fa fa-sign-out-alt'>";
                uxWelcome.InnerHtml = string.Empty;
            }
        }

        protected void HandleLoginClick(Object sender, EventArgs e)
        { 
            // this is to check if Context.User.Identity.IsAuthenticated (signout the user)
            if (Context.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.SignOut();
                Session.Clear();
                Response.Redirect("~/");
            }
            else
            {
                Response.Redirect("/Login");
            }
        }

    }

   


}