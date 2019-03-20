const Calculator = require('../models/Calculator')

module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    },
    indexPost: (req, res) => {
        let reqBody = req.body;

        let  calcBody = reqBody['calculator'];

        let calculator = new Calculator();
        calculator.leftOperand = Number(calcBody.leftOperand);
        calculator.operator = calcBody.operator;
        calculator.rightOperand = Number(calcBody.rightOperand);

        let result=calculator.calculateResult();

        res.render('home/index', {'calculator':calculator,'result':result})
    }
};