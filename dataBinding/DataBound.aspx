<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBound.aspx.cs" Inherits="dataBinding.DataBound" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Data Bound - Deepak Durgam</h1>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Grid View"></asp:Label>
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:studentDBConnectionString6 %>" ProviderName="<%$ ConnectionStrings:studentDBConnectionString6.ProviderName %>" SelectCommand="SELECT * FROM [studentDetails]"></asp:SqlDataSource>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataKeyNames="id" DataSourceID="SqlDataSource1" GridLines="None">
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                    <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
                    <asp:BoundField DataField="grade" HeaderText="grade" SortExpression="grade" />
                </Columns>
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
            </asp:GridView>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Detail View"></asp:Label>
            <br />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:studentDBConnectionString %>" ProviderName="<%$ ConnectionStrings:studentDBConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [studentDetails]"></asp:SqlDataSource>
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataKeyNames="id" DataSourceID="SqlDataSource2" GridLines="None" Height="50px" Width="125px">
                <EditRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <Fields>
                    <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="age" HeaderText="age" SortExpression="age" />
                    <asp:BoundField DataField="gender" HeaderText="gender" SortExpression="gender" />
                    <asp:BoundField DataField="grade" HeaderText="grade" SortExpression="grade" />
                </Fields>
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            </asp:DetailsView>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Chart View"></asp:Label>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:studentDBConnectionString2 %>" ProviderName="<%$ ConnectionStrings:studentDBConnectionString2.ProviderName %>" SelectCommand="SELECT * FROM [studentDetails]"></asp:SqlDataSource>
            <br />
            <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource3">
                <series>
                    <asp:Series ChartType="Point" Name="Series1" XValueMember="id" YValueMembers="age">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
            <br />
            <br />
            <br />
            


        </div>
    </form>
</body>
</html>
