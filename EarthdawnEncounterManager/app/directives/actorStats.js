app.directive('actorStats', function () {
    return {
        restrict: 'E',
        scope: {
            actor: '=actor',
            formInvalid: '=formInvalid'
        },
        templateUrl: '/app/directives/actorStatsPartial.html',
        link: function (scope, elem, attrs) {
            elem.bind('keyup', function () {
                scope.formInvalid = scope.defensesForm.$invalid || scope.attributesForm.$invalid //check validity

            })
        }
    };
});