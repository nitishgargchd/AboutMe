<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        #HyperLink1{
text-decoration:none;
        }
    </style>
    <div class="title">
        Sign up to quickly build your personal profile page that points users to your content from around the web.</div>
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td valign="top">
                ENTER YOUR EMAIL ADDRESS<br />
                <asp:TextBox ID="txteml" runat="server" CssClass="field" Height="20px" 
                    Width="300px"></asp:TextBox>
&nbsp;</td>
        </tr>
        <tr>
            <td height="20" valign="top">
            </td>
        </tr>
        <tr>
            <td valign="top">
                ENTER PASSWORD<br />
                <asp:TextBox ID="txtpwd" runat="server" CssClass="field" Width="300px" 
                    Height="20px" TextMode="Password"></asp:TextBox>
&nbsp;</td>
        </tr>
        <tr>
            <td height="20" valign="top">
            </td>
        </tr>
        <tr>
            <td valign="top">
                <asp:Button ID="Button1" runat="server" Text="Login" Width="145px" 
                    onclick="Button1_Click" Height="30px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="links" 
                    NavigateUrl="frmreg.aspx" Font-Size="Small" Height="20px" >Not Registered Yet?</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td height="20" valign="top">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td valign="top">
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

