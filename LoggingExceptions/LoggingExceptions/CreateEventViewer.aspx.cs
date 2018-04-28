using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoggingExceptions
{
    public partial class CreateEventViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text!=string.Empty && txtSource.Text!=string.Empty)
            {
                System.Diagnostics.EventLog.CreateEventSource(txtName.Text, txtSource.Text);
                lblEventSuccess.Text = "Event Log Created";
                
            }
            else
            {
                lblEventSuccess.Text = "Please enter Name and Source";
            }
           
        }
    }
}