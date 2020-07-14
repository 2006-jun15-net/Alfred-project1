 
    $(document).ready(function () {
        $("#Product").val(0);
        $("#Product").change(function () {
            var ProdId = $("#Product").val();
            GetPrice(ProdId);

        });

        $("input[type=text]").change(function () {
            GetAmount();
        });

        $("#btnAddToCart").click(function () {
            AddToShoppingCart();

        });

        $("#btnPayment").click(function () {
            placeOrder();

        });


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

    items.append(productList); //add the itms in the cart
    GetFinalAmount(); //gets the total amount of all the products in the cart
    reset(); //reset the price, quantity, product id and the total amount.

}

function RemoveProduct(ProdId) {
    $(ProdId).closest('tr').remove();
    GetFinalAmount() - GetAmount;

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

function GetFinalAmount(){
    $("#txtFinalAmount").val("0.00");
    var finalTotal = 0.00;
    $("#tblProductItems").find("tr:gt(0)").each(function () {
        var total = parseFloat($(this).find("td:eq(4)").text());
        finalTotal += total;
        

    });

    $("#txtFinalAmount").val(finalTotal);
    $("#txtTotalAmount").val(finalTotal);


    
    

}


//This function places the order
function placeOrder() {
    var orderViewModel = {};
    orderViewModel.CustomerId = $("#Customer").val();
    orderViewModel.FinalAmount = $("#txtFinalAmount").val();

    //a list of orders
    var orderDetailViewModels = new Array();

    $("#tblProductItems").find("tr:gt(0)").each(function () {
        var OrderDetailViewModel = {};
        OrderDetailViewModel.TotalCost = parseFloat($(this).find("td:eq(4)").text());
        OrderDetailViewModel.Qty = parseFloat($(this).find("td:eq(3)").text());
        OrderDetailViewModel.UnitPrice = parseFloat($(this).find("td:eq(2)").text());
        OrderDetailViewModel.ProdId = parseFloat($(this).find("td:eq(0)").text());

        //inserting the order details in the orderDetailViewModel list
        orderDetailViewModels.push(OrderDetailViewModel);

    });

    //assigning the newly created orderDetail list to the list in the OrderViewModel

    orderViewModel.orderDetailViewModels = orderDetailViewModels;


    //sending the data to the server
    $.ajax({

        async: true,
        type: 'POST',
        dataType: 'JSON',
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify(orderViewModel), //converts the object to a strings
        url: '/Shop/Index',
        success: function (data) {
            alert(data)


        },
        error: function () {
            alert("Something wrong with the data");
        }

    })




}





