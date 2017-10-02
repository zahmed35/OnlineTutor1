﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="OnlineTutor.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div >
    
        <table style="width:100%;">
            <caption >
                <h1>Login Form</h1></caption>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Username:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Password:</td>
                <td>
                    <asp:TextBox ID="TextBox2" TextMode="Password" runat="server"></asp:TextBox>
                </td>
                <td>
                 </td>
            </tr>
            <tr>
                <td class="style2">
                    User Category</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Value="1">Admin</asp:ListItem>
                        <asp:ListItem Value="2">Tutor</asp:ListItem>
                        <asp:ListItem Value="3">Student </asp:ListItem>
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineTutorConnectionString %>" SelectCommand="SELECT [usertype] FROM [LoginUser]"></asp:SqlDataSource>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td></td>
                 <td></td>
                 <td></td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Log In" onclick="Button1_Click" />
                    &nbsp;
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Register" />
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
