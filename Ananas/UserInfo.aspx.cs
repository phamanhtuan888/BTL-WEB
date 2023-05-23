using Ananas.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ananas
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["search"] != null)
            {
                Response.Redirect("Product.aspx?search=" + Request.QueryString["search"] + "");
            }
            
            if (Page.IsPostBack)
            {
                string name = Request.Form["ctl00$Maincontents$NameInfo"];
                string email = Request.Form["ctl00$Maincontents$EmailInfo"];
                string password = Request.Form["ctl00$Maincontents$PasswordInfo"];
                List<User> newarruser = (List<User>)Application["user"];
                for (var i=0;i<newarruser.Count;i++)
                {
                    if (newarruser[i].email == email)
                    {
                        newarruser[i].name = name;
                        newarruser[i].password = password;
                        newarruser[i].repassword = password;
                        break;
                    }
                }
                Application["user"] = newarruser;
                Session["name"] = name;
            }
            else
            {
                List<User> arruser = (List<User>)Application["user"];
                for (var i = 0; i < arruser.Count; i++)
                {
                    if (Session["email"].ToString() == arruser[i].email)
                    {
                        NameInfo.Value = arruser[i].name;
                        EmailInfo.Value = arruser[i].email;
                        PasswordInfo.Attributes["type"] = "text";
                        PasswordInfo.Value = arruser[i].password;
                    }
                }

            }
        }
    }
}