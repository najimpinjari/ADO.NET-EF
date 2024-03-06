<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="TrainerDashboard.aspx.cs"
    Inherits="New_Ado_webApp.TrainerDashboard" Master %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
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
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/TrainerDashboard.aspx">HOme</asp:HyperLink>
</div>
  <form id="form1" runat="server">
      <div>
          <h2>All Trainers</h2>
          <asp:GridView ID="gvTrainers" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
              <AlternatingRowStyle BackColor="#F7F7F7" />
              <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
              <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
              <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
              <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
              <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
              <SortedAscendingCellStyle BackColor="#F4F4FD" />
              <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
              <SortedDescendingCellStyle BackColor="#D8D8F0" />
              <SortedDescendingHeaderStyle BackColor="#3E3277" />
          </asp:GridView>
          <asp:Label ID="lblmessage" runat="server" ForeColor="YellowGreen"></asp:Label>
      </div>
  </form>

    </div>
          
        <script src="Scripts/bootstrap.bundle.min.js"></script>
</body>
</html>
