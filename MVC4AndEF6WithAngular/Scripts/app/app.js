var app = angular.module('app', ['ngRoute', 'ngResource']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/home', { templateUrl: '/Partials/HomePartial' });
    $routeProvider.when('/student/list', { templateUrl: '/Partials/StudentPartial' });
    $routeProvider.when('/student/details/:id', { templateUrl: '/Partials/DetailsPartial' });
    $routeProvider.when('/student/edit/:id', { templateUrl: '/Partials/EditPartial' });
    $routeProvider.when('/student/create', { templateUrl: '/Partials/CreatePartial' });
    $routeProvider.otherwise({ redirectTo: '/home' });
}])