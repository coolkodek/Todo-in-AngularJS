app.controller('AddOrdersController', function ($scope, $http, $location, customerservice) {
    debugger;

    $scope.products = customerservice.getproducts();
    $scope.customer = {
        orders: []
    };
    $scope.addorders = function (Isvalid) {
       
        debugger
        if (Isvalid) {
            var data = { customer: angular.toJson($scope.customer.orders), objectid: localStorage.getItem("objectid") };
            $http.post("http://localhost/todoapp/CustomerOrder/addorder", data)
        .success(function (res) {

            alert("Ordedr saved Successfully");
        })


        }
        else {

            alert("Enter * marked fileds correctly");

        }


    };


















});