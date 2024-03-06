<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Home1.aspx.cs" Inherits="New_Ado_webApp.Home1" MasterPageFile="~/MyLayout.Master" %>


<asp:Content ID="contentPage" runat="server" ContentPlaceHolderID="MainContentHolder">
    <div>
                      <nav class="navbar navbar-expand-sm bg-light">
  <div class="container-fluid">
    <!-- Links -->
    <ul class="navbar-nav">
      <li class="nav-item">
 <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Home1.aspx" CssClass="nav-link">Home</asp:HyperLink>
      </li>
      <li class="nav-item">
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/TrainerDashboard.aspx"  CssClass="nav-link">Trainers</asp:HyperLink>
      </li>
    </ul>
  </div>

</nav>  
                  <div>
            <h2>Home Page Content</h2>
            <hr />
            <input type="text" id="Text1" runat="server"/>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <hr />
            <input  type="button" value="HTML button!!!"/>
            <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button1_Click" />    
    </div>
</asp:Content>

<%--<!DOCTYPE html>

<html xmlns="http:////www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
            <form id="form1" runat="server">    
       
        <div>
  <nav class="navbar navbar-expand-sm bg-light">
  <div class="container-fluid">
    <!-- Links -->
    <ul class="navbar-nav">
      <li class="nav-item">
 <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Home1.aspx" CssClass="nav-link">Home</asp:HyperLink>
      </li>
      <li class="nav-item">
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/TrainerDashboard.aspx"  CssClass="nav-link">Trainers</asp:HyperLink>
      </li>
    </ul>
  </div>

</nav>  

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

    </div>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>--%>
