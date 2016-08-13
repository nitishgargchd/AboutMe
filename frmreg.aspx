<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmreg.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%">
    <tr>
        <td colspan="3">
            <h3>
                Create Profile</h3>
        </td>
    </tr>
    <tr>
        <td style="width: 96px">
            Name</td>
        <td style="width: 129px">
            <asp:TextBox ID="txtnam" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtnam" ErrorMessage="Enter Name"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 96px">
            Email</td>
        <td style="width: 129px">
            <asp:TextBox ID="txteml" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txteml" ErrorMessage="Enter Email"></asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                ControlToValidate="txteml" ErrorMessage="Enter Valid Email" 
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 96px">
            Password</td>
        <td style="width: 129px">
            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ControlToValidate="txtpwd" ErrorMessage="Enter Password"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 96px">
            Confirm Password</td>
        <td style="width: 129px">
            <asp:TextBox ID="txtconpwd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ControlToValidate="txtconpwd" ErrorMessage="Enter Confirm Password"></asp:RequiredFieldValidator>
&nbsp;
            </td>
    </tr>
    <tr>
        <td style="width: 96px">
            &nbsp;</td>
        <td colspan="2">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" CausesValidation="False" 
                Text="Cancel" />
        </td>
    </tr>
    <tr>
        <td style="width: 96px">
            &nbsp;</td>
        <td colspan="2">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
            <asp:CompareValidator ID="CompareValidator1" runat="server" 
                ControlToCompare="txtpwd" ControlToValidate="txtconpwd" 
                ErrorMessage="Password &amp; Confirm Password must match"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 96px">
            &nbsp;</td>
        <td colspan="2">
            &nbsp;</td>
    </tr>
</table>
</asp:Content>

