<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="Ananas.Product" %>

<asp:Content ID="Bodycontents" ContentPlaceHolderID="Maincontents" runat="server">
    <div class="row container__products col-10">
        <div class="container__products--sidebar col-3">
            <div class="sidebar__products--all">
                <ul class="all--list">
                    <li><a href="Product.aspx" class="all--item">TẤT CẢ</a></li>
                    <li class="type-devider">|</li>
                    <li><a href="Product.aspx" class="all--item">NAM</a></li>
                    <li class="type-devider">|</li>
                    <li><a href="Product.aspx" class="all--item">NỮ</a></li>
                </ul>
            </div>
            <div class="sidebar__products--types">
                <div class="types--content">
                    DÒNG SẢN PHẨM
                </div>
                <ul class="types--list">
                    <li><a href="Product.aspx?type=1" class="types--item">Basas</a></li>
                    <li><a href="Product.aspx?type=2" class="types--item">Vintas</a></li>
                    <li><a href="Product.aspx?type=3" class="types--item">Urbas</a></li>
                </ul>
            </div>
            <div class="sidebar__products--price">
                <div class="price--content">
                    GIÁ
                </div>
                <div class="price--detail">
                    <ul class="price--list">
                        <li>
                            <form class="header__main--price1">
                                <a href="Product.aspx">
                                    <label class="cb-checked">
                                        <input name="price--down" class="cb-item" type="submit" value="600000" hidden="" />Dưới 600k                                    
                                    </label>
                                </a>
                            </form>
                        </li>
                        <li>
                            <form class="header__main--price2">
                                <a href="Product.aspx">
                                    <label class="cb-checked" name="price--up">
                                        <input name="price--up" class="cb-item" type="submit" value="600000" hidden="" />Trên 600k                               
                                    </label>
                                </a>
                            </form>
                        </li>
                    </ul>

                </div>
            </div>

        </div>
        <div class="row container__products--list col-9">
            <h3>
                <asp:Label ID="titleproducts" runat="server">Tất cả sản phẩm</asp:Label>
            </h3>
            <div class="arrproducts col-12">
                <form class="list__form" runat="server">
                    <h3 style="color: black;">
                        <asp:Label ID="loiproduct" runat="server"></asp:Label>
                    </h3>
                    <div id="form__item" runat="server">
                    </div>
                    <%--<asp:CheckBoxList ID="checkitem" runat="server">
                    </asp:CheckBoxList>
                    <asp:Button ID="btnXem" runat="server" Text="Xem" OnClick="btnXem_click" />--%>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
