<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="Practical_4_Registration_form.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Page Prac4</title>
<style>
        /* CSS styles for the registration form */
        body, html {
            height: 100%;
            margin: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            background-color: #f2f2f2;
        }
        .registration-form {
            width: 300px;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: #fff;
        }
        .registration-form h2 {
            margin-top: 0;
            margin-bottom: 20px;
            text-align: center;
        }
        .registration-form label {
            display: block;
            margin-bottom: 5px;
        }
        .registration-form input[type="text"],
        .registration-form input[type="password"] {
            width: 100%;
            padding: 8px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 3px;
            box-sizing: border-box;
        }
        .registration-form input[type="submit"] {
            width: 100%;
            padding: 10px;
            border: none;
            border-radius: 3px;
            background-color: #4CAF50;
            color: white;
            cursor: pointer;
        }
        .registration-form input[type="submit"]:hover {
            background-color: #45a049;
        }
        .registration-form .error-message {
            color: red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
          <div class="registration-form">
            <h2>User Registration</h2>
            <asp:Label ID="lblMessage" runat="server" CssClass="error-message"></asp:Label><br />
            <label for="txtUsername">Username:</label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
            <label for="txtPassword">Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
