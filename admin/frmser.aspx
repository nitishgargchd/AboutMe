<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage.master" AutoEventWireup="true" CodeFile="frmser.aspx.cs" Inherits="admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 150px">
                <h2>
                    Services</h2>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 150px">
                Service Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="350px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Icon</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Picture</td>
            <td>
                <asp:FileUpload ID="FileUpload2" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Base URL</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="350px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:DataList ID="DataList1" runat="server" DataSourceID="ObjectDataSource1" 
                    RepeatColumns="9" RepeatDirection="Horizontal" Width="540px" 
                    DataKeyField="p_sercod" ondeletecommand="DataList1_DeleteCommand">
                    <ItemTemplate>
                     <center>
                     <img src='../serpics/<%#Eval("p_sercod") %><%#Eval("p_serpic") %>' height="40px" width="90px" /><br />
                     <asp:LinkButton ID="lk1" runat=server CommandName="Delete" Text="Delete" />
                     </center>
                    </ItemTemplate>
                </asp:DataList>
                <br />
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                    SelectMethod="Disp_Rec" TypeName="nsaboutme.clsser"></asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

