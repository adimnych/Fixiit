<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Fix_IIT.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/Registration.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
            text-align: left;
            width: 212px;
        }
        .auto-style3 {
            height: 16px;
            text-align: left;
            width: 212px;
        }
        .auto-style5 {
            height: 23px;
            text-align: right;
            width: 186px;
        }
        .auto-style6 {
            height: 16px;
            text-align: right;
            width: 186px;
        }
        .auto-style7 {
            text-align: left;
            width: 165px;
        }
        .auto-style8 {
            height: 23px;
            text-align: left;
            width: 165px;
        }
        .auto-style9 {
            height: 16px;
            text-align: left;
            width: 165px;
        }
        .auto-style10 {
            text-align: right;
            width: 186px;
        }
        .auto-style11 {
            text-align: left;
            width: 212px;
        }
        .auto-style12 {
            text-align: right;
            width: 186px;
            height: 26px;
        }
        .auto-style13 {
            text-align: left;
            width: 165px;
            height: 26px;
        }
        .auto-style14 {
            text-align: left;
            height: 26px;
            width: 212px;
        }
        .auto-style15 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="signup" runat="server">
    <div class="Registration">
        <h1> Registration Form</h1>
        <table class="table"></table>
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6"><strong>First name:</strong></td>
                    <td class="auto-style9">
                        <asp:TextBox ID="TextBoxFN" runat="server" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="FirstNameRequiredFieldValidator" runat="server" ErrorMessage="First Name Required" ForeColor="#FF3300" ControlToValidate="TextBoxFN">First Name Required</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12"><strong>Last name:</strong></td>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBoxLN" runat="server" Width="180px"></asp:TextBox>
                    </td>
                    <td class="auto-style14">
                        <asp:RequiredFieldValidator ID="LastNameRequiredFieldValidator" runat="server" ErrorMessage="Last Name Required" ForeColor="#FF3300" ControlToValidate="TextBoxLN">Last Name Required</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10"><strong>E-mail:</strong></td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBoxEM" runat="server" Width="180px" ></asp:TextBox>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="EmailRequiredFieldValidator3" runat="server" ErrorMessage="Email required" ForeColor="#FF3300" ControlToValidate="TextBoxEM">Email required</asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator" runat="server" ErrorMessage="You must enter a valid email " ForeColor="#FF3300" ControlToValidate="TextBoxEM" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12"><strong>Password:</strong></td>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBoxPW" runat="server" Width="180px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style14">
                        <asp:RequiredFieldValidator ID="PasswordRequiredFieldValidator" runat="server" ErrorMessage="Password Require" ForeColor="#FF3300" ControlToValidate="TextBoxPW">Password Required</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"><strong>Confirm Password:</strong></td>
                    <td class="auto-style8">
                        <asp:TextBox ID="TextBoxCPW" runat="server" Width="180px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="PasswordRequiredFieldValidator2" runat="server" ErrorMessage="Please re-enter Password" ForeColor="#FF3300" ControlToValidate="TextBoxCPW">Please re-enter Password</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPW" ControlToValidate="TextBoxCPW" ErrorMessage="Both Passwords must match" ForeColor="#FF3300"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10"><strong>Country:</strong></td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="DropDownListCountry" runat="server" Width="180px">
                            <asp:ListItem Selected="True">Select Country:</asp:ListItem>
                            <asp:ListItem>USA</asp:ListItem>
                            <asp:ListItem>UK</asp:ListItem>
                            <asp:ListItem>Germany</asp:ListItem>
                            <asp:ListItem>France</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style11">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Select Country" ForeColor="#FF3300" ControlToValidate="DropDownListCountry" InitialValue="Select Country:">Select Country</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                        <input id="Reset1" type="reset" value="Reset" /></td>
                    <td class="auto-style11">
                        <strong>
                        <asp:HyperLink ID="HyperLinkLogin" runat="server" CssClass="auto-style15" NavigateUrl="~/Login.aspx">Already have an Acccount? Click here</asp:HyperLink>
                        </strong></td>
                </tr>
            </table>
        </div>
    </div>
    </form>

</body>
</html>
