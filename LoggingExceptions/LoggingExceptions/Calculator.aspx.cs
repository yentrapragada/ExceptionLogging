using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoggingExceptions
{
    public partial class Calculator : System.Web.UI.Page
    {
        public int result;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            clearLblError();
            add();
            clearTextBoxes();
        }
        protected void btnSubstract_Click(object sender, EventArgs e)
        {
            clearLblError();
            substract();
            clearTextBoxes();
        }
        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            clearLblError();
            multiply();
            clearTextBoxes();
        }
        protected void btnDivide_Click(object sender, EventArgs e)
        {
            clearLblError();
            divide();
            clearTextBoxes();
        }
        protected void add()
        {
            if (!(txtFirst.Text == "") && !(txtSecond.Text == ""))
            {
                try
                {
                    int first = Convert.ToInt32(txtFirst.Text);
                    int second = Convert.ToInt32(txtSecond.Text);
                    result = first + second;
                    lblAdd.Text = result.ToString();
                }
                catch (FormatException formatException)
                {
                    //if any exception occurs then pass that exception object to the logger.log method to store the exceptions in Event Viewer
                    Logger.Log(formatException);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Only Numbers are allowed";
                }
                catch (OverflowException overflowException)
                {
                    Logger.Log(overflowException);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Numbers must be between " + Int32.MinValue.ToString() + " and " + Int32.MaxValue.ToString();
                }                
                catch (Exception exception)
                {
                    Logger.Log(exception);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Denominator cannot be ZERO";
                }

            }
            else
            {
                lblError.Text = "Please Enter values";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void substract()
        {
            if (!(txtFirst.Text == "") && !(txtSecond.Text == ""))
            {
                try
                {
                    int first = Convert.ToInt32(txtFirst.Text);
                    int second = Convert.ToInt32(txtSecond.Text);
                    result = first - second;
                    lblAdd.Text = result.ToString();
                }
                catch (FormatException formatException)
                {
                    Logger.Log(formatException);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Only Numbers are allowed";
                }
                catch (OverflowException overflowException)
                {
                    Logger.Log(overflowException);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Numbers must be between " + Int32.MinValue.ToString() + " and " + Int32.MaxValue.ToString();
                }                
                catch (Exception exception)
                {
                    Logger.Log(exception);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Denominator cannot be ZERO";
                }

            }
            else
            {
                lblError.Text = "Please Enter values";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void multiply()
        {
            if (!(txtFirst.Text == "") && !(txtSecond.Text == ""))
            {
                try
                {
                    int first = Convert.ToInt32(txtFirst.Text);
                    int second = Convert.ToInt32(txtSecond.Text);
                    result = first * second;
                    lblAdd.Text = result.ToString();
                }
                catch (FormatException formatException)
                {
                    Logger.Log(formatException);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Only Numbers are allowed";
                }
                catch (OverflowException overflowException)
                {
                    Logger.Log(overflowException);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Numbers must be between " + Int32.MinValue.ToString() + " and " + Int32.MaxValue.ToString();
                }
                
                catch (Exception exception)
                {
                    Logger.Log(exception);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Denominator cannot be ZERO";
                }

            }
            else
            {
                lblError.Text = "Please Enter values";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }
        protected void divide()
        {
            if (!(txtFirst.Text == "") && !(txtSecond.Text == ""))
            {
                try
                {
                    int first = Convert.ToInt32(txtFirst.Text);
                    int second = Convert.ToInt32(txtSecond.Text);
                    result = first / second;
                    lblAdd.Text = result.ToString();
                }
                catch(FormatException formatException)
                {
                    Logger.Log(formatException);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Only Numbers are allowed";
                }
                catch(OverflowException overflowException)
                {
                    Logger.Log(overflowException);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Numbers must be between "+Int32.MinValue.ToString()+" and "+Int32.MaxValue.ToString();
                }
                catch(DivideByZeroException dividebyzeroException)
                {
                    Logger.Log(dividebyzeroException);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Denominator cannot be ZERO";
                }
                catch(Exception exception)
                {
                    Logger.Log(exception);
                    Server.ClearError();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Denominator cannot be ZERO";
                }
                
            }
            else
            {
                lblError.Text = "Please Enter values";
                lblError.ForeColor = System.Drawing.Color.Red;
            }
        }
        public void clearTextBoxes()
        {
            txtFirst.Text = string.Empty;
            txtSecond.Text = string.Empty;
        }
        public void clearLblError()
        {
            lblError.Text = string.Empty;
        }        
    }
}