<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="INLANDMARINA.MARINA.App.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact Information</h3>
    <address>
        Inland Lake Marina<br />
        Box 123 <br />
        <abbr title="Phone">P:</abbr>
        (office ph) 928-555-2231 <br /> (leasing ph) 928-555-2235 <br /> (fax) 982-555-2236<br />
        Manager: Glenn Cooke <br />
        Slip Manage: Kimberley Carson <br />
        Contact Email: info@inlandmarina.com
    </address>

    <address>
        <strong>Support:</strong>   <a href="~/">support@inlandmarina.com</a><br />
        <strong>Marketing:</strong> <a href="~/">marketing@inlandmarina.com</a>
    </address>
</asp:Content>
