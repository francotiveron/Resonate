angular.module('Q7App', [])
    .controller('Q7Controller', function ($scope, $http) {
        $scope.surveys = [];
        $scope.curVerb = "";
        $scope.curUser = "";
        $scope.curScore = "";
        $scope.curPage = 0;
        $scope.pageSize = 10;
        $scope.pages = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        function _getPage() {
            $scope.surveys = [];
            $http.get("/api/survey?from=" + $scope.curPage * $scope.pageSize).then(function (data, status, headers, config) {
                $scope.surveys = data.data;
            });
        }
        function setPage(idx) {
            $scope.curVerb = "";
            $scope.curUser = "";
            $scope.curScore = "";
            $scope.curPage = idx;
            _getPage();
        };

        $scope.setItem = function (idx) {
            $scope.curUser = $scope.surveys[idx].user;
            $scope.curScore = $scope.surveys[idx].score;
            $scope.curVerb = $scope.surveys[idx].verbatim;
        };

        $scope.setPage = function (idx) {
            setPage(idx);
        };
        $scope.nextPage = function () {
            setPage(Math.min($scope.curPage + 1, 9));
        };
        $scope.prevPage = function () {
            setPage(Math.max($scope.curPage - 1, 0));
        };
   });