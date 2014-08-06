var app = angular.module('app', ['ngRoute']);
app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/home', { templateUrl: '/Partials/HomePartial' });
    $routeProvider.when('/students', { templateUrl: '/Partials/StudentPartial' });
    $routeProvider.otherwise({ redirectTo: '/home' });
}])