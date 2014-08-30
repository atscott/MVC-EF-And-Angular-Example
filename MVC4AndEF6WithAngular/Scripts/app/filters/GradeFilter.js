angular.module('app').filter('GradeFilter', [
    function () {
        return function (grade) {
            if (grade === 0) return 'A';
            if (grade === 1) return 'B';
            if (grade === 2) return 'C';
            if (grade === 3) return 'D';
            if (grade === 4) return 'F';
            return 'N/A';
        }
    }
]);
