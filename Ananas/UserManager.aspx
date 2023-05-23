<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="UserManager.aspx.cs" Inherits="Ananas.UserManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Maincontents" runat="server">
    <div class="container__manager col-10">
		<div class="container__manager--text">QUẢN LÝ TÀI KHOẢN</div>
			<form class="container__manager--form" id="formUser" method="post" runat="server">
					<h3 style="color:black;">
                        <asp:Label ID="loiusermanager" runat="server"></asp:Label>
                    </h3>
                    <div class="form--item">
                        <label class="control-label">User Name</label>
                        <div class="input__group">
                            <span class="input__group--sticker"><i class="fa-solid fa-user-large"></i></span>
                            <input type="text" class="inputuser" id="NameUser" name="NameUser" placeholder="User Name"/>
                        </div>
                    </div>
                    <div class="form--item">
                        <label class="control-label">User Email</label>
                        <div class="input__group">
                            <span class="input__group--sticker"><i class="fa-solid fa-envelope"></i></span>
                            <input type="text" class="inputuser" id="EmailUser" name="EmailUser" placeholder="User Email"/>
                        </div>
                    </div>
                    <div class="form--item">
                        <label class="control-label">Password</label>
                        <div class="input__group">
                            <span class="input__group--sticker"><i class="fa fa-lock" aria-hidden="true"></i></span>
                            <input type="password" class="inputuser" id="PasswordUser" name="PasswordUser" placeholder="Password"/>
                        </div>
                    </div>
                    <div class="form--item ">
                        <asp:Button ID="Button1" runat="server" Text="Thêm" OnClick="btnadduser_click"/>
                    </div>	
                    <div class="container__manager--ArrUser" id="ArrUser" runat="server">

                    </div>
			</form>
	</div>
</asp:Content>
