app.controller('AddCustomerController', function ($scope, $http, $location, customerservice) {

   


    $scope.addcustomer = function (Isvalid) {
        debugger
        if (Isvalid) {
            var data = { customer: JSON.stringify($scope.customer) }
            $http.post("http://localhost/todoapp/CustomerOrder/addcustomer", data)
        .success(function (res) {
            localStorage.setItem("objectid", res);
            alert("customer saved Successfully");
        })


        }
        else {

            alert("Enter * marked fileds correctly");

        }
    };




    $scope.next = function () {

        $location.url("/AddOrders");
    };





});