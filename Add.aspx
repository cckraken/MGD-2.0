<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="MGD_2._0.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Styles.css"; />
    <title></title>
</head>
<body>
    <form id="Add" runat="server">
        <div class="container1">
            <!--Elements for labels -->
            <div class="label1"> <asp:Label ID="lblCodeName" runat="server" BorderStyle="None" Text="Codename"></asp:Label> </div>
            <div class="label2"> <asp:Label ID="lblAbilityRank" runat="server" BorderStyle="None" Text="Ability Rank"></asp:Label> </div>
            <div class="label3"> <asp:Label ID="lblAffiliation" runat="server" BorderStyle="None" Text="Affiliation"></asp:Label> </div>
            <div class="label4"> <asp:Label ID="lblHairColour" runat="server" BorderStyle="None" Text="Hair Colour"></asp:Label> </div>
            <div class="label5"> <asp:Label ID="lblEthnicity" runat="server" BorderStyle="None" Text="Ethnicity"></asp:Label> </div>

            <div class="label6"> <asp:Label ID="lblAtMotherBase" runat="server" BorderStyle="None" Text="At Motherbase?"></asp:Label></div>
            <div class="label7"> <asp:CheckBox ID="ckdAtMotherBase" runat="server" BorderStyle="None" Text=" "></asp:CheckBox> </div>
            <div class="label8"> <asp:Calendar ID="lblCalendar" runat="server" BorderStyle="None"> </asp:Calendar>    </div>
            <!--Elements for textboxes -->
            <div class="textbox1"> <asp:TextBox ID="txtCodeName" runat="server" BorderStyle="Solid" BackColor="White" BorderColor="Black" BorderWidth="2px"></asp:TextBox> </div>
            <div class="textbox2"> <asp:TextBox ID="txtAbilityRank" runat="server" BorderStyle="Solid" BackColor="White" BorderColor="Black" BorderWidth="2px"></asp:TextBox> </div>
            <div class="textbox3"> <asp:TextBox ID="txtAffiliation" runat="server" BorderStyle="Solid" BackColor="White" BorderColor="Black" BorderWidth="2px"></asp:TextBox> </div>
            <div class="textbox4"> <asp:TextBox ID="txtHairColour" runat="server" BorderStyle="Solid" BackColor="White" BorderColor="Black" BorderWidth="2px"></asp:TextBox> </div>
            <div class="textbox5"> <asp:TextBox ID="txtEthnicity" runat="server" BorderStyle="Solid" BackColor="White" BorderColor="Black" BorderWidth="2px"></asp:TextBox> </div>

            <!--Elements for Add/Back -->
            <asp:Button CssClass="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click"> </asp:Button>
            <asp:Button CssClass="btnBack" runat="server" Text="Back" OnClick="btnBack_Click"> </asp:Button>


        </div>
    </form></body>
</html>
