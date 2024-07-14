<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookManagePage.aspx.cs" 
    Inherits="Practical_8_Disconnect_Oriented_Architecture.BookManagePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Disconnected Oriented Architecture - Deepak Durgam</h1>
            <h2>Manage Books</h2>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField DataField="BookId" HeaderText="Book ID" ReadOnly="true" />
                    <asp:TemplateField HeaderText="Title">
                        <ItemTemplate>
                            <div class="textbox-container">
                                <asp:TextBox ID="txtTitle" runat="server" Text='<%# Bind("Title") %>'></asp:TextBox>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Author">
                        <ItemTemplate>
                            <div class="textbox-container">
                                <asp:TextBox ID="txtAuthor" runat="server" Text='<%# Bind("Author") %>'></asp:TextBox>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <div class="button-container">
                <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button update" OnClick="btnUpdate_Click" />
                <asp:Button ID="btnSaveChanges" runat="server" Text="Save Changes" CssClass="button save" OnClick="btnSaveChanges_Click" />
               
            </div>
             <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
