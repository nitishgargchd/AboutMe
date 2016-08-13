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
        if (Page.IsPostBack == false)
        {
            nsaboutme.clsprf obj = new nsaboutme.clsprf();
            List<nsaboutme.clsprfprp> k = obj.Disp_Rec(Convert.ToInt32(Session["cod"]));
            if (k.Count > 0)
            {
                TextBox1.Text = k[0].p_prffstnam;
                TextBox2.Text = k[0].p_prflstnam;
                TextBox3.Text = k[0].p_prfhedlin;
                Editor1.Content = k[0].p_prfbio;
                if (k[0].p_prfalleml == 'T')
                    CheckBox1.Checked = true;
                else
                    CheckBox1.Checked = false;
                ViewState["bckpic"] = k[0].p_prfbckpic;
                ViewState["prfpic"] = k[0].p_prfpic;
                ViewState["cod"] = k[0].p_prfcod;
                Button1.Text = "Update";
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        nsaboutme.clsprf obj = new nsaboutme.clsprf();
        nsaboutme.clsprfprp objprp = new nsaboutme.clsprfprp();
        objprp.p_prffstnam = TextBox1.Text;
        objprp.p_prflstnam = TextBox2.Text;
        objprp.p_prfhedlin = TextBox3.Text;
        objprp.p_prfbio = Editor1.Content;
        objprp.p_prfregcod = Convert.ToInt32(Session["cod"]);
        if (CheckBox1.Checked == true)
            objprp.p_prfalleml = 'T';
        else
            objprp.p_prfalleml = 'F';
        String s = FileUpload1.FileName;
        String s1 = FileUpload2.FileName;
        if (s != "")
            s ="B"+ s.Substring(s.LastIndexOf('.'));
        if (s1 != "")
            s1 = "P" + s1.Substring(s1.LastIndexOf('.'));
        if (Button1.Text == "Submit")
        {
            objprp.p_prfbckpic = s;
            objprp.p_prfpic = s1;
            obj.Save_Rec(objprp);
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../prfpics") + "//" + Session["cod"] + s);
            FileUpload2.PostedFile.SaveAs(Server.MapPath("../prfpics") + "//" + Session["cod"] + s1);
        }
        else
        {
            objprp.p_prfcod = Convert.ToInt32(ViewState["cod"]);
            if (s != "")
            {
                objprp.p_prfbckpic = s;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("../prfpics") + "//" + Session["cod"] + s);
            }
            else
                objprp.p_prfbckpic = ViewState["bckpic"].ToString();
            if (s1 != "")
            {
                objprp.p_prfpic = s;
                FileUpload2.PostedFile.SaveAs(Server.MapPath("../prfpics") + "//" + Session["cod"] + s1);
            }
            else
                objprp.p_prfpic = ViewState["prfpic"].ToString();
            obj.Update_Rec(objprp);
        }
        Response.Redirect("frmdshbrd.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        nsaboutme.clsser obj = new nsaboutme.clsser();
        List<nsaboutme.clserprp> k = obj.Find_Rec(Convert.ToInt32(DropDownList1.SelectedValue));
        Label1.Text = k[0].p_serbasurl;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        nsaboutme.clssit obj = new nsaboutme.clssit();
        nsaboutme.clssitprp objprp = new nsaboutme.clssitprp();
        objprp.p_sitregcod = Convert.ToInt32(Session["cod"]);
        objprp.p_sitsercod = Convert.ToInt32(DropDownList1.SelectedValue);
        objprp.p_siturl = TextBox4.Text;
        objprp.p_sitsersts = 'S';
        obj.Save_Rec(objprp);
        GridView1.DataBind();
        TextBox4.Text = String.Empty;
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsaboutme.clssit obj = new nsaboutme.clssit();
        nsaboutme.clssitprp objprp = new nsaboutme.clssitprp();
        objprp.p_sitcod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.Delete_Rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
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
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}