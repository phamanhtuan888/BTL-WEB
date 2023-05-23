using Ananas.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ananas
{
    public partial class UserManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["search"] != null)
            {
                Response.Redirect("Product.aspx?search=" + Request.QueryString["search"] + "");
            }
            if (Session["login"].ToString() != "1" || (string)Session["email"] != "admin@gmail.com")
            {
                Response.Redirect("Home.aspx");
            }

            List<User> arruser = (List<User>)Application["user"];
            string sHtml = "";

            sHtml += "<table class=\"ArrUser--List\" id =\"tbluser\">";
            sHtml += "<tr><td> Name </td>";
            sHtml += "<td> Email </td>";
            sHtml += "<td> Password </td>";
            sHtml += "<td> Delete </td></tr>";

            for (int i = 0; i < arruser.Count; i++)
            {
                sHtml += "<tr>";
                sHtml += "<td>" + arruser[i].name + "</td>";
                sHtml += "<td>" + arruser[i].email + "</td>";
                sHtml += "<td>" + arruser[i].password + "</td>";
                sHtml += "<td><button type =\"submit\" value=\"" + arruser[i].email + "\" name=\"btnSubUser\"> Xóa </button></td>";
                sHtml += "</tr>";
            }
            sHtml += "</table>";
            ArrUser.InnerHtml = sHtml;

            if (Request.Form["btnSubUser"] != null)
            {
                string AccSub = Request.Form["btnSubUser"];
                for (int i = 0; i < arruser.Count; i++)
                {
                    if (arruser[i].email == AccSub)
                    {
                        var pop = arruser[i];
                        arruser.Remove(pop);
                        Application["user"] = arruser;
                        Response.Redirect("UserManager.aspx");
                    }
                }
            }
        }
        protected void btnadduser_click(object sender, EventArgs e)
        {
            if (Request.Form["NameUser"] != null)
            {
                string name = Request.Form["NameUser"];
                string email = Request.Form["EmailUser"];
                string password = Request.Form["PasswordUser"];
               

                User u = new User(name, email, password, password);
                List<User> arr = (List<User>)Application["user"];
                
                int tg = 0;
                if (arr.Count == 0)
                {
                    arr = new List<User>();
                }
                else
                {
                    for (var i = 0; i < arr.Count; i++)
                    {
                        if (arr[i].email == email)
                        {
                            tg++;
                            loiusermanager.Text = "Email đã tồn tại. Mời chọn email khác.";
                        }
                    }
                }
                if (tg == 0)
                {
                    arr.Add(u);
                    Application["user"] = arr;
                    Response.Redirect("UserManager.aspx");
                }
            }
        }
    }
}