<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="MGD_2._0.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Styles.css"; />
    <title></title>
</head>
<body>
    <form id="MainMenu" runat="server">

           <div class="container1">
           <asp:Label ID="lblWelcome" runat="server" BorderStyle="None" Text="Welcome to MGD"></asp:Label>

           <div class="button"> <asp:Button ID="btnAdd" runat="server" BorderStyle="None" Text="Add" OnClick="btnAdd_Click"></asp:Button> </div>
                
           <div class="button"> <asp:Button ID="btnEdit" runat="server" BorderStyle="None" Text="Edit" OnClick="btnEdit_Click"></asp:Button> </div>

           <div class="button"> <asp:Button ID="btnDelete" runat="server" BorderStyle="None" Text="Delete" OnClick="btnDelete_Click"></asp:Button> </div>

           </div>

    </form>
</body>
</html>
