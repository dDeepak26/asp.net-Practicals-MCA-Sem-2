<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="Practical_4_Registration_form.Success" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>success page prac4</title>
        <style>
        /* CSS styles for the success page */
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
        }
        .container {
            width: 400px;
            margin: 100px auto;
            padding: 20px;
            background-color: #fff;
            border: 1px solid #ccc;
            border-radius: 5px;
            text-align: center;
        }
        h2 {
            color: #4CAF50;
        }
        #lblMessage {
            color: #4CAF50;
        }
        #lblUsername {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
            <h2>Registration Successful</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="#4CAF50"></asp:Label><br />
            <asp:Label ID="lblUsername" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
