using Ananas.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ananas
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string shtml = "";
            List<Products> arr = (List<Products>)Application["product"];
            foreach (Products p in arr)
            {
                if (Request.QueryString["type"] != null)
                {
                    string Protype = Request.QueryString["type"];
                    if (Protype == "1") { titleproducts.Text = "Basas"; }
                    else if (Protype == "2") { titleproducts.Text = "Vintas"; }
                    else if (Protype == "3") { titleproducts.Text = "Urbas"; }

                    if (p.type == Protype)
                    {
                        shtml += "<div class=\"list__view-item col-4\">" +
                              "<div class=\"item--bag\">" +
                                   "<a class=\"linkdetail\" href=\"Prodetail.aspx?id=" + p.id + "\" title =\"Chi tiết sản phẩm\" name=\"linkdetail\">Chi tiết</a>" +
                                   "<a href = \"Prodetail.aspx?id=" + p.id + "\" name=\"linkdetail\">" + "<img src =\"" + p.img + "\"/></a>" +
                                   "<div class=\"item--caption\">" +
                                       "<a href = \"Prodetail.aspx?id=" + p.id + "\">" +
                                       "<p class=\"namepro\">" + p.name + "</p></a>" +
                                       "<p>" + p.price + "</p>" +
                                       "<button type =\"submit\" class=\"btnaddtocart\" value=\"" + p.id + "\" name=\"btnaddtocart\">Thêm vào giỏ hàng" +
                                       "</button></div></div></div>";
                    }
                }
                else
                {
                    if (Request.QueryString["search"] != null)
                    {
                        int soluong = 0;
                        string SearchInput = Request.QueryString["search"].ToUpper();
                        string Searchtype = " ";
                        if (SearchInput == "BASAS") { Searchtype = "1"; }
                        else if (SearchInput == "VINTAS") { Searchtype = "2"; }
                        else if (SearchInput == "URBAS") { Searchtype = "3"; }
                        else if (SearchInput.Equals(p.price.ToString()))
                        {

                            shtml += "<div class=\"list__view-item col-4\">" +
                                    "<div class=\"item--bag\">" +
                                         "<a class=\"linkdetail\" href=\"Prodetail.aspx?id=" + p.id + "\" title =\"Chi tiết sản phẩm\" name=\"linkdetail\">Chi tiết</a>" +
                                         "<a href = \"Prodetail.aspx?id=" + p.id + "\" name=\"linkdetail\">" + "<img src =\"" + p.img + "\"/></a>" +
                                         "<div class=\"item--caption\">" +
                                             "<a href = \"Prodetail.aspx?id=" + p.id + "\">" +
                                             "<p class=\"namepro\">" + p.name + "</p></a>" +
                                             "<p>" + p.price + "</p>" +
                                             "<button type =\"submit\" class=\"btnaddtocart\" value=\"" + p.id + "\" name=\"btnaddtocart\">Thêm vào giỏ hàng" +
                                             "</button></div></div></div>";
                            titleproducts.Text = "Kết quả tìm kiếm " + Request.QueryString["search"];
                        }
                        else
                        {
                            List<Products> searcharr = new List<Products>();
                            string s = p.name.ToUpper().IndexOf(SearchInput).ToString();

                            if (s != "-1") { searcharr.Add(p); }

                            foreach (Products psearch in searcharr)
                            {
                                soluong = searcharr.Count();
                                shtml += "<div class=\"list__view-item col-4\">" +
                                    "<div class=\"item--bag\">" +
                                   "<a class=\"linkdetail\" href=\"Prodetail.aspx?id=" + psearch.id + "\" title =\"Chi tiết sản phẩm\" name=\"linkdetail\">Chi tiết</a>" +
                                   "<a href = \"Prodetail.aspx?id=" + psearch.id + "\" name=\"linkdetail\">" + "<img src =\"" + p.img + "\"/></a>" +
                                   "<div class=\"item--caption\">" +
                                       "<a href = \"Prodetail.aspx?id=" + psearch.id + "\">" +
                                       "<p class=\"namepro\">" + psearch.name + "</p></a>" +
                                       "<p>" + psearch.price + "</p>" +
                                       "<button type =\"submit\" class=\"btnaddtocart\" value=\"" + psearch.id + "\" name=\"btnaddtocart\">Thêm vào giỏ hàng" +
                                       "</button></div></div></div>";
                            }
                            titleproducts.Text = "Kết quả tìm kiếm " + Request.QueryString["search"];

                        }

                        if (p.type == Searchtype)
                        {

                            shtml += "<div class=\"list__view-item col-4\">" +
                              "<div class=\"item--bag\">" +
                                   "<a class=\"linkdetail\" href=\"Prodetail.aspx?id=" + p.id + "\" title =\"Chi tiết sản phẩm\" name=\"linkdetail\">Chi tiết</a>" +
                                   "<a href = \"Prodetail.aspx?id=" + p.id + "\" name=\"linkdetail\">" + "<img src =\"" + p.img + "\"/></a>" +
                                   "<div class=\"item--caption\">" +
                                       "<a href = \"Prodetail.aspx?id=" + p.id + "\">" +
                                       "<p class=\"namepro\">" + p.name + "</p></a>" +
                                       "<p>" + p.price + "</p>" +
                                       "<button type =\"submit\" class=\"btnaddtocart\" value=\"" + p.id + "\" name=\"btnaddtocart\">Thêm vào giỏ hàng" +
                                       "</button></div></div></div>";


                        }

                    }
                    else if (Request.QueryString["price--down"] != null)
                    {
                        string price1 = Request.QueryString["price--down"];
                        if (p.price < double.Parse(price1))
                        {
                            titleproducts.Text = "Nhỏ hơn 600k";
                            shtml += "<div class=\"list__view-item col-4\">" +
                                     "<div class=\"item--bag\">" +
                                          "<a class=\"linkdetail\" href=\"Prodetail.aspx?id=" + p.id + "\" title =\"Chi tiết sản phẩm\" name=\"linkdetail\">Chi tiết</a>" +
                                          "<a href = \"Prodetail.aspx?id=" + p.id + "\" name=\"linkdetail\">" + "<img src =\"" + p.img + "\"/></a>" +
                                          "<div class=\"item--caption\">" +
                                              "<a href = \"Prodetail.aspx?id=" + p.id + "\">" +
                                              "<p class=\"namepro\">" + p.name + "</p></a>" +
                                              "<p>" + p.price + "</p>" +
                                              "<button type =\"submit\" class=\"btnaddtocart\" value=\"" + p.id + "\" name=\"btnaddtocart\">Thêm vào giỏ hàng" +
                                              "</button></div></div></div>";

                        }
                    }
                    else if (Request.QueryString["price--up"] != null)
                    {
                        string price2 = Request.QueryString["price--up"];
                        if (p.price > double.Parse(price2))
                        {
                            titleproducts.Text = "Lớn hơn 600k";
                            shtml += "<div class=\"list__view-item col-4\">" +
                                     "<div class=\"item--bag\">" +
                                          "<a class=\"linkdetail\" href=\"Prodetail.aspx?id=" + p.id + "\" title =\"Chi tiết sản phẩm\" name=\"linkdetail\">Chi tiết</a>" +
                                          "<a href = \"Prodetail.aspx?id=" + p.id + "\" name=\"linkdetail\">" + "<img src =\"" + p.img + "\"/></a>" +
                                          "<div class=\"item--caption\">" +
                                              "<a href = \"Prodetail.aspx?id=" + p.id + "\">" +
                                              "<p class=\"namepro\">" + p.name + "</p></a>" +
                                              "<p>" + p.price + "</p>" +
                                              "<button type =\"submit\" class=\"btnaddtocart\" value=\"" + p.id + "\" name=\"btnaddtocart\">Thêm vào giỏ hàng" +
                                              "</button></div></div></div>";

                        }
                    }
                    else
                    {
                        titleproducts.Text = "Tất cả sản phẩm";
                        shtml += "<div class=\"list__view-item col-4\">" +
                                  "<div class=\"item--bag\">" +
                                       "<a class=\"linkdetail\" href=\"Prodetail.aspx?id=" + p.id + "\" title =\"Chi tiết sản phẩm\" name=\"linkdetail\">Chi tiết</a>" +
                                       "<a href = \"Prodetail.aspx?id=" + p.id + "\" name=\"linkdetail\">" + "<img src =\"" + p.img + "\"/></a>" +
                                       "<div class=\"item--caption\">" +
                                           "<a href = \"Prodetail.aspx?id=" + p.id + "\">" +
                                           "<p class=\"namepro\">" + p.name + "</p></a>" +
                                           "<p>" + p.price + "</p>" +
                                           "<button type =\"submit\" class=\"btnaddtocart\" value=\"" + p.id + "\" name=\"btnaddtocart\">Thêm vào giỏ hàng" +
                                           "</button></div></div></div>";
                    }

                }
            }
            form__item.InnerHtml = shtml;

            if (Request.Form["btnaddtocart"] != null)
            {
                List<Carts> cart = (List<Carts>)Session["cart"];


                string idadd = Request.Form["btnaddtocart"];
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i].id == idadd)
                    {
                        Carts c = new Carts(arr[i].id, arr[i].img, arr[i].name, 1, arr[i].price, arr[i].detail, arr[i].type);
                        cart.Add(c);
                        break;
                    }
                }
                Session["cart"] = cart;
            }

        }
        //protected void btnXem_click(object sender, EventArgs e)
        //{
        //    List<string> MyList = new List<string>();
        //    List<Products> arr = (List<Products>)Application["product"];
        //    foreach (ListItem item in checkitem.Items)
        //    {
        //        if (item.Selected)
        //        {
        //            foreach(Products p in arr)
        //            {
        //                if (item.Value == p.name)
        //                {
        //                    MyList = new List<string>();
        //                    MyList.Add(p.name);
        //                }
        //            }

        //        }
        //        else
        //        {
        //            Response.Write("<script> var k=confirm('Bạn chưa chọn');" +
        //                "if(k==true)window.location='https://localhost:44368/Product.aspx';</script>");
        //        }
        //    }
        //    if (MyList.Count != 0)
        //    {
        //        string b = "";
        //        for (int i = 0; i < MyList.Count; i++)
        //        {
        //            b+= MyList[i]+",";
        //        }
        //        Response.Redirect("Prodetail.aspx?a1="+b+"");
        //    }
        //}

    }
}