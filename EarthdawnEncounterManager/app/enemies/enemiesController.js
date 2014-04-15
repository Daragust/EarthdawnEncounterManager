app.controller('enemiesController', function ($scope, $resource, $rootScope) {
    $scope.selectedEnemy = null;
    $scope.selectedRow = null;
    $scope.actorInvalid = false;

    var Enemies = $resource('/api/Enemy');

    if ($rootScope.enemies == null || $rootScope.enemies === []) {
        $rootScope.enemies = [];
        
        Enemies.query().$promise.then(function enemiesRecivedResult(result) {
            $rootScope.enemies = result;
        });
    }

    $scope.selectEnemy = function selectEnemy(enemy) {
        $scope.selectedEnemy = angular.copy(enemy);
        $scope.selectedRow = enemy;
    }

    $scope.cancelEdit = function cancelEdit() {
        $scope.selectedEnemy = null;
        $scope.selectedRow = null;
    }

    $scope.saveEdit = function saveEdit() {
        if ($scope.selectedEnemy == null) {
            return;
        }


    }
});