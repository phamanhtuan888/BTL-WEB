using Ananas.App_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Ananas
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["user"] = new List<User>();
            Application["product"] = new List<Products>();
            List<User> users = new List<User>();
            users.Add(new User() {name ="admin", email = "admin@gmail.com", password = "admin", repassword = "admin" });
            users.Add(new User() {name = "han", email = "han@gmail.com", password = "12345", repassword = "12345" });
            Application["user"] = users;

                
            /*Products(string id, string img, string name, string quantity, string price, string detail, string type)*/
            List<Products> arr = new List<Products>();

            /*Basas*/
            arr.Add(new Products() { id = "1", img = "assets/img/Products/ProB1.jpg", name= "Basas Bumper Gum EXT NE-Low Top", quantity = 10 ,price = 580000, detail = "Bumper Gum EXT (Extension) NE là bản nâng cấp được xếp vào dòng sản phẩm Basas, nhưng lại gây ấn tượng với diện mạo phá đi sự an toàn thường thấy. Với cách sắp xếp logo hoán đổi đầy ý tứ và mảng miếng da lộn (Suede) xuất hiện hợp lí trên chất vải canvas NE bền bỉ dày dặn nhấn nhá thêm bằng những sắc Gum dẻo dai. Tất cả làm nên 01 bộ sản phẩm với thiết kế đầy thoải mái trong trải nghiệm, đủ thanh lịch trong dáng vẻ.", type = "1" });
            arr.Add(new Products() { id = "2", img = "assets/img/Products/ProB2.jpg", name = "Basas Bumper Gum EXT NE-High Top", quantity = 10, price = 650000, detail = "Bumper Gum EXT (Extension) NE là bản nâng cấp được xếp vào dòng sản phẩm Basas, nhưng lại gây ấn tượng với diện mạo phá đi sự an toàn thường thấy. Với cách sắp xếp logo hoán đổi đầy ý tứ và mảng miếng da lộn (Suede) xuất hiện hợp lí trên chất vải canvas NE bền bỉ dày dặn nhấn nhá thêm bằng những sắc Gum dẻo dai. Tất cả làm nên 01 bộ sản phẩm với thiết kế đầy thoải mái trong trải nghiệm, đủ thanh lịch trong dáng vẻ.", type = "1" });
            arr.Add(new Products() { id = "3", img = "assets/img/Products/ProB3.jpg", name = "Basas Bumper Gum EXT NE-Low Top", quantity = 10, price = 580000, detail = "Bumper Gum EXT (Extension) NE là bản nâng cấp được xếp vào dòng sản phẩm Basas, nhưng lại gây ấn tượng với diện mạo phá đi sự an toàn thường thấy. Với cách sắp xếp logo hoán đổi đầy ý tứ và mảng miếng da lộn (Suede) xuất hiện hợp lí trên chất vải canvas NE bền bỉ dày dặn nhấn nhá thêm bằng những sắc Gum dẻo dai. Tất cả làm nên 01 bộ sản phẩm với thiết kế đầy thoải mái trong trải nghiệm, đủ thanh lịch trong dáng vẻ.", type = "1" });
            arr.Add(new Products() { id = "4", img = "assets/img/Products/ProB4.jpg", name = "Basas Bumper Gum NE-Mule", quantity = 10, price = 520000, detail = "Kết hợp thiết kế hở gót cùng quai dán, Basas Bumper Gum NE - Mule mang lại trải nghiệm tiện lợi tăng cấp so với phiên bản thắt dây truyền thống. Lên chân nhanh chóng trong tích tắc không cần chạm tay nhưng vẫn sở hữu diện mạo đầy tính thanh lịch, Basas Bumper Gum NE - Mule chính là lựa chọn toàn diện cho mọi dịp dạo chơi từ nhà ra phố của các tín đồ thời trang trẻ.", type = "1" });
            
            /*Vintas*/
            arr.Add(new Products() { id = "5", img = "assets/img/Products/ProV1.jpeg", name = "Vintas Aunter-Low Top", quantity = 10, price = 580000, detail = "Bumper Gum EXT (Extension) NE là bản nâng cấp được xếp vào dòng sản phẩm Basas, nhưng lại gây ấn tượng với diện mạo phá đi sự an toàn thường thấy. Với cách sắp xếp logo hoán đổi đầy ý tứ và mảng miếng da lộn (Suede) xuất hiện hợp lí trên chất vải canvas NE bền bỉ dày dặn nhấn nhá thêm bằng những sắc Gum dẻo dai. Tất cả làm nên 01 bộ sản phẩm với thiết kế đầy thoải mái trong trải nghiệm, đủ thanh lịch trong dáng vẻ.", type = "2" });
            arr.Add(new Products() { id = "6", img = "assets/img/Products/ProV2.jpeg", name = "Vintas Aunter-Low Top", quantity = 10, price = 650000, detail = "Bumper Gum EXT (Extension) NE là bản nâng cấp được xếp vào dòng sản phẩm Basas, nhưng lại gây ấn tượng với diện mạo phá đi sự an toàn thường thấy. Với cách sắp xếp logo hoán đổi đầy ý tứ và mảng miếng da lộn (Suede) xuất hiện hợp lí trên chất vải canvas NE bền bỉ dày dặn nhấn nhá thêm bằng những sắc Gum dẻo dai. Tất cả làm nên 01 bộ sản phẩm với thiết kế đầy thoải mái trong trải nghiệm, đủ thanh lịch trong dáng vẻ.", type = "2" });
            arr.Add(new Products() { id = "7", img = "assets/img/Products/ProV3.jpeg", name = "Vintas Aunter-Low Top", quantity = 10, price = 580000, detail = "Bumper Gum EXT (Extension) NE là bản nâng cấp được xếp vào dòng sản phẩm Basas, nhưng lại gây ấn tượng với diện mạo phá đi sự an toàn thường thấy. Với cách sắp xếp logo hoán đổi đầy ý tứ và mảng miếng da lộn (Suede) xuất hiện hợp lí trên chất vải canvas NE bền bỉ dày dặn nhấn nhá thêm bằng những sắc Gum dẻo dai. Tất cả làm nên 01 bộ sản phẩm với thiết kế đầy thoải mái trong trải nghiệm, đủ thanh lịch trong dáng vẻ.", type = "2" });
            arr.Add(new Products() { id = "8", img = "assets/img/Products/ProV4.jpeg", name = "Vintas Monoguso-Low Top", quantity = 10, price = 520000, detail = "Kết hợp thiết kế hở gót cùng quai dán, Basas Bumper Gum NE - Mule mang lại trải nghiệm tiện lợi tăng cấp so với phiên bản thắt dây truyền thống. Lên chân nhanh chóng trong tích tắc không cần chạm tay nhưng vẫn sở hữu diện mạo đầy tính thanh lịch, Basas Bumper Gum NE - Mule chính là lựa chọn toàn diện cho mọi dịp dạo chơi từ nhà ra phố của các tín đồ thời trang trẻ.", type = "2" });

            /*Urbas*/
            arr.Add(new Products() { id = "9", img = "assets/img/Products/ProU1.jpg", name = "Urbas Irrelevant-Low Top", quantity = 10, price = 580000, detail = "Bumper Gum EXT (Extension) NE là bản nâng cấp được xếp vào dòng sản phẩm Basas, nhưng lại gây ấn tượng với diện mạo phá đi sự an toàn thường thấy. Với cách sắp xếp logo hoán đổi đầy ý tứ và mảng miếng da lộn (Suede) xuất hiện hợp lí trên chất vải canvas NE bền bỉ dày dặn nhấn nhá thêm bằng những sắc Gum dẻo dai. Tất cả làm nên 01 bộ sản phẩm với thiết kế đầy thoải mái trong trải nghiệm, đủ thanh lịch trong dáng vẻ.", type = "3" });
            arr.Add(new Products() { id = "10", img = "assets/img/Products/ProU2.jpg", name = "Urbas Corluray-Low Top", quantity = 10, price = 650000, detail = "Bumper Gum EXT (Extension) NE là bản nâng cấp được xếp vào dòng sản phẩm Basas, nhưng lại gây ấn tượng với diện mạo phá đi sự an toàn thường thấy. Với cách sắp xếp logo hoán đổi đầy ý tứ và mảng miếng da lộn (Suede) xuất hiện hợp lí trên chất vải canvas NE bền bỉ dày dặn nhấn nhá thêm bằng những sắc Gum dẻo dai. Tất cả làm nên 01 bộ sản phẩm với thiết kế đầy thoải mái trong trải nghiệm, đủ thanh lịch trong dáng vẻ.", type = "3" });
            arr.Add(new Products() { id = "11", img = "assets/img/Products/ProU3.jpg", name = "Urbas Pineapple or Ananas-Low Top", quantity = 10, price =580000, detail = "Bumper Gum EXT (Extension) NE là bản nâng cấp được xếp vào dòng sản phẩm Basas, nhưng lại gây ấn tượng với diện mạo phá đi sự an toàn thường thấy. Với cách sắp xếp logo hoán đổi đầy ý tứ và mảng miếng da lộn (Suede) xuất hiện hợp lí trên chất vải canvas NE bền bỉ dày dặn nhấn nhá thêm bằng những sắc Gum dẻo dai. Tất cả làm nên 01 bộ sản phẩm với thiết kế đầy thoải mái trong trải nghiệm, đủ thanh lịch trong dáng vẻ.", type = "3" });
            arr.Add(new Products() { id = "12", img = "assets/img/Products/ProU4.jpg", name = "Urbas Corluray-High Top", quantity = 10, price = 520000, detail = "Kết hợp thiết kế hở gót cùng quai dán, Basas Bumper Gum NE - Mule mang lại trải nghiệm tiện lợi tăng cấp so với phiên bản thắt dây truyền thống. Lên chân nhanh chóng trong tích tắc không cần chạm tay nhưng vẫn sở hữu diện mạo đầy tính thanh lịch, Basas Bumper Gum NE - Mule chính là lựa chọn toàn diện cho mọi dịp dạo chơi từ nhà ra phố của các tín đồ thời trang trẻ.", type = "3" });
            
            
            Application["product"] = arr;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["login"] = 0;
            Session["name"] = "";
            Session["email"] = "";
            Session["cart"] = new List<Carts>();
            Session["loidangky"] = 0;
            Session["loidangnhap"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}