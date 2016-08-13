using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        nsaboutme.clsser obj = new nsaboutme.clsser();
        nsaboutme.clserprp objprp = new nsaboutme.clserprp();
        objprp.p_sernam = TextBox1.Text;
        objprp.p_serbasurl = TextBox2.Text;
        String s = FileUpload1.FileName;
        s = s.Substring(s.LastIndexOf('.'));
        s = "I" + s;
        objprp.p_serlog = s;
        String s1 = FileUpload2.FileName;
        s1 = s1.Substring(s1.LastIndexOf('.'));
        s1 = "P" + s1;
        objprp.p_serpic = s1;
        Int32 a=obj.Save_Rec(objprp);
        FileUpload1.PostedFile.SaveAs(Server.MapPath("../serpics") + "//" + a.ToString() + s);
        FileUpload2.PostedFile.SaveAs(Server.MapPath("../serpics") + "//" + a.ToString() + s1);
        TextBox1.Text = String.Empty;
        TextBox2.Text = String.Empty;
        DataList1.DataBind();
    }
    protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        nsaboutme.clsser obj = new nsaboutme.clsser();
        nsaboutme.clserprp objprp = new nsaboutme.clserprp();
        objprp.p_sercod = Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex]);
        obj.Delete_Rec(objprp);
        DataList1.DataBind();
    }
}


