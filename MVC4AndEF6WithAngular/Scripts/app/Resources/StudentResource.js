angular.module('app').factory('Student', ['$resource',
    function ($resource) {
        'use strict';

        return $resource('/api/students/:id', { actionParam: '@id' },
        {
            get: { method: 'GET', isArray: true },
            getById: { method: 'GET' }
        });
    }
])