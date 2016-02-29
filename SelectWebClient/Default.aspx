<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Choose a Venue by Name</h1>
        <asp:DropDownList ID="VenueDropDownList" runat="server"></asp:DropDownList>
        <asp:Button ID="VenueButton" runat="server" Text="Get Venues" Onclick="VenueButton_Click"/>
        <asp:DataList ID="VenueDataList" runat="server"></asp:DataList>
        <h1>Choose a Artist by Name</h1>
        <asp:DropDownList ID="ArtistDropDownList" runat="server"></asp:DropDownList>
        <asp:Button ID="ArtistButton" runat="server" Text="Button" OnClick="ArtistButton_Click" />
        <asp:DataList ID="ArtistDataList" runat="server"></asp:DataList>
        <h1>Select a Show</h1>
        <asp:DropDownList ID="ShowDropDownList" runat="server"></asp:DropDownList>
        <asp:Button ID="ShowButton" runat="server" Text="Button" OnClick="ShowButton_Click" />
        <asp:DataList ID="ShowDataList" runat="server"></asp:DataList>
    </div>
    </form>
</body>
</html>
