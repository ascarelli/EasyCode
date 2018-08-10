var Core = function(){
};

Core.prototype.deserialize = function (prPath)
{
    var fs = require("fs");
    
    var fileContents;
    try {
      fileContents = fs.readFileSync(prPath);
    } catch (err) {
        return console.log("Erro ao ler arquivo: " + err);
    }

    var jsonData = JSON.parse(fileContents); 
    return jsonData;
}

module.exports = function(){
 return new Core();
}

