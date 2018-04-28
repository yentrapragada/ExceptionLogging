using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateEventViewerLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEventViewer_Click(object sender, EventArgs e)
        {
            
                if (txtEventLogName.Text != string.Empty && txtEventLogSource.Text != string.Empty)
                {
                    if (!System.Diagnostics.EventLog.SourceExists(txtEventLogSource.Text))
                    {
                        System.Diagnostics.EventLog.CreateEventSource(txtEventLogName.Text, txtEventLogSource.Text);
                        MessageBox.Show("EventViewer Created");
                        txtEventLogName.Text = string.Empty;
                        txtEventLogSource.Text = string.Empty;
                    }
                    else
                    {
                    MessageBox.Show("Event Source already existed in Event Viewer");
                    }
                }
                else
                {
                    MessageBox.Show("EventViewer Not Created");
                }
            
        }
    }
}
