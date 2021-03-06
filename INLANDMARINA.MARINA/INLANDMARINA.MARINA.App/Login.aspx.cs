﻿using INLANDMARINA.MARINA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INLANDMARINA.MARINA.App
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UxAuthenticate_Click(object sender, EventArgs e)
        {
            // pass the credentials to the authenticationmanager
            var customer = AuthenticationManager.Authenticate(uxFirstname.Text, uxLastName.Text);

            // add the customer Id ito session

            Session.Add("CustomerID", customer.ID);

            //redirect
            FormsAuthentication.RedirectFromLoginPage(customer.FullName, false);
        }
    }
}