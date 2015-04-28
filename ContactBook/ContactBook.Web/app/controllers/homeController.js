'use strict';

cbControllers.controller("homeController", 
['$scope', '$location', 'authenticationSvc',
    function($scope, $location, authenticationSvc) {
        $scope.mainLogout = function() {
            authenticationSvc.logout();
        };
    }
]);