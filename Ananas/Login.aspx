<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ananas.Login" %>

<asp:Content ID="Bodycontents" ContentPlaceHolderID="Maincontents" runat="server">
    <div class="container__login">
                <div class="container__login--text">ĐĂNG NHẬP</div>
                <form class="container__login--form" id="formlogin" method="post">
                    <h3 style="color:white;">
                        <asp:Label ID="loidangnhap" runat="server"></asp:Label>
                    </h3>
                    <div class="form--item">
                        <label for="email" class="control-label">Your Email</label>
                        <div class="input__group">
                            <span class="input__group--sticker"><i class="fa-solid fa-envelope"></i></span>
                            <input type="text" class="inputlogin" id="EmailLogin" name="EmailLogin" placeholder="Your Email" required="required"/>
                        </div>
                    </div>
                    <div class="form--item">
                        <label for="password" class="control-label">Password</label>
                        <div class="input__group">
                            <span class="input__group--sticker"><i class="fa fa-lock" aria-hidden="true"></i></span>
                            <input type="password" class="inputlogin" id="PasswordLogin" name="PasswordLogin" placeholder="Password" required="required"/>
                        </div>
                    </div>

                    <div class="form--item ">
                        <input type="submit" name="dangnhap" id="dangnhap" value="Đăng nhập"/>
                    </div>
                </form>
            </div>
</asp:Content>
