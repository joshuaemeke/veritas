//$("#auth").click(function (event) {
//    event.preventDefault();
//    $.ajax({
//        url: '/home/login',
//        type: "POST",
//        data: $("#reg-form").serialize(),
//        success: function (result) {
//            console.log(result);
//        }
//    });
//});


$("#upPro").click(function (event) {
    event.preventDefault();
    $.ajax({
        url: '/home/UpdateProfile',
        type: "POST",
        data: $("#prof-for").serialize(),
        success: function (result) {
            if (result.success == true) {
                location.reload();
            } else {
                alert("Something went wrong");
                location.reload();
            }
        }
    });
});