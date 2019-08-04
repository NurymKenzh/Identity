<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Identity.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Login Page<br />
        
        <br />
        <asp:PlaceHolder ID="LoginStatus" runat="server" Visible="False">
            <asp:Literal ID="StatusText" runat="server"></asp:Literal>
        </asp:PlaceHolder>
    
        
        <br />
        <asp:PlaceHolder ID="LoginForm" runat="server" Visible="False">
            <br />
            <asp:Label ID="Label1" runat="server" AssociatedControlID="UserName" Text="User Name"></asp:Label>
            <br />
            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" AssociatedControlID="Password" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="SignIn" runat="server" OnClick="SignIn_Click" Text="Sign In" />
        </asp:PlaceHolder>
    
        <br />
        
        <asp:PlaceHolder ID="LogoutButton" runat="server" Visible="False">
            <br />
            <asp:Button ID="SignOut" runat="server" OnClick="SignOut_Click" Text="Sign Out" />
            <br />
        </asp:PlaceHolder>
    
    </div>
    </form>
</body>
</html>
