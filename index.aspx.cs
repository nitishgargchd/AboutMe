using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        nsaboutme.clsreg obj = new nsaboutme.clsreg();
        char usrrol;
        Int32 a;
        a = obj.logincheck(txteml.Text, txtpwd.Text, out usrrol);
        if (a == -1)
            Label1.Text = "Email or Password is incorrect";
        else
        {
            Session["cod"] = a;
            if (usrrol == 'A')
                Response.Redirect("admin/frmser.aspx");
            else
                Response.Redirect("user/frmdshbrd.aspx");
        }
    }
}


