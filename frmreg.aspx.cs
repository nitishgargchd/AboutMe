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
        nsaboutme.clsregprp objprp = new nsaboutme.clsregprp();
        objprp.p_regnam = txtnam.Text;
        objprp.p_regeml = txteml.Text;
        objprp.p_regpas = txtpwd.Text;
        objprp.p_regsts = 'U';
        try
        {
            obj.Save_Rec(objprp);
            txtnam.Text = String.Empty;
            txteml.Text = String.Empty;
            Label1.Text = "Registration Successful";
        }
        catch (Exception exp)
        {
            Label1.Text = "Email ID already registered";
        }
    }
}


