﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateRegistration.aspx.cs" Inherits="INLANDMARINA.MARINA.App.Secure.UpdateRegistration" %>

<%@ Register Src="~/Controls/Registration.ascx" TagPrefix="uc1" TagName="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:Registration runat="server" ID="Registration" />
</asp:Content>
