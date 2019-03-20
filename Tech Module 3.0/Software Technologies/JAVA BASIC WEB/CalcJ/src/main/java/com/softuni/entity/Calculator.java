package com.softuni.entity;

public class Calculator {

    private Double leftOperand;
    private String operator;
    private Double righOperand;

    public Calculator(Double leftOperand, String operator, Double righOperand) {
        this.leftOperand = leftOperand;
        this.operator = operator;
        this.righOperand = righOperand;
    }

    public Double getLeftOperand() {
        return leftOperand;
    }

    public void setLeftOperand(Double leftOperand) {
        this.leftOperand = leftOperand;
    }

    public String getOperator() {
        return operator;
    }

    public void setOperator(String operator) {
        this.operator = operator;
    }

    public Double getRighOperand() {
        return righOperand;
    }

    public void setRighOperand(Double righOperand) {
        this.righOperand = righOperand;
    }

    public Double calculateResult(){
        double result=0;

        switch (this.operator){
            case "+":
                result= this.leftOperand+this.righOperand;
                break;
            case "-":
                result= this.leftOperand-this.righOperand;
                break;
            case "*":
                result= this.leftOperand*this.righOperand;
                break;
            case "/":
                result= this.leftOperand/this.righOperand;
                break;
            case "^":
                result= Math.pow( this.leftOperand,this.righOperand);
                break;
            case "%":
                result= this.leftOperand%this.righOperand;
                break;
            case "!":
                double sum=1;
                for (int i = 1; i <= this.leftOperand; i++) {
                    sum*=i;
                }
                result= sum;
                break;


        }
        return  result;
    }
}
