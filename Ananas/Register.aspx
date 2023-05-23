<%@ page title="" language="C#" masterpagefile="~/Master.Master" autoeventwireup="true" codebehind="Register.aspx.cs" inherits="Ananas.Register" %>

<asp:Content ID="Bodycontents" ContentPlaceHolderID="Maincontents" runat="server">
    <div class="container__register">
        <div class="container__register--text">ĐĂNG KÝ</div>
        <form class="container__register--form" id="formregister" method="post" runat="server" onsubmit="return (checkregister())">
            <h3 style="color: white;">
                <asp:Label ID="loidangky" runat="server"></asp:Label>
            </h3>
            <div class="form--item">
                <label class="control-label">Your Name</label>
                <div class="input__group">
                    <span class="input__group--sticker"><i class="fa-solid fa-user-large"></i></span>
                    <input type="text" class="inputregister" id="NameRegister" name="NameRegister" placeholder="Your Name" />
                </div>
            </div>
            <div class="form--item">
                <label class="control-label">Your Email</label>
                <div class="input__group">
                    <span class="input__group--sticker"><i class="fa-solid fa-envelope"></i></span>
                    <input type="text" class="inputregister" id="EmailRegister" name="EmailRegister" placeholder="Your Email" />
                </div>
            </div>
            <div class="form--item">
                <label class="control-label">Password</label>
                <div class="input__group">
                    <span class="input__group--sticker"><i class="fa fa-lock" aria-hidden="true"></i></span>
                    <input type="text" class="inputregister" id="PasswordRegister" name="PasswordRegister" placeholder="Password" />
                </div>
            </div>
            <div class="form--item">
                <label class="control-label">Retype Password</label>
                <div class="input__group">
                    <span class="input__group--sticker"><i class="fa fa-lock" aria-hidden="true"></i></span>
                    <input type="text" class="inputregister" id="Re-PasswordRegister" name="Re-PasswordRegister" placeholder="Retype Password" />
                </div>
            </div>

            <div class="form--item ">
                <asp:Button ID="Button1" runat="server" Text="Đăng ký" OnClick="btndangky_click" />
            </div>
        </form>
    </div>
</asp:Content>
