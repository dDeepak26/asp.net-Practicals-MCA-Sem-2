<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorApplication.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Produce & Consume a Web Service</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        .container {
            width: 80%;
            margin: 0 auto;
            padding: 20px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        td {
            padding: 10px;
            border: 1px solid #ddd;
        }

        .button {
            background-color: #007bff;
            color: white;
            padding: 10px 20px;
            margin: 10px 0;
            border: none;
            cursor: pointer;
            text-align: center;
            display: inline-block;
            font-size: 16px;
            transition: background-color 0.3s ease;
        }

        .button:hover {
            background-color: #0056b3;
        }

        .label {
            display: block;
            margin-bottom: 20px;
            text-align: center;
            font-size: 18px;
            color: #333;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container">
         <div>
             <h1>Produce & Consume a Web Service - Deepak Durgam</h1>
             <table>
                 <tr>
                     <td>FirstValue</td><td>:</td>
                     <td> <asp:TextBox ID="txtFirstValue" runat="server" CssClass="input"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td>SecondValue</td>
                     <td>:</td>
                     <td><asp:TextBox ID="txtSecondValue" runat="server" CssClass="input"></asp:TextBox></td> 
                 </tr>
                 <tr>
                     <td>Operation</td><td>:</td>
                     <td><asp:TextBox ID="txtOperation" runat="server" CssClass="input"></asp:TextBox></td>
                 </tr>
                 <tr>
                     <td colspan="3" align="right">
                     <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" CssClass="button"></asp:Button>
                     </td>
                 </tr>
                 <tr>
                     <td colspan="3">
                     <asp:Label ID="lblResult" runat="server" Text="Result" CssClass="label"></asp:Label>
                     </td>
                 </tr>
             </table>
         </div>
    </form>
</body></html>
