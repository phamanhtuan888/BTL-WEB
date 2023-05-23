using Ananas.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ananas
{
    public partial class Prodetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["search"] != null)
            {
                Response.Redirect("Product.aspx?search=" + Request.QueryString["search"] + "");
            }
            List<Products> arr = (List<Products>)Application["product"];
            if (Request.QueryString["id"] != null)
            {
                string itemdesc = "";
                string iddetail = Request.QueryString["id"];
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i].id == iddetail)
                    {
                        itemdesc += "<div class=\"Item--img col-6\"><img src=\"" + arr[i].img + "\"></div>";

                        itemdesc += "<div class=\"Item--desc col-6\">" +
                            "<div class=\"item--caption\">" +
                                   "<p class=\"namepro\">" + arr[i].name + "</p>" +
                                   "<p>Tình trạng: <span class=\"prostatus\">Còn hàng</span></p>"+
                                   "<p class=\"proprice\">" + arr[i].price + "</p>" +
                                   "<p>" + arr[i].detail + "</p>" +
                                   "<button type =\"submit\" class=\"btnaddtocart\" value=\"" + arr[i].id + "\" name=\"btnaddtocart\">Thêm vào giỏ hàng" +
                                   "</button></div></div>";
                        itembag.InnerHtml = itemdesc;
                      
                    }
                }
            }

            if (Request.Form["btnaddtocart"] != null)
            {
                List<Carts> arrcart = (List<Carts>)Session["cart"];
                string idadd = Request.Form["btnaddtocart"];
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i].id == idadd)
                    {
                        Carts c = new Carts(arr[i].id, arr[i].img, arr[i].name, 1, arr[i].price, arr[i].detail, arr[i].type);
                        arrcart.Add(c);
                        break;
                    }
                }
                Session["cart"] = arrcart;
            }
        }
    }
}