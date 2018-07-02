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



$(document).ready(function () {
    $('#characterLeft').text('140 characters left');
    $('#message').keydown(function () {
        var max = 140;
        var len = $(this).val().length;
        if (len >= max) {
            $('#characterLeft').text('You have reached the limit');
            $('#characterLeft').addClass('red');
            $('#btnSubmit').addClass('disabled');
        }
        else {
            var ch = max - len;
            $('#characterLeft').text(ch + ' characters left');
            $('#btnSubmit').removeClass('disabled');
            $('#characterLeft').removeClass('red');
        }
    });
});

