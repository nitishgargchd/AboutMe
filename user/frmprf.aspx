<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmprf.aspx.cs" Inherits="user_Default" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
        <tr>
            <td style="width: 174px">
                <h2>
                    Profile</h2>
            </td>
            <td>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                First Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="23px" Width="718px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                Last Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="22px" Width="718px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                Headline</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" Height="73px" TextMode="MultiLine" 
                    Width="722px" ontextchanged="TextBox3_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 174px; height: 266px">
                Biography</td>
            <td style="height: 266px">
                <cc1:Editor ID="Editor1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                Can every see your email</td>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                Site</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    DataSourceID="ObjectDataSource1" DataTextField="p_sernam" 
                    DataValueField="p_sercod" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                Base URL</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                URL</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Height="22px" Width="607px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Add" 
                    Width="70px" />
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                &nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                    DataKeyNames="p_sitcod" DataSourceID="ObjectDataSource2" 
                    onrowdeleting="GridView1_RowDeleting" Width="786px" 
                    onselectedindexchanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="URL">
                        <ItemTemplate>
                       <a href='<%#geturl(Convert.ToInt32(Eval("p_sitcod"))) %>'>
                       <%#geturl(Convert.ToInt32(Eval("p_sitcod"))) %>
                       </a>
                        </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                Background Image</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                Profile Picture</td>
            <td>
                <asp:FileUpload ID="FileUpload2" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Cancel" />
            </td>
        </tr>
        <tr>
            <td style="width: 174px">
                &nbsp;</td>
            <td>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
                    SelectMethod="Disp_Rec" TypeName="nsaboutme.clsser"></asp:ObjectDataSource>
                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                    SelectMethod="Disp_Rec" TypeName="nsaboutme.clssit">
                    <SelectParameters>
                        <asp:SessionParameter Name="regcod" SessionField="cod" Type="Int32" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

