// Install the angularjs.TypeScript.DefinitelyTyped NuGet package
module App {
    "use strict";

    interface IMyAppDirective extends angular.IDirective {
    }

    interface IMyAppDirectiveScope extends angular.IScope {
    }

    interface IMyAppDirectiveAttributes extends angular.IAttributes {
    }

    MyAppDirective.$inject = ["$window"];
    function MyAppDirective($window: angular.IWindowService): IMyAppDirective {
        return {
            restrict: "EA",
            link: link,
            templateUrl: "/Scripts/App/my-app.html",
            controller: MyAppController,
            controllerAs: "vm"
        }

        function link(scope: IMyAppDirectiveScope, element: angular.IAugmentedJQuery, attrs: IMyAppDirectiveAttributes) {

        }
    }

    angular.module("app").directive("myApp", MyAppDirective);
}