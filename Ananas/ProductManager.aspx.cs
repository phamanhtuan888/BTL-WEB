using Ananas.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ananas
{
    public partial class ProductManager : System.Web.UI.Page
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

            List<Products> arrpro = (List<Products>)Application["product"];
            string sHtml = "";
            sHtml += "<table class=\"carts\" id =\"tblcart\">";
            sHtml += "<td> ID </td>";
            sHtml += "<td> Sản phẩm </td>";
            sHtml += "<td> Tên sản phẩm </td>";
            sHtml += "<td> Số lượng </td>";
            sHtml += "<td> Giá tiền </td>";
            sHtml += "<td> Thao tác </td>";

            for (int i = 0; i < arrpro.Count; i++)
            {

                sHtml += "<tr>";
                sHtml += "<td>"+arrpro[i].id+"</td>";
                sHtml += "<td><img src =\"" + arrpro[i].img + "\"/></td>";
                sHtml += "<td><p class=\"namepro\">" + arrpro[i].name + "</p></td>";
                sHtml += "<td>" + arrpro[i].quantity + "</td>";
                sHtml += "<td>" + arrpro[i].price + "</td>";
                sHtml += "<td><button type =\"submit\" value=\"" + arrpro[i].id + "\" name=\"btnSub\"> Xóa </button></td>";
                sHtml += "</tr>";
            }
            sHtml += "</table>";
            ArrPro.InnerHtml = sHtml;

            if (Request.Form["btnSub"] != null)
            {
                string proSub = Request.Form["btnSub"];
                for (int i = 0; i < arrpro.Count; i++)
                {
                    if (arrpro[i].id == proSub)
                    {
                        var pop = arrpro[i];
                        arrpro.Remove(pop);
                        Application["cart"] = arrpro;
                        Response.Redirect("ProductManager.aspx");
                    }
                }
            }
        }

 
        public void btnaddpro_click(object o, EventArgs e)
        {
            List<Products> arrpro = (List<Products>)Application["product"];
            if (Request.Form["Namepro"] != null)
            {
                string id = arrpro.Count().ToString();
                string img = Request.Form["Imgpro"];
                string name = Request.Form["Namepro"];
                string quan = Request.Form["Quanpro"];
                string price = Request.Form["Pricepro"];
                string detail = Request.Form["Detailpro"];
                string type = Request.Form["Typepro"];
                int quantity = int.Parse(quan);
                double pricepro = double.Parse(price);
                string filename = "assets/img/" + img;
                Products pro = new Products(id,filename,name, quantity, pricepro,detail,type);

                bool check = false;
                for (int i = 0; i < arrpro.Count; i++)
                {
                    if (arrpro[i].name == pro.name)
                    {
                        check = true;
                        break;
                    }
                }

                if (check == false)
                {
                    for(int i=0;i<arrpro.Count;i++)
                    {
                        if (arrpro[i].id == pro.id)
                        {
                            int a=arrpro.Count;
                            a++;
                            pro.id = a.ToString();
                        }
                    }
                    arrpro.Add(pro);
                    Application["product"] = arrpro;
                    Response.Redirect("ProductManager.aspx");
                }
                else
                {
                    loipromanager.Text = "Mặt hàng đã tồn tại";
                }
            }
        }
        /*public void btnUpload_Click(object o, EventArgs e)
        {
            if (inputImg.HasFile)
            {
                if (CheckFileType(inputImg.FileName))
                {
                    string fileName = "assets/img/" + inputImg.FileName;
                    string filePath = MapPath(fileName);
                    inputImg.SaveAs(filePath);
                    Img.ImageUrl = fileName;
                }
                else
                {
                    loipromanager.Text = "Chỉ nhận file định dạng ảnh";
                }
            }
        }*/

        /* bool CheckFileType(string fileName)
        {
            string ext = System.IO.Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }
        }*/
    }
}