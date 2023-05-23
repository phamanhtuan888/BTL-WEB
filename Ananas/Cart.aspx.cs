using Ananas.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ananas
{
    public partial class Cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["search"] != null)
            {
                Response.Redirect("Product.aspx?search=" + Request.QueryString["search"] + "");
            }
            List<Products> arrpro = (List<Products>)Application["product"];
            List<Carts> arrcart = (List<Carts>)Session["cart"];
            string sHtml = "";
            string sCartsquan = "";
            sHtml += "<table class=\"carts\" id =\"tblcart\">";
            sHtml += "<td> Sản phẩm </td>";
            sHtml += "<td> Tên sản phẩm </td>";
            sHtml += "<td> Số lượng </td>";
            sHtml += "<td> Giá tiền </td>";
            sHtml += "<td> Thành tiền </td>";
            sHtml += "<td> Thao tác </td></tr>";
            double total = 0;
            double Grandtotal = 0;
            int a = 0;
            if (arrcart.Count > 1)
            {
                for (int i = 0; i < arrcart.Count; i++)
                {
                    for (int j = i + 1; j < arrcart.Count; j++)
                    {
                        if (arrcart[i].id == arrcart[j].id)
                        {
                            var pop = arrcart[j];
                            arrcart.Remove(pop);
                            arrcart[i].quantity++;
                            i--;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            for (int i = 0; i < arrcart.Count; i++)
            {
                a = a + arrcart[i].quantity;
                sHtml += "<tr>";
                sHtml += "<td><a href =\"Prodetail.aspx?id=" + arrcart[i].id + "\"><img src =\"" + arrcart[i].img + "\"/></a></td>";
                sHtml += "<td><a href =\"Prodetail.aspx?id=" + arrcart[i].id + "\"><p class=\"namepro\">" + arrcart[i].name + "</p></a></td>";
                sHtml += "<td>" + arrcart[i].quantity + "</td>";
                sHtml += "<td>" + arrcart[i].price + "</td>";
                total = ((arrcart[i].quantity) * (arrcart[i].price));
                sHtml += "<td>" + total + "</td>";
                Grandtotal += total;
                sHtml += "<td><button type =\"submit\" value=\""+arrcart[i].id+"\" name=\"btnAdd\"> Thêm </button>" +
                    "<button type =\"submit\" value=\"" + arrcart[i].id + "\" name=\"btnSub\"> Xóa </button></td>";
                sHtml += "</tr>";
            }
            sHtml += "<tr><td colspan = \"7\" text-align=\"center\">Tổng tiền:" + Grandtotal + "</td></tr>";
            sHtml += "</table>";
            sHtml += "<button type=\"submit\" class=\"btnCart\" name=\"btnDelAll\">XÓA HẾT</button>";
            sHtml += "<button type = \"submit\" class=\"btnCart\" name=\"btnPay\">THANH TOÁN</button>";

            sCartsquan += "SỐ SẢN PHẨM (" + a.ToString() + ")";
            cartquan.InnerHtml = sCartsquan;
            tblcart.InnerHtml = sHtml;
            if (Request.Form["btnAdd"] != null)
            {
                string proAdd = Request.Form["btnAdd"];
                for (int i = 0; i < arrcart.Count; i++)
                {
                    if (arrcart[i].id == proAdd)
                    {
                        for (int j=0;j<arrpro.Count;j++)
                        {
                            if (arrcart[i].quantity >= arrpro[j].quantity)
                            {
                                loicart.Text = "Mặt hàng này chỉ có "+arrpro[j].quantity+" sản phẩm vui lòng chọn sản phẩm khác hoặc chờ shop nhập thêm hàng";
                                break;
                            }
                            else
                            {
                                arrcart[i].quantity++;
                                Session["cart"] = arrcart;
                                Response.Redirect("Cart.aspx");
                            }
                        }
                    }
                }
            }
            if (Request.Form["btnSub"] != null)
            {
                string proSub = Request.Form["btnSub"];
                for (int i = 0; i < arrcart.Count; i++)
                {
                    if (arrcart[i].id == proSub)
                    {
                        arrcart[i].quantity--;
                        if (arrcart[i].quantity == 0)
                        {
                            var pop = arrcart[i];
                            arrcart.Remove(pop);
                            Session["cart"] = arrcart;
                        }
                        Session["cart"] = arrcart;
                        Response.Redirect("Cart.aspx"); 
                    
                    }
                }
            }
            if (Request.Form["btnDelAll"] != null)
            {
                List<Carts> newcart = new List<Carts>();
                Session["cart"] = newcart;
                Response.Redirect("Cart.aspx");
            }
            if (Request.Form["btnPay"] != null)
            {
                List<Carts> cart = (List<Carts>)Session["cart"];
                if (cart.Count == 0)
                {
                    Response.Write("<script>var k=confirm('Giỏ hàng của bạn trống vui lòng quay lại mua sản phẩm');"+
                        "if(k==true)window.location='https://localhost:44368/Product.aspx';</script>");
                    
                }
                else
                {
                    if (Session["login"].ToString() != "1")
                    {
                        Response.Write("<script> var k=confirm('Bạn cần đăng nhập để thanh toán');" +
                        "if(k==true)window.location='https://localhost:44368/Login.aspx';</script>");
                    }
                    else
                    {
                        Response.Write("<script> var k=confirm('Thanh toán thành công đơn hàng của bạn sẽ sớm được duyệt');" +
                        "if(k==true)window.location='https://localhost:44368/Home.aspx';</script>");
                    }
                }
            }
        }
    }
}

