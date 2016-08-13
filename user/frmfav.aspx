<%@ Page Title="" Language="C#" MasterPageFile="~/user/MasterPage.master" AutoEventWireup="true" CodeFile="frmfav.aspx.cs" Inherits="user_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" 
                    RepeatDirection="Horizontal" Width="1171px" 
        DataSourceID="ObjectDataSource1">
        <ItemTemplate>
            <a href='frmusrprf.aspx?rcod=<%#Eval("prfregcod") %>'>
            <img src='../prfpics/<%#Eval("prfregcod") %><%#Eval("prfpic") %>'
               height="120px" width="120px" class=image />
            <br />
            <%#Eval("prffstnam") %><%#Eval("prflstnam") %></a>
        </ItemTemplate>
    </asp:DataList>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="favprf" TypeName="nsaboutme.clsprf">
        <SelectParameters>
            <asp:SessionParameter Name="regcod" SessionField="cod" Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
    <br />
</asp:Content>

