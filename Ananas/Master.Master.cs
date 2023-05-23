using Ananas.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ananas
{
    public partial class Master : System.Web.UI.MasterPage
    {
 
        protected void Page_Load(object sender, EventArgs e)
        {
            int totalPro = 0;
            List<Carts> arrcart = (List<Carts>)Session["cart"];
            for (int i=0;i<arrcart.Count;i++)
            {
                totalPro+=arrcart[i].quantity;
            }
            TotalPro.Text = totalPro.ToString();
            TotalPro1.Text = totalPro.ToString();
            if (Session["login"].ToString() == "1" && (string) Session["Email"] == "admin@gmail.com")
            {
                header__navbar.InnerHtml = "<ul class= \"header__navbar--list\">" +
                    "<li class=\"header__navbar--item\"><a href =\"UserInfo.aspx\">Xin chào " + Session["name"].ToString() + "</a></li>" +
                    "<li class=\"header__navbar--item\"><p style=\"color: #333; \">|</p></li>" +
                    "<li class=\"header__navbar--item\"><a href = \"UserManager.aspx\" ><i class=\"fa fa-archive\" aria-hidden=\"true\"></i> Quản Lý Tài Khoản</a></li>" +
                    "<li class=\"header__navbar--item\"><p style=\"color: #333; \">|</p></li>" +
                    "<li class=\"header__navbar--item\"><a href = \"ProductManager.aspx\" ><i class=\"fa fa-archive\" aria-hidden=\"true\"></i> Quản Lý Mặt Hàng</a></li>" +
                    "<li class=\"header__navbar--item\"><p style=\"color: #333; \">|</p></li>" +
                    "<li class=\"header__navbar--item\" >" + "<a href =\"Logout.aspx\"> ĐĂNG XUẤT</a></li></ul>";
                user.InnerHtml= "<li class=\"mobile__main--user\"><a href =\"UserInfo.aspx\">XIN CHÀO " + Session["name"].ToString() + "</a></li>" +
                    "<li class=\"mobile__main--user\"><a href = \"UserManager.aspx\"> QUẢN LÝ TÀI KHOẢN</a></li>" +
                    "<li class=\"mobile__main--user\"><a href = \"ProductManager.aspx\"> QUẢN LÝ MẶT HÀNG</a></li>" +
                    "<li class=\"mobile__main--user\" >" + "<a href =\"Logout.aspx\"> ĐĂNG XUẤT</a></li></ul>";
            }
            else if (Session["login"].ToString() == "1")
            {
                header__navbar.InnerHtml = "<ul class= \"header__navbar--list\">"+
                    "<li class=\"header__navbar--item\"><a href =\"UserInfo.aspx\">XIN CHÀO " + Session["name"].ToString() +"</a></li>"+
                    "<li  class=\"header__navbar--item\"><p style=\"color: #333; \">|</p></li>" +
                     "<li class=\"header__navbar--item\" >"+"<a href =\"Logout.aspx\"> ĐĂNG XUẤT</a></li></ul>";
                user.InnerHtml= "<li class=\"mobile__main--user\"><a href =\"UserInfo.aspx\">Xin chào " + Session["name"].ToString() + "</a></li>" +
                    "<li class=\"mobile__main--user\" >" + "<a href =\"Logout.aspx\"> ĐĂNG XUẤT</a></li>";
            }
            else
            {
                header__navbar.InnerHtml = "<ul class= \"header__navbar--list\" >"+
                     "<li class= \"header__navbar--item header__navbar--seperate\"><a href =\"Login.aspx\"> ĐĂNG NHẬP</a></li><li class= \"header__navbar--item\" >"+
                     "<a href = \"Register.aspx\" > ĐĂNG KÝ</a></li></ul>";
                user.InnerHtml= "<li class= \"mobile__main--user\"><a href =\"Login.aspx\"> ĐĂNG NHẬP</a></li>" +
                    "<li class= \"mobile__main--user\" ><a href = \"Register.aspx\"> ĐĂNG KÝ</a></li>";
            }
        }
    }
}
