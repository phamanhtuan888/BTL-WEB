<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="Ananas.UserInfo" %>
<asp:Content ID="Bodycontents" ContentPlaceHolderID="Maincontents" runat="server">
    <div class="container__info">
                <div class="container__info--text">THÔNG TIN TÀI KHOẢN</div>
                <form class="container__info--form" id="forminfo" method="post" runat="server" onsubmit="return (checkinfo())">
                    <p>
                        <asp:Label ID="loithongtin" runat="server"></asp:Label>
                    </p>
                    <div class="form--item">
                        <label for="email" class="control-label">Your Name</label>
                        <div class="input__group">
                            <span class="input__group--sticker"><i class="fa-solid fa-user-large"></i></i></i></span>
                            <input type="text" class="inputinfo" id="NameInfo" name="NameInfo" runat="server" required="required">
                        </div>
                    </div>
                    <div class="form--item">
                        <label for="email" class="control-label">Your Email</label>
                        <div class="input__group">
                            <span class="input__group--sticker"><i class="fa-solid fa-envelope"></i></i></span>
                            <input type="text" class="inputinfo" id="EmailInfo" name="EmailInfo" runat="server" required="required">
                        </div>
                    </div>
                    <div class="form--item">
                        <label for="password" class="control-label">Password</label>
                        <div class="input__group">
                            <span class="input__group--sticker"><i class="fa fa-lock" aria-hidden="true"></i></span>
                            <input type="text" class="inputinfo" id="PasswordInfo" name="PasswordInfo" runat="server" required="required">
                        </div>
                    </div>

                    <div class="form--item ">
                        <input type="submit" name="Luu" id="Luu" value="Lưu"/>
                    </div>
                </form>
            </div>
</asp:Content>
