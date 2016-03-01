app.factory("customerservice", function () {

    var products = [
                    { name: "boot", color: "red" },
                    { name: "tshirt", color: "blue" }
              ];

//        var products = [
//                        "boot", 
//                         "tshirt"
//                  ];
    return {

        getproducts: function () {

            return products;
        }

    };








});