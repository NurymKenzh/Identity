using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace Identity
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //if user is authenticated
                if(User.Identity.IsAuthenticated)
                {
                    StatusText.Text = string.Format("Hello, {0}", User.Identity.GetUserName());
                    LoginStatus.Visible = true;
                    LogoutButton.Visible = true;
                }
                //if user not authenticated
                else
                {
                    //show him LoginForm
                    LoginForm.Visible = true;
                }
            }
        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);
            //search user
            var user = userManager.Find(UserName.Text, Password.Text);

            //if user exist
            if(user != null)
            {
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                //sign in
                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false}, userIdentity);
                Response.Redirect("~/Login.aspx");
            }
            //if user not exist
            else
            {
                StatusText.Text = "Invalid login or password";
                LoginStatus.Visible = true;
            }
        }

        protected void SignOut_Click(object sender, EventArgs e)
        {
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            Response.Redirect("~/Login.aspx");
        }
    }
}