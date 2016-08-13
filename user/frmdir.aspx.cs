using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        nsaboutme.clsprf obj = new nsaboutme.clsprf();
        DataList1.DataSource = obj.srcprf(TextBox1.Text + "%", Convert.ToInt32(Session["cod"]));
        DataList1.DataBind();
    }
}