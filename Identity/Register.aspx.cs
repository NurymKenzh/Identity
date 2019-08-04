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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            //attempt to register new user
            var user = new IdentityUser(){UserName = UserName.Text};
            //registration result
            IdentityResult result = manager.Create(user, Password.Text);

            //if the registration is success
            if(result.Succeeded)
            {
                StatusMessage.Text = string.Format("User {0} has been successfully registered!", user.UserName);

                //login new user
                var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);
                //go to "Login" page
                Response.Redirect("~/Login.aspx");
            }
            //if the registration is not success
            else
            {
                StatusMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}