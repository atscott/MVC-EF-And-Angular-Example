angular.module('app').controller('DetailsCtrl', ['$scope', 'Student', '$routeParams',
    function ($scope, Student, $routeParams) {
        $scope.student = Student.getById({id: $routeParams.id});
    }])
