<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AutoCompleter.aspx.cs" Inherits="WebApplication.Pages.AjaxControlToolKit.AutoCompleter" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br/>
    <asp:AutoCompleteExtender ID="TextBox1_AutoCompleteExtender" runat="server" CompletionInterval="10" DelimiterCharacters="" 
        Enabled="True" ServiceMethod="GetCountries" TargetControlID="TextBox1"/>
</asp:Content>