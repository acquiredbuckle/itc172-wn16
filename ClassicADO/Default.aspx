<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="ClassicADO.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Authors</h1>
        <hr />
        <p>Select an author from the list</p>


        <asp:DropDownList 
            ID="AuthorDropDownList" 
            runat="server" 
            AutoPostBack="true" 
            OnSelectedIndexChanged="AuthorDropDownList_SelectedIndexChanged"
            CssClass="list">
        </asp:DropDownList>

        <asp:GridView 
            ID="BooksGridView" 
            runat="server">
        </asp:GridView>
        
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
