//khai báo biến slideIndex đại diện cho slide hiện tại
var slideIndex = 0;
// KHai bào hàm hiển thị slide
function showSlides() {
    var slides = document.getElementsByClassName("container__slideshow--item");
    var dots = document.getElementsByClassName("dot");
    for (var i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (var i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }

    slides[slideIndex].style.display = "block";
    dots[slideIndex].className += " active";
    //chuyển đến slide tiếp theo
    slideIndex++;
    //nếu đang ở slide cuối cùng thì chuyển về slide đầu
    if (slideIndex > slides.length - 1) {
        slideIndex = 0
    }
    //tự động chuyển đổi slide sau 5s
    setTimeout(showSlides, 5000);
}
//mặc định hiển thị slide đầu tiên 
showSlides(slideIndex = 0);

function currentSlide(n) {
    showSlides(slideIndex = n);
}
function checkpassnumber(password) {
    if (password.match(/(?=.*\d)/)) {
        return true;
    }
    else {
        return false;
    }
}
function checkpassuppercase(password) {
    if (password.match(/(?=.*[A-Z])/)) {
        return true;
    }
    else {
        return false;
    }
}

function checkregister() {
    var name = document.getElementById("NameRegister").value;
    var email = document.getElementById("EmailRegister").value;
    var pass = document.getElementById("PasswordRegister").value;
    var repass = document.getElementById("Re-PasswordRegister").value;
    var loi = document.getElementById("Maincontents_loidangky");

    if (name.trim().length == 0) {
        loi.innerHTML = "Tên không được để trống.";
        return false;
    } else if (email.trim().length == 0) {
        loi.innerHTML = "Email không được để trống.";
        return false;
    } else if (pass.trim().length == 0) {
        loi.innerHTML = "Mật khẩu không được để trống.";
        return false;
    } else if (pass != repass) {
        loi.innerHTML = "Mật khẩu xác nhận không trùng";
        return false;
    } else if (pass.length < 8) {
        loi.innerHTML = "Mật khẩu cần có tối thiểu 8 ký tự";
        return false;
    }
    else if (!checkpassnumber(pass)) {
        loi.innerHTML = "Mật khẩu cần có 1 ký tự số.";
        return false;
    }
    else if (!checkpassuppercase(pass)) {
        loi.innerHTML = "Mật khẩu cần có 1 chữ hoa.";
        return false;
    }
    else {
        return true;
    }
}
/*
 *
function checkinfo() {
    var loi = 0;
    var name = document.getElementById("NameInfo").value;
    var email = document.getElementById("EmailInfo").value;
    var pass = document.getElementById("PasswordInfo").value;
    var loi = document.getElementById("Maincontents_loidangky");
    if (name.trim().length == 0) {
        loi.innerHTML = "Tên không được để trống.";
        return false;
    } else if (email.trim().length == 0) {
        loi.innerHTML = "Email không được để trống.";
        return false;
    } else if (pass.trim().length == 0) {
        loi.innerHTML = "Pass không được để trống.";
        return false;
    } else if (pass.length < 4) {
        loi.innerHTML = "Mật khẩu phải có 4 ký tự trở lên";
        return false;
    } else {
        return true;
    }
}*/

/*
function showpassregister(){
    var check = true;
    if (check) {
        document.getElementById("PasswordRegister").type = "text";
        document.getElementById("Re-PasswordRegister").type = "text";
        check = false;
    } else {
        document.getElementById("PasswordRegister").type = "password";
        document.getElementById("Re-PasswordRegister").type = "password";
        check = true;
    }
}*/