using Ananas.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ananas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["search"] != null)
            {
                Response.Redirect("Product.aspx?search=" + Request.QueryString["search"] + "");
            }
            if (Request.Form["dangnhap"] != null)
            {
                string email = Request.Form["EmailLogin"];
                string pass = Request.Form["PasswordLogin"];
                List<User> arruser = (List<User>)Application["user"];
                int tg = 0;
                if (arruser.Count == 0)
                {
                    loidangnhap.Text = "Tài khoản không tồn tại. Vui lòng kiểm tra email và mật khẩu !";
                    /*Session["loidangnhap"] = (int)Session["loidangnhap"] + 1;*/
                }
                else
                {
                    for (int i=0;i<arruser.Count;i++)
                    {
                        if (arruser[i].email == email && arruser[i].password == pass)
                        {
                            tg++;
                            Session["login"] = 1;
                            Session["name"] = arruser[i].name;
                            Session["email"] = arruser[i].email;
                            /*Session["loidangnhap"] = 0;*/
                            break;
                        }
                    }
                    if (tg != 0)
                    {
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        loidangnhap.Text = "Tài khoản hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại email và mật khẩu !";
                        /*Session["loidangnhap"] = (int)Session["loidangnhap"] + 1;*/
                    }
                }
                /*if ((int)Session["loidangnhap"]!= 0)
                {
                    Response.Write("<script>confirm('Bạn sai "+(int)Session["loidangnhap"]+" lỗi');" +
                       "</script>");
                }*/
            }
        }
    }
}