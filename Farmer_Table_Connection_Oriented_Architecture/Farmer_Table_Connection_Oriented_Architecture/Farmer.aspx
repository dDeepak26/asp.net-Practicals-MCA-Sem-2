<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Farmer.aspx.cs" Inherits="Farmer_Table_Connection_Oriented_Architecture.Farmer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvFarmers" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="FarmerID" HeaderText="ID" />
        <asp:BoundField DataField="Name" HeaderText="Name" />
        <asp:BoundField DataField="Age" HeaderText="Age" />
        <asp:BoundField DataField="Location" HeaderText="Location" />
    </Columns>
</asp:GridView>
<br />
Name: <asp:TextBox ID="txtName" runat="server" /> <br />
Age: <asp:TextBox ID="txtAge" runat="server" /> <br />
Location: <asp:TextBox ID="txtLocation" runat="server" /> <br />
<asp:Button ID="btnInsert" runat="server" Text="Insert Farmer" OnClick="btnInsert_Click" />
<br />
<br />
Farmer ID to delete: <asp:TextBox ID="txtFarmerID" runat="server" /> <br />
<asp:Button ID="btnDelete" runat="server" Text="Delete Farmer" OnClick="btnDelete_Click" />

        </div>
    </form>
</body>
</html>
