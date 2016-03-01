app.controller("logincontroller", function ($scope, $http, $location) {


    $scope.login = function () {
        //        debugger;

        //        var data = { userid: $scope.user.username, password: $scope.user.password };
        //        $http.post("http://localhost/todoapp/login/login", data)
        //        .success(function (res) {
        //            if (!res)
        //                alert("Please enter correct Login Pass");

        //        })


        $http({
            method: 'post',
            url: 'http://localhost/todoapp/login/login',
            data: { userid: $scope.user.username, password: $scope.user.password }
        }).then(function successCallback(response) {
            console.log(response);
            if (response.data == "True") {
                window.location.replace("http://localhost/TodoApp/Customer");
            }
            else {
                alert("invalid");
            }
            // this callback will be called asynchronously
            // when the response is available
            if (!response)
                alert("Please enter correct Login Pass");
        }, function errorCallback(response) {
            // called asynchronously if an error occurs
            // or server returns response with an error status.
        });


    }







});