<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmusrprf.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="profile">
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="Disp_Rec" TypeName="nsaboutme.clssit">
        <SelectParameters>
            <asp:QueryStringParameter Name="regcod" QueryStringField="rcod" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
<asp:Image ID="im1" runat=server alt="" width="1680" height="1050" CssClass="image" />
<div class="info">
<h1>
    <asp:Label ID="Lblnam" runat="server" Text="Label"></asp:Label></h1>
<asp:Image ID="im2" runat=server Width="150px" Height="150px" CssClass="image" />
<h3>
    <asp:Label ID="lblhedline" runat="server" Text="Label"></asp:Label></h3>
	<p>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </p>
    <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1">
        <ItemTemplate>
         <a href='<%#geturl(Convert.ToInt32(Eval("p_sitcod"))) %>'>
         <img src='<%#getimg(Convert.ToInt32(Eval("p_sitsercod"))) %>' height="20px" width="20px" />
         </a>
        </ItemTemplate>
    </asp:DataList>
    <asp:Button ID="Button1" runat="server"  Text="Save to favourites" 
        Height="29px" onclick="Button1_Click" />
</div>
</div>
</asp:Content>

