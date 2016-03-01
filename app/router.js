app.config(function ($routeProvider) {
    $routeProvider

            .when('/AddCustomer', {
                templateUrl: '../../todoapp/app/partials/addcustomer.html',
                controller: 'AddCustomerController'
            })

            .when('/AddOrders', {
                templateUrl: '../../todoapp/app/partials/addorders.html',
                controller: 'AddOrdersController'
            });
});
