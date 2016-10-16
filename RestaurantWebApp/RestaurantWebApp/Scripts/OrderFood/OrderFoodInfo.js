$(document).ready(function () {
    //your code here

    $("#CodeId").change(function () {
        //Get Selected User Id
        var id = $("#CodeId").val();
        var jsonData = { id: id };

        $.ajax({
            type: "POST",
            url: "../Order/GetUserById",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(jsonData),
            success: function (data) {
                $("#Name").val(data.Name);
                $("#Email").val(data.Email);
                $("#ContactNo").val(data.ContactNo);
                $("#Type").val(data.Type);
            }
        });

    });
});


$(document).ready(function () {
    //your code here

    $("#FoodNameId").change(function () {
        //Get Selected User Id
        var id = $("#FoodNameId").val();
        var jsonData1 = { id: id };

        $.ajax({
            type: "POST",
            url: "../Order/GetFoodById",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(jsonData1),
            success: function (data) {
                $("#UnitPrice").val(data.UnitPrice);
            }
        });

    });
});



$(document).ready(function () {
    //your code here

    $("#show").click(function () {
        //Get Selected User Id
        var id = $("#CodeId").val();
        var date = $("#PickDate").val();
        var jsonData1 = { id: id, aDateTime: date};

        $.ajax({
            type: "POST",
            url: "../ViewReport/GetFoodOrderByUserDate",
            contentType: "application/json; charset=utf-8",
            data: JSON.stringify(jsonData1),
            success: function(data) {


                $("#TotalAmount").val(data.Sum);

                //$("#providersFormElementsTable").html("<tr><td>Nickname</td><td><input type='text' id='nickname' name='nickname'></td></tr><tr><td>CA Number</td><td><input type='text' id='account' name='account'></td></tr>");
                var tableMarkup = "<thead><tr><th>Name</th><th>UnitPrice</th><th>Quantity</th></tr></thead>";
                tableMarkup += "<tbody>";
                $.each(data.OrderList, function (i, val) {
                    tableMarkup += "<tr><td>" + val.Name + "</td><td>" + val.UnitPrice + "</td><td>" + val.Quantity + "</td></tr>";
                });
                tableMarkup += "</tbody>";
                $("#tblOrderList").html(tableMarkup);
            },
            error: function(err) {
                var v = err;
            }
        });

    });
});

