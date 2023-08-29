using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Assignment_10
{
    public partial class Product_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblTxt.Visible = false;
            }
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            LblTxt.Visible = true;
            LblTxt.Text = "Product successfully Registered!!";
            LblTxt.Text += "Product Name: " + TxtName.Text;
            LblTxt.Text += "Category: " + DropCat.Text;
            LblTxt.Text += "Price: " + TxtPrice.Text;
            LblTxt.Text += "Release Date: " + TxtCad.SelectedDate;


        }
    }
}