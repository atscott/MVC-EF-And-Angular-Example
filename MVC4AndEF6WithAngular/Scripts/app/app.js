var app = angular.module('app', ['ngRoute']);
app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/home', { templateUrl: '/Partials/HomePartial' });
    $routeProvider.otherwise({ redirectTo: '/home' });
}])