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



// Load Charts and the corechart package.
google.charts.load('current', { 'packages': ['corechart'] });

// Draw the pie chart when Charts is loaded.
google.charts.setOnLoadCallback(drawDonutChart);

// Draw the Line chartwhen Charts is loaded.
google.charts.setOnLoadCallback(drawChart);

// Callback that draws the pie chart for Sarah's pizza.
function drawDonutChart() {

    // Create the data table for Sarah's pizza.
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Title');
    data.addColumn('number', 'Distribution');
    data.addRows([
        ['Contribution', 20],
        ['Total Deductions', 11],
        ['Total Withdrawal', 13],
        ['NET Contribution', 9],
        ['Gain/Loss from inception', 6],
        ['Current Value', 12],
        ['No. of units held', 15],
        ['Unit price', 6]
    ]);

    // Set options for  pie chart.
    var options = {
        title: 'Account Distribution',
        pieHole: 0.4,
        width: 500,
        height: 300
    };

    // Instantiate and draw the chart.
    var chart = new google.visualization.PieChart(document.getElementById('donutchart'));
    chart.draw(data, options);
}

// Callback that draws line .
function drawChart() {
    var data = google.visualization.arrayToDataTable([
        ['Month', 'Employee Contribution', 'Employer Contribution'],
        ['Jan', 1000, 400],
        ['Feb', 1170, 460],
        ['Mar', 660, 1120],
        ['Apr', 1030, 540]
    ]);

    var options = {
        title: 'Statistics',
        curveType: 'function',
        width: 480,
        legend: { position: 'bottom' }
    };

    var chart = new google.visualization.LineChart(document.getElementById('curve_chart'));

    chart.draw(data, options);
}

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