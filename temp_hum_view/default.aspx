<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="default.aspx.vb" Inherits="temp_hum_view._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


    <script src="Scripts/jquery-3.1.1.min.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>

<style type="text/css">

.block 
{
    z-index:9999;
    cursor:move;
}

.productCode 
{
    
}


li
{
    list-style:none;
}

</style>


</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:DataList ID="dlProducts" RepeatDirection="Horizontal" RepeatColumns="3" runat="server">
    <ItemTemplate>
    
    <div class="block" style="width:150px;background-color:lightgreen;padding:10px;margin:10px">
    <ul>
    <li>
    <%# Eval("Name") %>
    </li>

    <li>
     <%# Eval("Description") %>
    </li>

    <li class="productCode">
    <%# Eval("ProductCode") %>
    </li>

    <li>
    $<%# Eval("Price") %></li>

    </ul>

 
    </div>

    </ItemTemplate>
    
    </asp:DataList>

    <div id="shoppingCart" style="width:300px; overflow:auto; height:300px;background-color:yellow;position:absolute;top:100px; left:700px;">
    <div id="header" style="text-align:center"><h3>Shopping Cartg Cart</h3></div>

    <div>
    <ul id="items">
    
    </ul>
    
    </div>

    </div>


    </div>



    </div>
    </form>
</body>
</html>
<script >

    function loadProductsFromUser() {

        var params = new Object();
        params.userName = "azamsharp";

        $.ajax(

        {
            type: "POST",
            data: $.toJSON(params),
            dataType: "json",
            contentType: "application/json",
            url: "AjaxService.asmx/GetProductByUserName",
            success: function (response) {

                var products = $.evalJSON(response.d);

                for (i = 0; i <= products.length; i++) {

                    var list = $("#items");
                    var div = document.createElement("div");
                    div.innerHTML = products[i].ProductCode;


                    // you can store more information about the product in the UserProducts table
                    // and then display it over here! 

                    $(list).append(div);
                }

            }

        });

    }


    $(document).ready(function () {


        // loadProductsFromUser();


        $(".block").draggable({ helper: 'clone' });

        // drag zone 

        $("#shoppingCart").droppable(

        {
            accept: ".block",
            drop: function (ev, ui) {

                var droppedItem = $(ui.draggable).clone();
                $(this).append(droppedItem);

                var productCode = jQuery.trim($(droppedItem).children("ul").children(".productCode").text());

                // ajax request to persist product for the user 

                var params = new Object();
                params.productCode = productCode;
                params.userName = "azamsharp";

                $.ajax(

                {
                    type: "POST",
                    data: $.toJSON(params),
                    contentType: "application/json",
                    url: "AjaxService.asmx/SaveProduct",
                    success: function (response) {

                    }

                });


            }
        }

        );


    });



</script>

