<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Simple_Store_Procedure.aspx.cs" Inherits="Practical_10_Simple_Store_Procedure.Simple_Store_Procedure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Simple Stored Procedure - Deepak Durgam</h1>
            <h2>Insert Product</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
            <br />
            <label for="txtProductID">Product ID:</label>
            <asp:TextBox ID="txtProductID" runat="server"></asp:TextBox>
            <br />
            <label for="txtProductName">Product Name:</label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            <br />
            <label for="txtCity">City:</label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
            <br />
            <br />
            <h2>Products</h2>
            <asp:GridView ID="gridResults" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </div>
    </form>
</body>
</html>
