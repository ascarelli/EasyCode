var Core = function(_firstname, _lastname){
    this.firstname = _firstname;
    this.lastname = _lastname;
};

module.exports = function(firstname, lastname){
    return new Core(firstname, lastname);
   }