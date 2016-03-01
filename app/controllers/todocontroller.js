app.controller("todocontroller", function ($scope, $http) {
    debugger;
    $scope.todos = [];
    $scope.todo = {};
    if (JSON.parse(localStorage.getItem('todos')))
        $scope.todos = JSON.parse(localStorage.getItem('todos'));

    $scope.addtodo = function () {
        debugger;

        $scope.todo.todoid = $scope.todos.length+1;
        $scope.todo.status = "false";
        $scope.todo.synch = "false";
        $scope.todo.duedate = $scope.todo.duedate.toString().substring(0, 16);
        $scope.todos.push($scope.todo);
        localStorage.setItem("todos", angular.toJson($scope.todos));
        $scope.todo = {};
        alert("Todos added to local storage");
    };



    $scope.addcomplete = function (ischecked, todo) {

        debugger;
        $scope.todos[todo.todoid-1].status = ischecked;
        var data = { todoid: "todoid", todoidvalue: todo.todoid, key: "status", value: ischecked };
        $http.post("http://localhost/todoapp/customer/updatetodostatus", data)
                .success(function (res) {

                    localStorage.setItem("todos", angular.toJson($scope.todos));
                    alert("Task Completed");
                })


    };



    $scope.synch = function () {
        debugger;
        var newtodos = [];
        angular.forEach($scope.todos, function (value, key) {

            if (value.synch == "false") {
                value.synch = "true";
                newtodos.push(value);
            }
        });
        if (newtodos.length > 0) {
            var data = { todos: angular.toJson(newtodos) };
            $http.post("http://localhost/todoapp/customer/synch", data)
                .success(function (res) {
                    //debugger;

                    angular.forEach($scope.todos, function (value, key) {
                        value.synch = "true"

                    });
                    localStorage.setItem("todos", angular.toJson($scope.todos));
                    alert("data synch with database");
                })

        } else {
            alert("data allready in synch with database");
        }
    };




    $scope.deletetodo = function (text) {
        debugger;
        var data = { text: text };
        $http.post("http://localhost/todoapp/customer/deletetodo", data)
        .success(function (res) {
            debugger;
            $scope.todos.splice($scope.todos.indexOf(findIndexByKeyValue($scope.todos, "text", text)), 1);
            localStorage.setItem("todos", angular.toJson($scope.todos));

            alert("Todo Deleted!");
        });


    };


    function findIndexByKeyValue(obj, key, value) {
        for (var i = 0; i < obj.length; i++) {
            if (obj[i][key] == value) {
                return i;
            }
        }
        return null;
    }


});