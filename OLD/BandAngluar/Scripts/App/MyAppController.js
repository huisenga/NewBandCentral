var App;
(function (App) {
    "use strict";
    var MyAppController = (function () {
        function MyAppController($http, $window) {
            this.$http = $http;
            this.$window = $window;
            this.errorMessage = "";
            this.isVisibleErrorMessage = false;
            this.values = [];
            this.getValues();
        }
        MyAppController.prototype.getValues = function () {
            var _this = this;
            this.$http.get("/api/sample")
                .then(function (response) {
                _this.isVisibleErrorMessage = false;
                _this.values = response.data;
            })
                .catch((function (reason) {
                _this.isVisibleErrorMessage = true;
                _this.errorMessage = reason.statusText;
            }));
            return this.values;
        };
        ;
        MyAppController.$inject = ["$http", "$window"];
        return MyAppController;
    }());
    App.MyAppController = MyAppController;
})(App || (App = {}));
angular.module("app").controller("MyAppController", MyAppController);
