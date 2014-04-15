app.controller('loginController', function ($rootScope, $scope, $resource, $location) {
    $scope.userName = null;
    $scope.errorMessage = null;

    var LoginApi = $resource('api/player/');

    $scope.disableLogin = function disableLogin() {
        return $scope.username == null || $scope.userName.length < 2
    }

    $scope.login = function login() {
        LoginApi.get({ userName: $scope.userName }).$promise.then(
            function (result) {
                $rootScope.user = result;
                $location.path('/home');
            },
            function (result) {

                toastr["error"]("Invalid User Name.")
            },
            function (result) {

            }
        );
    }
});