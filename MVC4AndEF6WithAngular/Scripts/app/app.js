﻿var app = angular.module('app', ['ngRoute', 'ngResource']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/home', { templateUrl: '/Partials/HomePartial', controller:'StudentController' });
    $routeProvider.when('/students', { templateUrl: '/Partials/StudentPartial' });
    $routeProvider.otherwise({ redirectTo: '/home' });
}])