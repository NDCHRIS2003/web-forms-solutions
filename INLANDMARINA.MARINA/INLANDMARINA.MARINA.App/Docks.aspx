<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Docks.aspx.cs" Inherits="INLANDMARINA.MARINA.App.Docks" %>

<%@ Register Src="~/Controls/LeaseSelector.ascx" TagPrefix="uc1" TagName="LeaseSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>The List of Docks</h3>
    <uc1:LeaseSelector runat="server" ID="LeaseSelector" />
</asp:Content>
