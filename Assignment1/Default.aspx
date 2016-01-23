<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Assignment1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <p>Select your birthday on the calender</p>
        <p>Enter your name  <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox></p>
        <p>
            <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" Width="78px" />
            <asp:Label ID="resultLabel" CssClass="result" runat="server" Text=""></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
