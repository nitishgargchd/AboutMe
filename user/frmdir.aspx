<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmdir.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 195px">
                <h2>
                    Search Profile</h2>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 195px">
                Enter Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="22px" Width="523px"></asp:TextBox>
&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" 
                    RepeatDirection="Horizontal" Width="1171px">
                <ItemTemplate>
              <a href='frmusrprf.aspx?rcod=<%#Eval("prfregcod") %>'>
              <img src='../prfpics/<%#Eval("prfregcod") %><%#Eval("prfpic") %>'
               height="120px" width="120px" class=image /><br />
               <%#Eval("prffstnam") %> <%#Eval("prflstnam") %>
              </a>  
                </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
</asp:Content>

