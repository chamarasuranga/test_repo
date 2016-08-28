using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        private TextBox t = new TextBox();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label l = new Label();

            if (!Page.IsPostBack)
            {
                l.Text = "enter name";
                PlaceHolder1.Controls.Add(l);
                t.Text = "Enter Name";
                PlaceHolder1.Controls.Add(t);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(t.Text);
        }
    }
}