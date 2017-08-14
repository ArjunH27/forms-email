<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mail.aspx.cs" Inherits="form1.mail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="pull-right">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="send" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Messsage"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="48px" Width="119px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
