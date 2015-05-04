angular.module("SpeakerApp", [])
    .controller("SpeakerCtrl", function ($scope, $http) {
        $scope.status = "No result yet...";
        $scope.showDetailFor = 0;
        $scope.speakers = [];

        $http.get("/api/speaker").
            success(function (data, status) {
                $scope.status = "Succeeded: " + status;
                $scope.speakers = data;
            }).
            error(function (data, status) {
                $scope.status = "Failed: " + status;
            });

        $scope.showDetail = function(id) {
            $scope.showDetailFor = id;
        };
    });