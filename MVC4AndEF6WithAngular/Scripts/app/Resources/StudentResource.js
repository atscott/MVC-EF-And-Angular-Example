angular.module('app')
    .factory('Student', ['$resource',
        function ($resource) {
            'use strict';

            return $resource('/api/student', null,
            {
                get: { method: 'GET', isArray: true }
            });
        }
    ])