<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Fix_IIT.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitions>
<html xmlns="http://www.w3.org/2000/xhtml">
    <head runat="server">
        <title></title>
        <style type="text/css">
            .auto-style1 {
                text-align: center;
                font-size: xx-large;
            }
        </style>
    </head>
    <body>
        <form id="form1" runat="server">
             <div class="auto-style1">
                 <strong>Login Page</strong></div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style6">Email</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBoxEmail" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Please Enter Email" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password</td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextBoxPassword" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Please Enter Password" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style9"><strong>
                    <asp:Button ID="Button_login" runat="server" CssClass="auto-style13" OnClick="Button_login_Click" Text="Login" Width="131px" />
                    </strong></td>
                <td class="auto-style12"><strong>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx">New User? Register Here</asp:HyperLink>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style9">
                    <asp:Label ID="outputlabel" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="auto-style12">&nbsp;</td>
            </tr>
        </table>

        </form>

    </body>
  