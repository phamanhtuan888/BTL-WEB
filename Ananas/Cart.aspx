<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="Ananas.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Maincontents" runat="server">
    <div class="container__cart">
        <div class="container__cart--text">GIỎ HÀNG CỦA BẠN</div>
        <div class="container__cart--quan col-10" id="cartquan" runat="server"></div>
        <form class="container__cart--form" id="cartform" method="post" runat="server">
            
            <h3 style="color:white;">
                <asp:Label ID="loicart" runat="server"></asp:Label>
            </h3>
            <div id="tblcart" runat="server"></div>
        </form>
     </div>
</asp:Content>
