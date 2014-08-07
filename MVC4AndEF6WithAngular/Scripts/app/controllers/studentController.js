angular.module('app')
    .controller('StudentController', ['$scope', 'Student',
        function ($scope, Student) {
            $scope.students = Student.get();
        }])