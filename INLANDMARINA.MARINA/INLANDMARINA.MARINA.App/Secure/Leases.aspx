<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Leases.aspx.cs" Inherits="INLANDMARINA.MARINA.App.Leases" %>

<%@ Register Src="~/Controls/Unleased.ascx" TagPrefix="uc1" TagName="Unleased" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Select a Slip</h3>
    <uc1:Unleased runat="server" ID="UnLeased" AllowPosBack="True" />
    <br />
    <br />

    <div class="col-md-7">
        <table>
            <tr>
                <td style="width:150px">ID</td>
                 <td>
                     <asp:Label ID="uxId" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Width</td>
                 <td>
                     <asp:Label ID="uxWidth" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>Length</td>
                 <td>
                     <asp:Label ID="uxLength" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>DockID</td>
                 <td>
                     <asp:Label ID="uxDockID" runat="server" Text=""></asp:Label></td>
            </tr>            
        </table>

    </div>
   
</asp:Content>
