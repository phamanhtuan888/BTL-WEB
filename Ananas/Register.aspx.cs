using Ananas.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ananas
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loidangky.Text = "";
            if (Request.QueryString["search"] != null)
            {
                Response.Redirect("Product.aspx?search=" + Request.QueryString["search"] + "");
            }
        }
        protected void btndangky_click(object sender, EventArgs e)
        {

            if (Request.Form["NameRegister"] != null)
            {
                string name = Request.Form["NameRegister"];
                string email = Request.Form["EmailRegister"];
                string password = Request.Form["PasswordRegister"];
                string repassword = Request.Form["Re-PasswordRegister"];

                User u = new User(name, email, password, repassword);
                List<User> arr = (List<User>)Application["user"];
                int tg = 0;
                
                if (arr.Count == 0)
                {
                    arr = new List<User>();
                }
                else
                {
                    for (var i=0;i<arr.Count;i++) {
                        if (arr[i].email==email)
                        {
                            tg++;
                            loidangky.Text="Email đã tồn tại. Mời chọn email khác.";

                            /* Session["loidangky"] = (int)Session["loidangky"] + 1;*/
                        }
                    }
                }
                /*if ((int)Session["loidangky"] != 0)
                {
                    Response.Write("<script> confirm('Bạn sai"+ (int)Session["loidangky"] + "');" +
                        ";</script>");
                }*/
                if (tg == 0)
                {
                    arr.Add(u);
                    Application["user"] = arr;
                    Session["login"] = 1;
                    Session["name"] = name;
                    Session["email"] = email;
                    /*Session["loidangky"] = 0;*/
                    Response.Redirect("Home.aspx");
                }
            }
        }
    }
}