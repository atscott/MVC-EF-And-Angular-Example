var app = angular.module('app', ['ngRoute', 'ngResource']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/home', { templateUrl: '/Partials/HomePartial' });
    $routeProvider.when('/students', { templateUrl: '/Partials/StudentPartial' });
    $routeProvider.when('/details/:id', { templateUrl: '/Partials/DetailsPartial' });
    $routeProvider.otherwise({ redirectTo: '/home' });
}])