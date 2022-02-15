function sayHi() {
  console.log('hi hi hi')
}

function sayBye() {
  console.log('bye bye bye')
}

module.exports.hi = sayHi
module.exports.bye = sayBye

const yanivTech = require('yanivv77')

yanivTech.hi()
yanivTech.bye()
