using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Default : System.Web.UI.Page
{
    public String geturl(Int32 sitcod)
    {
        String s = "";
        nsaboutme.clssit obj = new nsaboutme.clssit();
        List<nsaboutme.clssitprp> k = obj.Find_Rec(sitcod);
        nsaboutme.clsser obj1 = new nsaboutme.clsser();
        List<nsaboutme.clserprp> k1 = obj1.Find_Rec(k[0].p_sitsercod);
        s = k1[0].p_serbasurl + k[0].p_siturl;
        return s;
    }
    public String getimg(Int32 sercod)
    {
        nsaboutme.clsser obj = new nsaboutme.clsser();
        List<nsaboutme.clserprp> k = obj.Find_Rec(sercod);
        return "../serpics/" + sercod.ToString() + k[0].p_serpic;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            nsaboutme.clsprf obj = new nsaboutme.clsprf();
            List<nsaboutme.clsprfprp> k = obj.Disp_Rec(Convert.ToInt32(Request.QueryString["rcod"]));
            if (k.Count == 0)
                Response.Redirect("frmprf.aspx");
            else
            {
                im1.ImageUrl = "~/prfpics/" + Request.QueryString["rcod"] + k[0].p_prfbckpic;
                Lblnam.Text = k[0].p_prffstnam + " " + k[0].p_prflstnam;
                lblhedline.Text = k[0].p_prfhedlin;
                if (k[0].p_prfpic == "")
                    im2.Visible = false;
                else
                    im2.ImageUrl = "~/prfpics/" + Request.QueryString["rcod"] + k[0].p_prfpic;
                Literal1.Text = k[0].p_prfbio;
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        nsaboutme.clsfavprf obj = new nsaboutme.clsfavprf();
        nsaboutme.clsfavprfprp objprp = new nsaboutme.clsfavprfprp();
        objprp.p_favprfprfcod = Convert.ToInt32(Request.QueryString["rcod"]);
        objprp.p_favprfregcod = Convert.ToInt32(Session["cod"]);
        obj.Save_Rec(objprp);
    }
}