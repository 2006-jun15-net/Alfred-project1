 
    $(document).ready(function () {
        $("#Product").val(0);
        $("#Product").change(function () {
            var ProdId = $("#Product").val();
            GetPrice(ProdId);

        });

        $("input[type=text]").change(function () {
            GetAmount();
        })

        $("#btnAddToCart").click(function () {
            AddToShoppingCart();

        })


    });

function AddToShoppingCart() {
    var items = $("#tblProductItems");
    var Price = $("#txtPrice").val();
    var Quantity = $("#Quantity").val();
    var productId = $("#Product").val();
    var productName = $("#Product option:selected").text();
    var total = Price * Quantity;

    var productList = "<tr><td hidden>" +
        productId +
        "</td><td>" +
        productName +
        "</td><td>" +
        Price +
        "</td><td>" +
        Quantity +
        "</t><td>" +
        total +
        "</td><td> <input type='button' value='Remove' name='remove' class='btn btn-danger' onclick='RemoveProduct(this)'/> </tr></tr>";

    items.append(productList);
    reset(); //reset the price, quantity, product id and the total amount.

}

function RemoveProduct(ProdId) {
    $(ProdId).closest('tr').remove();

}


function reset() {
    $("#txtPrice").val('');
    $("#Quantity").val('');
    $("#Product").val(0);
    $("#txtTotal").val('');

}


function GetPrice(ProdId) {
        $.ajax({
            async: true,
            type: 'GET',
            dataType: 'JSON',
            contentType: 'application/json; charset=utf-8',
            data: { ProdId: ProdId },
            url: '/Shop/GetPrice',
               success: function (data) {
                   $("#txtPrice").val(parseFloat(data).toFixed(2));

               },
               error: function () {
                    alert("An error with the unit price");
               }
        })
}

function GetAmount() {
    var Price = $("#txtPrice").val();
    var Quantity = $("#Quantity").val();

    var total = Price * Quantity;
    $("#txtTotal").val(parseFloat(total).toFixed(2));


}



