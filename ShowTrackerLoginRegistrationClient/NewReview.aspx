<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewReview.aspx.cs" Inherits="NewReview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Add a Show</h1>
        <hr />
        <p>
            <asp:DropDownList ID="ArtistNameDropDownList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ArtistNameDropDownList_SelectedIndexChanged"></asp:DropDownList>
        </p>
        <asp:Panel ID="Panel1" runat="server">
        <hr />
        <table id="NewArtistTable">
            <tr>
                <td>Artist Name</td>
                <td>
                    <asp:TextBox ID="ArtistNameTextBox" runat="server"></asp:TextBox>
                </td>
                <td>Artist Email</td>
                <td>
                    <asp:TextBox ID="ArtistEmailTextBox" runat="server"></asp:TextBox>
                </td>
                <td>Artist Webpage</td>
                <td>
                    <asp:TextBox ID="ArtistWebpageTextBox" runat="server"></asp:TextBox>
                </td>
                </tr>
                </table>
        <hr />
        </asp:Panel>
        <table>
            <tr>
                <td>Show Title</td>
                <td>
                    <asp:TextBox ID="ShowTitleTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Calendar ID="ShowDateCalendar" runat="server"></asp:Calendar>
                </td>
                <td>
                    <asp:TextBox ID="ShowTimeTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TicketInfoTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                <asp:Button ID="SaveShowButton" runat="server" Text="Save Show" />
                    </td>
                <td>
                    <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
