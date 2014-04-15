var app = angular.module('EarthdawnEncounterManager', ['ngRoute', 'ngResource', 'ui.bootstrap']);
app.config(function ($routeProvider) {
    $routeProvider.when("/home", {
        controller: "homeController",
        templateUrl: "/app/home/homeView.html"
    })
    .when("/session", {
        controller: "sessionController",
        templateUrl: "/app/session/sessionView.html"
    })
    .when("/enemies", {
        controller: "enemiesController",
        templateUrl: "/app/enemies/enemiesView.html"
    })
    .when("/login", {
        controller: "loginController",
        templateUrl: "/app/login/loginView.html"
    });
    $routeProvider.otherwise({ redirectTo: "/home" });

}).run(function ($rootScope, $location, $resource, $templateCache) {

    toastr.options = {
        "closeButton": false,
        "debug": false,
        "positionClass": "toast-top-full-width",
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }

    //$rootScope.$watch(function () { return $location.path(); }, function (newValue, oldValue) {
    //    if ($rootScope.user == null && newValue != '/login') {
    //        $location.path('/login');
    //    }
    //});

    $rootScope.user = { Id: 1, UserName: 'Daragust', FirstName: 'Aaron', LastName: 'Wallestad', IsGM: true };
    $rootScope.campaign = null;
    $rootScope.campaigns = [];

    var Campaigns = $resource('/api/campaign');
    var Sessions = $resource('/api/session', null, { update: { method: 'PUT' } });

    Campaigns.query().$promise.then(function getCampaignsResult(result) {
        $rootScope.campaigns = result;

        if ($rootScope.campaigns != null && $rootScope.campaigns.length > 0)
            $rootScope.campaign = $rootScope.campaigns[0];

        Sessions.query().$promise.then(function getSessionsResult(result) {
            $rootScope.sessions = result;
        });
    });
});