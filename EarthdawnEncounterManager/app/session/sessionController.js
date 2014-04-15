app.controller('sessionController', function ($scope, $resource, $rootScope) {
    $scope.campaign = null;
    $scope.showAddCampaign = false;
    $scope.newCampaignName = null;

    var Sessions = $resource('/api/session', null, { update: { method: 'PUT' } });

    $scope.addSession = function addSession() {
        if ($scope.campaign == null || $scope.campaign.Id == null)
            return;
        var newSession = { Id: null, StartDate: new Date(), EndDate: null, LegendPoints: null, CampaignId: $scope.campaign.Id };

        Sessions.save(newSession).$promise.then(function addSessionResult (result) {
            $rootScope.sessions.push(result);
        });
    }

    $scope.copySession = function copySession(session) {

    }

    $scope.endSession = function endSession(session) {
        session.EndDate = new Date();
        Sessions.update(session).$promise.then(function updateSessionSuccess(result) {

        },
        function updateSessionFailed(result) {
            sesssion.EndDate = null;
            toastr["error"]("Update for session failed.");
        });
    }
});