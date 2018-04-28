using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace LoggingExceptions
{
    public class Global : System.Web.HttpApplication
    {
        //if the exceptions are not handled in the code or not handled in the page level events then it comes to application level events. 
        protected void Application_Start(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
            if(ex != null)
            {
                Logger.Log(ex);
                Server.ClearError();
                Server.Transfer("~/Errors.aspx");
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}