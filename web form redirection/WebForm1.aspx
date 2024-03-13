<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="New_Ado_webApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>WEBFORM PAGE 1 CONTENT</h1>
          <%--  <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://www.google.com"
                >Google.com</asp:HyperLink> |   
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="WebForm2.aspx"
                >web form 2 page </asp:HyperLink>
            <hr />
            <asp:Button ID="Button1" runat="server" Text="Google.com" PostBackUrl="http://www.google.com" />
           <asp:Button ID="Button2" runat="server" Text="web form 2 page" PostBackUrl="WebForm2.aspx" />
             <hr />
             <asp:Button ID="btngoogle" runat="server" Text="Google.com" OnClick="btngoogle_Click" />
             <asp:Button ID="btnwebform2" runat="server" Text="web form 2 page" OnClick="btnwebform2_Click"  />
             <hr />
             <asp:Button ID="Button3" runat="server" Text="Google.com" OnClientClick="window.open('http://www.google.cpm')" />
              <asp:Button ID="Button4" runat="server" Text="web form 2 page" OnClientClick="window.open('WebForm2.aspx')"   />--%>


            <asp:HiddenField ID="hdnnumber" runat="server"  Value="0"/>

            Number : <asp:TextBox ID="TextNumber" runat="server"></asp:TextBox>

            <asp:Button ID="btnincrement" runat="server" Text="Increment Text" OnClick="btnincrement_Click" />


        </div>
    </form>
</body>
</html>
