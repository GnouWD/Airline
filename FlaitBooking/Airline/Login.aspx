<%@ Page Title="Login" Language="C#" MasterPageFile="~/Airline/Usermaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FlaitBooking.Airline.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<center>
        <table style="width: 433px; height: 370px; background-color: #FF9933; font-size: large; font-weight: bold;">
            <th colspan="2" align="center"><img src="images/sin.PNG" id="" width="100px" style="height: 40px" align="center"/> </th>
            

            <tr>
                <td align="center">Username</td>
                <td align="center"><asp:TextBox ID="txtUsername1" runat="server" placeholder=" Enter Email ID"></asp:TextBox>
                    <%-- <asp:RequiredFieldValidator ID="validusername" runat="server" ControlToValidate="txt_username" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator> --%>
                </td>
            </tr>

            <tr>
                <td style="height: 72px" align="center">Password</td>
                <td style="height: 72px" align="center"><asp:TextBox ID="txtPassword1" runat="server" TextMode="Password" placeholder="Enter Password"></asp:TextBox>
                     <%--<asp:RequiredFieldValidator ID="validfname" runat="server" ControlToValidate="txt_password" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator> --%>
                </td>
            </tr>

           

            <tr>
                
                <td colspan="2" align="center">
                    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                    &nbsp&nbsp&nbsp<asp:LinkButton ID="LinkButtonSignup" runat="server" OnClick="LinkButtonSignup_Click">Sign Up</asp:LinkButton>&nbsp&nbsp&nbsp
                    
                </td>
            </tr>
        </table>
    </center>




</asp:Content>
