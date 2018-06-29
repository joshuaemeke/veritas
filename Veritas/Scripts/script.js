$("#auth").click(function (event) {
    event.preventDefault();
    $.ajax({
        url: '/api/users/login',
        type: "POST",
        data: $("#reg-form").serialize(),
        success: function (result) {
            console.log(result);
        }
    });
});