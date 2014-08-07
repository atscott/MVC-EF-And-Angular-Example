angular.module('app')
    .controller('studentController', ['StudentResource',
        function (StudentResource) {
            'use strict';

            $scope.students = StudentResource.get();

        }
    ])