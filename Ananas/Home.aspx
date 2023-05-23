<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Ananas.WebForm1" %>
<asp:Content ID="Bodycontents" ContentPlaceHolderID="Maincontents" runat="server">
    <!--Slideshow contents-->
            <div class="container__slideshow">
                <div class="container__slideshow--list">
                    <div class="container__slideshow--item fade">
                        <img src="./assets/img/Slide1.jpg"/>

                    </div>

                    <div class="container__slideshow--item fade">
                        <img src="./assets/img/Slide2.jpg"/>

                    </div>

                    <div class="container__slideshow--item fade">
                        <img src="./assets/img/Slide3.jpg"/>

                    </div>
                </div>
                <br>

                <div class="btnSlide">
                    <span class="dot" onclick="currentSlide(0)"></span>
                    <span class="dot" onclick="currentSlide(1)"></span>
                    <span class="dot" onclick="currentSlide(2)"></span>
                </div>
            </div>
            <!--End slideshow contents-->

            <!--Main contents-->
            <div class="container__main">
                <!--Collection-->
                <div class="row container__main--collection col-10">
                    <div class="collection--item col-6">
                        <a href=""><img src="./assets/img/allblack.jpg" alt="" class="collection-img"/></a>
                        <h3 class="title">ALL BLACK IN BLACK</h3>
                        <h3 class="desc">
                            <p>
                                Mặc dù được ứng dụng rất nhiều, nhưng sắc đen lúc nào cũng toát lên một vẻ huyền bí không nhàm chán.
                            </p>
                        </h3>
                    </div>
                    <div class="collection--item col-6">
                        <a href=""><img src="./assets/img/saleoff.jpg" alt="" class="collection-img"/></a>
                        <h3 class="title">OUTLET SALE</h3>
                        <h3 class="desc">
                            <p>Danh mục những sản phẩm bán tại "giá tốt hơn" chỉ được bán kênh online - Online Only, chúng đã từng làm mưa làm gió một thời gian và hiện đang rơi vào tình trạng bể size, bể số.</p>
                        </h3>
                    </div>
                </div>
                <!--End collection-->

                <!--Style-->
                <div class="container__main--style col-10">
                    <div class="container__main--content">
                        <h3 class="title">DANH MỤC MUA HÀNG</h3>
                    </div>
                    <div class="row container__main--liststyle">
                        <div class="liststyle--item col-4">
                            <div class="liststyle--bag">
                                <div class="liststyle--black"></div>
                                <a href=""><img src="./assets/img/stylenam.jpg" alt="" class="liststyle-img"></a>
                                <div class="liststyle--content">
                                    <a href="" class="title">GIÀY NAM</a>
                                    <a href="">New Arrivals</a>
                                    <a href="">Best Seller</a>
                                    <a href="">Sale-off</a>
                                </div>
                            </div>
                        </div>

                        <div class="liststyle--item col-4">
                            <div class="liststyle--bag">
                                <div class="liststyle--black"></div>
                                <a href=""><img src="./assets/img/stylenu.jpg" alt="" class="liststyle-img"></a>
                                <div class="liststyle--content">
                                    <a href="" class="title">GIÀY NỮ</a>
                                    <a href="">New Arrivals</a>
                                    <a href="">Best Seller</a>
                                    <a href="">Sale-off</a>
                                </div>
                            </div>
                        </div>

                        <div class="liststyle--item col-4">
                            <div class="liststyle--bag">
                                <div class="liststyle--black"></div>
                                <a href=""><img src="./assets/img/styleall.jpg" alt="" class="liststyle-img"></a>
                                <div class="liststyle--content">
                                    <a href="" class="title">DÒNG SẢN PHẨM</a>
                                    <a href="">Basas</a>
                                    <a href="">Vintas</a>
                                    <a href="">Urbas</a>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
                <!--End style-->

                <!--Best seller-->
                <div class="container__main--seller col-10">
                    <div class="container__main--content">
                        <h3 class="title">BEST SELLER</h3>
                    </div>
                    <div class="row container__main--bestseller">
                        <div class="bestseller--item col-3">
                            <div class="bestseller--bag">
                                <a href=""><img src="./assets/img/bestseller1.jpg" alt="" class="bestseller-img"></a>
                                <div class="bestseller--content">
                                    <h3 class="name"><a href="">Baseball Cap - Be Positive</a>
                                    </h3>
                                    <h3 class="color">Pink</h3>
                                    <h3 class="price">275.000 VND </h3>
                                </div>
                            </div>
                        </div>

                        <div class="bestseller--item col-3">
                            <div class="bestseller--bag">
                                <a href=""><img src="./assets/img/bestseller2.jpg" alt="" class="bestseller-img"></a>
                                <div class="bestseller--content">
                                    <h3 class="name"><a href="https://ananas.vn/product-detail/a61043/" tabindex="0">Vintas The New Military - High Top</a>
                                    </h3>
                                    <h3 class="color">Capulet Olive</h3>
                                    <h3 class="price">495.000 VND </h3>
                                </div>
                            </div>
                        </div>

                        <div class="bestseller--item col-3">
                            <div class="bestseller--bag">
                                <a href=""><img src="./assets/img/bestseller3.jpg" alt="" class="bestseller-img"></a>
                                <div class="bestseller--content">
                                    <h3 class="name"><a href="https://ananas.vn/product-detail/a61024/" tabindex="0">Basas Bumper Gum - Slip On</a>
                                    </h3>
                                    <h3 class="color">Offwhite/Gum</h3>
                                    <h3 class="price">450.000 VND </h3>
                                </div>
                            </div>
                        </div>
                        <div class="bestseller--item col-3">
                            <div class="bestseller--bag">
                                <a href=""><img src="./assets/img/bestseller4.jpg" alt="" class="bestseller-img"></a>
                                <div class="bestseller--content">
                                    <h3 class="name"><a href="https://ananas.vn/product-detail/a61023/" tabindex="0">Basas New Simple Life - Slip On</a>
                                    </h3>
                                    <h3 class="color">White</h3>
                                    <h3 class="price">420.000 VND </h3>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
                <!--End Best seller-->
            </div>
            <!--End Main contents-->
</asp:Content>
