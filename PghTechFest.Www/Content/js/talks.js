angular.module("TalkApp", [])
    .controller("TalkCtrl", function ($scope, $http) {
        $scope.status = "No result yet...";
        $scope.showDetailFor = 0;
        $scope.talks = [];

        $http.get("/api/schedule").
            success(function (data, status) {
                $scope.status = "Succeeded: " + status;
                $scope.talks = data;
            }).
            error(function (data, status) {
                $scope.status = "Failed: " + status;
            });

        $scope.showDetail = function(id) {
            $scope.showDetailFor = id;
        };
    });