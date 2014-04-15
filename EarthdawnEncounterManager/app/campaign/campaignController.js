app.controller('campaignController', function ($scope, $resource, $rootScope) {
    var Campaigns = $resource('/api/campaign');

    $scope.toggleAddCampaign = function toggleAddCampaign() {
        $scope.showAddCampaign = true;
    }

    $scope.addCampaign = function addCampaign() {
        var newCampaign = { Id: null, Name: $scope.newCampaignName, GmId: $rootScope.user.Id, DateStarted: new Date() };

        Campaigns.save(newCampaign).$promise.then(function addCampaignSuccessful(result) {
            $rootScope.campaigns.push(result);
            $scope.showAddCampaign = false;
            $scope.newCampaignName = null;
        },
        function addCampaignFailed(result) {
            toastr["error"](result);
        });
    }
});