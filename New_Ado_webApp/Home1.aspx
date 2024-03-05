<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Home1.aspx.cs" Inherits="New_Ado_webApp.Home1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">    
        <div>
            <h2>Home Page Content</h2>
            <hr />
            <input type="text" id="txtHtml" runat="server"/>
            <asp:TextBox ID="txtaspx" runat="server"></asp:TextBox>
            <hr />
            <input  type="button" value="HTML button!!!"/>
            <asp:Button ID="btnLoad" runat="server" Text="ASPX button!!" />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form> 
</body>
</html>
