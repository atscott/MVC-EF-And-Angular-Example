angular.module('app').controller('StudentCtrl', ['$scope', 'Student',
    function ($scope, Student) {
        $scope.students = Student.get();
    }])