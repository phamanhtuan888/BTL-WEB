<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ProductManager.aspx.cs" Inherits="Ananas.ProductManager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Maincontents" runat="server">
    <div class="container__manager col-10">
        <div class="container__manager--text">QUẢN LÝ MẶT HÀNG</div>
        <form class="container__manager--form" id="formPro" method="post" runat="server">
            <h3 style="color: black;">
                <asp:Label ID="loipromanager" runat="server"></asp:Label>
            </h3>
            <div class="border-form">
            <div class="form--item">
                <label class="control-labels">Name</label>
                <div class="input__group">
                    <input type="text" class="inputpro" id="Namepro" name="Namepro" placeholder="Name"/>
                </div>
            </div>
            <div class="form--item">
                <label class="control-labels">Quantity</label>
                <div class="input__group">
                    <input type="text" class="inputpro" id="Quanpro" name="Quanpro" placeholder="Quantity" />
                </div>
            </div>
            <div class="form--item">
                <label class="control-labels">Price</label>
                <div class="input__group">
                    <input type="text" class="inputpro" id="Pricepro" name="Pricepro" placeholder="Price"/>
                </div>
            </div>
            <div class="form--item">
                <label class="control-labels">Detail</label>
                <div class="input__group">
                    <input type="text" class="inputpro" id="Detailpro" name="Detailpro" placeholder="Detail"/>
                </div>
            </div>
            <div class="form--item">
                <label class="control-labels">Type</label>
                <div class="input__group">
                    <input type="text" class="inputpro" id="Typepro" name="Typepro" placeholder="Type"/>
                </div>
            </div>
            <div class="form--item">
                <label class="control-labels">Image</label>
                <div class="input__group">
                    <input type="file" class="inputpro" id="Imgpro" name="Imgpro" placeholder="Img"/>
                </div>
            </div>
            <div class="form--item ">
                <asp:Button ID="Button1" runat="server" Text="Thêm" OnClick="btnaddpro_click" />
            </div>
            </div>
            <div class="container__manager--ArrPro" id="ArrPro" runat="server">
            </div>
        </form>
    </div>
</asp:Content>
