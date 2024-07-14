<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="display_Student.aspx.cs" 
    Inherits="display_Student_Details.display_Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Details</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        form {
            width: 80%;
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
        }

        .label-container {
            margin-bottom: 20px;
        }

        .label-container label {
            display: inline-block;
            font-weight: bold;
            color: #333;
        }

        .label-container span {
            display: inline-block;
            color: #666;
        }

        button {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 10px 20px;
            font-size: 16px;
            cursor: pointer;
            border-radius: 5px;
            margin-top: 10px;
        }

        button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="label-container">
            <asp:Button ID="btnGetStudentData" runat="server" Text="Get Student Data" OnClick="btnGetStudentData_Click" />
        </div>
        <div class="label-container">
            <asp:Label ID="studentId" runat="server" Text="Student ID: "></asp:Label>
            <span><asp:Label ID="lblResultId" runat="server"></asp:Label></span>
        </div>
        <div class="label-container">
            <asp:Label ID="studentName" runat="server" Text="Student Name: "></asp:Label>
            <span><asp:Label ID="lblResultName" runat="server"></asp:Label></span>
        </div>
    </form>
</body>
</html>


