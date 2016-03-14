<%@ Page Language="C#" AutoEventWireup="true" CodeFile="VenueRegistration.aspx.cs" Inherits="VenueRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table> <!-- to do: add rest of fields -->
        <tr>
            <td>Venue Name</td>
            <td>
                <asp:TextBox ID="VenueNameTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="VenueNameRequiredValidator" runat="server" ErrorMessage="Venue name required" ControlToValidate="VenueNameTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Venue Address</td>
            <td>
                <asp:TextBox ID="VenueAddressTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="VenueAddressRequiredValidator" runat="server" ErrorMessage="Address required" ControlToValidate="VenueAddressTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Venue City</td>
            <td>
                <asp:TextBox ID="VenueCityTextBox" runat="server"></asp:TextBox> 
            </td>
            <td>
                <asp:RequiredFieldValidator ID="VenueCityRequiredValidator" runat="server" ErrorMessage="City Required" ControlToValidate="VenueCityTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Venue State</td>
            <td>
                <asp:TextBox ID="VenueStateTextBox" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="VenueStateRequiredValidator" runat="server" ErrorMessage="State required" ControlToValidate="VenueStateTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
             <td>Venue Zip Code</td>
             <td>
                 <asp:TextBox ID="VenueZipCodeTextBox" runat="server"></asp:TextBox>
             </td>
             <td>
                 <asp:RequiredFieldValidator ID="VenueZipCodeRequiredValidator" runat="server" ErrorMessage="Zip code required" ControlToValidate="VenueZipCodeTextBox"></asp:RequiredFieldValidator>
             </td>
         </tr>
            <tr>
                <td>Venue Phone</td>
            <td>
                <asp:TextBox ID="VenuePhoneTextBox" runat="server"></asp:TextBox>
            </td>
                <td>
                    <asp:RequiredFieldValidator ID="VenuePhoneRequiredValidator" runat="server" ErrorMessage="Phone required" ControlToValidate="VenuePhoneTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
            </td>
            <td><asp:RequiredFieldValidator ID="EmailRequiredValidator" runat="server" ErrorMessage="Email required" ControlToValidate="EmailNameTextBox"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailTextBox" ErrorMessage="Not a valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
            <tr>
                <td>Venue Web Page</td>
                <td>
                    <asp:TextBox ID="VenueWebPageTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="VenueWebPageRequiredValidator" runat="server" ErrorMessage="Web page required" ControlToValidate="VenueWebPageTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Age Restriction</td>
                <td>
                    <asp:TextBox ID="AgeRestrictionTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="AgeRestictionRequiredValidator" runat="server" ErrorMessage="Age restriction required" ControlToValidate="AgeRestrictionTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>User Name</td>
                <td>
                    <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="UserNameRequiredValidator" runat="server" ErrorMessage="User name required" ControlToValidate="UserNameTextBox"></asp:RequiredFieldValidator>
                </td>
            </tr>
        <tr>
            <td>Password</td>
            <td>
                <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="PasswordTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Confirm Password</td>
            <td>
                <asp:TextBox ID="ConfirmTextBox" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="ConfirmTextBox"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Submit</td>
            <td>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click"></asp:Button>
            </td>
            <td></td>
            <td>
                <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
            </td>
            <td></td>
        </tr>
            </table>
            </div>
    </form>
</body>
</html>
