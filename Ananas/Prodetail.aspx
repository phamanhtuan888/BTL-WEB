<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Prodetail.aspx.cs" Inherits="Ananas.Prodetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Maincontents" runat="server">
    <div class="row container__Prodetail col-10">
        <div class="container__Prodetail--text">CHI TIẾT SẢN PHẨM</div>
        <form class="container__Prodetail--Item" runat="server">
            <h3 style="color:black;">
                <asp:Label ID="loiprodetail" runat="server"></asp:Label>
            </h3>
            <div class="row Item--bag" id="itembag" runat="server">
                
            </div>
            
        </form>
    </div>
</asp:Content>