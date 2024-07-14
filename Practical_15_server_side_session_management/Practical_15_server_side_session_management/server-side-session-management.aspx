<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="server-side-session-management.aspx.cs" 
    Inherits="Practical_15_server_side_session_management.server_side_session_management" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Server-Side Session Management Example</title>
<style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

.container {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    min-height: 100vh; /* Use min-height instead of height */
    gap: 20px;
}
}
        .button-container {
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    height: 100vh; /* This makes the container take up the full viewport height */
    gap: 20px; /* This adds some space between the buttons */
}

        h2 {
            color: #333;
            text-align: center;
            margin-bottom: 20px;
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
        <h2>Server-Side Session Management</h2>
        <asp:Label ID="lblMessage" runat="server" Text="" CssClass="label"></asp:Label>
        <br />
        <div class="button-container">
        <asp:Button ID="btnSetSession" runat="server" Text="Set Session Data" OnClick="btnSetSession_Click" CssClass="button" />
        <asp:Button ID="btnGetSession" runat="server" Text="Get Session Data" OnClick="btnGetSession_Click" CssClass="button" />
        <asp:Button ID="btnClearSession" runat="server" Text="Clear Session Data" OnClick="btnClearSession_Click" CssClass="button" />
        </div>
    </div>
</form>
</body>
</html>
