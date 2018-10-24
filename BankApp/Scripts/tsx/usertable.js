"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
var React = require("../react/react.js");
var ReactDOM = require("../react/react-dom.js");
var UserTable1 = /** @class */ (function (_super) {
    __extends(UserTable1, _super);
    function UserTable1(props) {
        return _super.call(this, props) || this;
    }
    UserTable1.prototype.render = function () {
        return React.createElement("table", null,
            React.createElement("thead", null,
                React.createElement("tr", null,
                    React.createElement("th", null, "First Name"),
                    React.createElement("th", null, "Last Name"),
                    React.createElement("th", null, "Email"))),
            React.createElement("tbody", null));
    };
    return UserTable1;
}(React.Component));
exports.UserTable1 = UserTable1;
function render() {
    ReactDOM.render(React.createElement(UserTable1, null));
}
exports.render = render;
//# sourceMappingURL=usertable.js.map