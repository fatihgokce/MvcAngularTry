var phonecatApp = angular.module('phonecatApp', []);

phonecatApp.controller('PhoneListCtrl', function ($scope, $http) {
    $http.get('Home/JsonR').success(function (data) {
        $scope.phones = data;
    });

    $scope.orderProp = 'age';
});
var reportApp = angular.module('reportApp', []);

reportApp.controller('namesController', function ($scope, $http) {
    //$http.get('Home/JsonR').success(function (data) {
    //    $scope.phones = data;
    //});

    //$scope.orderProp = 'age';
    $scope.names = [
        { name: 'Jani', country: 'Norway' },
        { name: 'Hege', country: 'Sweden' },
        { name: 'Kai', country: 'Denmark' }
    ];
});
