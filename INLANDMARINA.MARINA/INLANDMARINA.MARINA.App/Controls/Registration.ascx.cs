using INLANDMARINA.MARINA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INLANDMARINA.MARINA.App.Controls
{
    public partial class Registration : System.Web.UI.UserControl
    {
        public bool IsUpdate { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                // get student id out of session
                if(Session["CustomerID"] != null && uxFirstName.Text == string.Empty)
                {

                    var id = Convert.ToInt32(Session["CustomerID"]);
                    // get the Authentication object from the manager

                    var auth = AuthenticationManager.Find(id);

                    if(auth != null)
                    {
                        uxFirstName.Text = auth.FirstName;
                        uxLastName.Text = auth.LastName;
                        uxCity.Text = auth.City;
                        uxPhone.Text = auth.Phone;
                        uxUsername.Text = auth.FirstName;
                        uxPassword.Text = auth.LastName;
                    }
                }
            }
        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            if (IsUpdate)
            {
                // to update the record and get customer id out of session
                if(Session["CustomerID"] != null && uxFirstName.Text == string.Empty)
                {
                    var id = Convert.ToInt32(Session["CustomerID"]);
                    // to get the Authentication object from the manager

                    var auth = AuthenticationManager.Find(id);

                    auth.FirstName = uxFirstName.Text;
                    auth.LastName = uxLastName.Text;
                    auth.City = uxCity.Text;
                    auth.Phone = uxPhone.Text;
                    auth.FirstName = uxUsername.Text;
                    auth.LastName = uxPassword.Text;

                    // pass auth to the manager for updating

                    AuthenticationManager.Update(auth);

                    // remove from the auth ticket, clear session and redirect

                    FormsAuthentication.SignOut();
                    Session.Clear();
                    Response.Redirect("~/Login");
                }

            }
            else
            {
                // to insert the record
                var auth = new Customer
                {
                    FirstName = uxUsername.Text,
                    LastName = uxPassword.Text,
                    City = uxCity.Text,
                    Phone = uxPhone.Text,

                };

                //pass the auth object to the manager for inserting
                AuthenticationManager.Add(auth);

                Response.Redirect("~/Login");
            }
        }
    }
}