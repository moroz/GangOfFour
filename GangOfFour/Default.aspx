<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GangOfFour._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <asp:ListView runat="server" ItemType="GangOfFour.Models.Event" ID="featuredEvents" SelectMethod="GetFeaturedEvents">
            <ItemTemplate>
                <p><%#: Item.TitleEn %></p>
                <p><%#: Item.StartsAt %>&ndash;<%#: Item.EndsAt %></p>
            </ItemTemplate>
        </asp:ListView>

    </main>

</asp:Content>
