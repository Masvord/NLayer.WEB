//It's a JavaScript code that dynamically fetches the product list and filters it by categories

$(document).ready(function () {
    GetProducts(); 
    GetCategories();
});

function GetProductsByCategoryId(id) {
    var tbody = document.getElementById('products');
    tbody.innerHTML = "";
    const url = "/getproductsbycategoryid/";
    $.get(`${url}${id}`, function (data) {
        $.each(data, function (index, value) {
            $("#products").append(`
                <tr>
                    <td>${value.name}</td>
                    <td>${value.quantity}</td>
                    <td>${value.price}</td>
                </tr>
            `);
        });
    });
}


function GetCategories() {
    $.get("/getallcategories", function (data) {
        $.each(data, function (index, value) {
            $("#side-menu").append(`
                  <li onclick="GetProductsByCategoryId(${value.id})">
                        ${value.name}
                  </li>
           `);
        });
    });
}


function GetProducts() {
    var tbody = document.getElementById('products')
    tbody.innerHTML = "";
    $.get("/getallproducts", function (data) {
        $.each(data, function (index, value) {
            $("#products").append(`
                       <tr>
                           <td>${value.name}</td>
                           <td>${value.quantity}</td>
                           <td>${value.price}</td>
                       </tr>
            `);
        });
    });
}
