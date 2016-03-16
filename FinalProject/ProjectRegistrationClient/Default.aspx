<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
       
 
        <h1>Shows by Name</h1>
        <p><asp:DropDownList ID="ShowDropDownList" runat="server"></asp:DropDownList></p>

        <h1>See all Shows by Venue</h1>
        <p><asp:DropDownList ID="VenueDropDownList" runat="server"></asp:DropDownList></p>
        <asp:Button ID="ShowByVenueButton" runat="server" Text="Get Shows" OnClick="ShowByVenueButton_Click" />
        <asp:DataList ID="ShowByVenueDataList" runat="server">
            <ItemTemplate>
            <h2><%#Eval("ShowName") %></h2>
                <hr />
            <h3><%#Eval("ShowDate") %></h3>
                <hr />
            <h3><%#Eval("ShowTicketInfo") %></h3>
                </ItemTemplate>
        </asp:DataList>

        <h1>See all Shows by Artist</h1>
        <p><asp:DropDownList ID="ArtistDropDownList" runat="server"></asp:DropDownList></p>
        <asp:Button ID="ShowByArtistButton" runat="server" Text="Get Shows" OnClick="ShowByArtistButton_Click" />
        <asp:DataList ID="ShowByArtistDataList" runat="server">
            <ItemTemplate>
            <h2><%#Eval("ShowName") %></h2>
                <hr />
            <h3><%#Eval("ShowDate") %></h3>
                <hr />
            <h3><%#Eval("ShowTicketInfo") %></h3>
                </ItemTemplate>
        </asp:DataList>
        
    </div>
    </form>
</body>
</html>