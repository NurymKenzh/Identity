<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Identity.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        New User Registration Page<br />
        <asp:Literal ID="StatusMessage" runat="server"></asp:Literal>
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
        <asp:Button ID="CreateUser" runat="server" OnClick="CreateUser_Click" Text="Register" />
    
    </div>
    </form>
</body>
</html>
