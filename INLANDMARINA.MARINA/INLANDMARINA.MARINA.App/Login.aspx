<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="INLANDMARINA.MARINA.App.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Loging</h3>
    <div class="col-md-4">
        <table class="table">
            <tr>
                <td style="width:150px">FirstName</td>
                <td>
                    <asp:TextBox ID="uxFirstname" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>LastName</td>
                <td>
                    <asp:TextBox ID="uxLastName" runat="server"></asp:TextBox></td>
            </tr>            
            <tr>                
                <td class="2" >
                    <asp:Button ID="UxAuthenticate" runat="server" Text="Login" OnClick="UxAuthenticate_Click" /> </td>
            </tr>
            <tr>                
                <td colspan="2">
                    <asp:Label ID="uxError" runat="server" Text=""></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
