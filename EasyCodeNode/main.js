var Core = require("./Core/Core")();
var solution = Core.deserialize("./solution.json").person;
console.log(solution.firstname);