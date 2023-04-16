const { MathUtils, obj, sayHelloWorld } = require("../index");

describe("MathUtils", function() {
  
    var mathUtils;
    
    beforeEach(function() {
      mathUtils = new MathUtils();
    });
    
    describe("sum", function() {
      
      it("should return 2 for 1 + 1", function() {
        expect(mathUtils.sum(1, 1)).toEqual(2);
      });
      
      it("should return -4 for -2 + -2", function() {
        expect(mathUtils.sum(-2, -2)).toEqual(-4);
      });
      
    });
    
    describe("substract", function() {
      
      it("should return 0 for 1 - 1", function() {
        expect(mathUtils.substract(1, 1)).toEqual(0);
      });
      
      it("should return -2 for -1 - 1", function() {
        expect(mathUtils.substract(-1, 1)).toEqual(-2);
      });
      
    });
    
    describe("multiply", function() {
      
      it("should return 6 for 2 * 3", function() {
        expect(mathUtils.multiply(2, 3)).toEqual(6);
      });
      
      it("should return -8 for -2 * 4", function() {
        expect(mathUtils.multiply(-2, 4)).toEqual(-8);
      });
      
    });
    
    describe("divide", function() {
      
      it("should return 1 for 2 / 2", function() {
        expect(mathUtils.divide(2, 2)).toEqual(1);
      });
      
      it("should return -2 for 4 / -2", function() {
        expect(mathUtils.divide(4, -2)).toEqual(-2);
      });
      
      it("should throw an error for division by 0", function() {
        expect(function() { mathUtils.divide(1, 0); }).toThrow(new Error("Cannot divide by zero"));
      });
      
    });
    
    describe("average", function() {
      
      it("should return 2 for 1 and 3", function() {
        expect(mathUtils.average(1, 3)).toEqual(2);
      });
      
      it("should return -0.5 for -1 and 0", function() {
        expect(mathUtils.average(-1, 0)).toEqual(-0.5);
      });
      
    });
    
  });
  
describe("MathUtils.prototype.factorial", function() {
  
    beforeEach(function() {
      mathUtils = new MathUtils();
    });
    
    it("should return 1 for 0", function() {
      expect(mathUtils.factorial(0)).toEqual(1);
    });
    
    it("should return 1 for 1", function() {
      expect(mathUtils.factorial(1)).toEqual(1);
    });
    
    it("should return 2 for 2", function() {
      expect(mathUtils.factorial(2)).toEqual(2);
    });
    
    it("should return 6 for 3", function() {
      expect(mathUtils.factorial(3)).toEqual(6);
    });
    
    it("should throw an error for negative numbers", function() {
      expect(function() { mathUtils.factorial(-1); }).toThrow(new Error("There is no factorial for negative numbers"));
    });
    
  });
  

describe("MathUtils factorial", function() {
  
    beforeEach(function() {
      mathUtils = new MathUtils();
    });
    
    it("should return 1 for 0", function() {
      expect(mathUtils.factorial(0)).toEqual(1);
    });
    
    it("should return 1 for 1", function() {
      expect(mathUtils.factorial(1)).toEqual(1);
    });
    
    it("should return 2 for 2", function() {
      expect(mathUtils.factorial(2)).toEqual(2);
    });
    
    it("should return 6 for 3", function() {
      expect(mathUtils.factorial(3)).toEqual(6);
    });
    
    it("should throw an error for negative numbers", function() {
      expect(function() { mathUtils.factorial(-1); }).toThrow(new Error("There is no factorial for negative numbers"));
    });
    
  });
  