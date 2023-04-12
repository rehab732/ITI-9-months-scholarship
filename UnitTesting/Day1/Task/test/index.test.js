const { sum, convertToArray, checkPositivity ,capitalizeText,createArray} = require("../index");
const { assert, expect } = require("chai");
const should = require("chai").should();
/*
describe("test sum function", () => {
  before(() => {
    console.log("before");
  });
  after(() => {
    console.log("after");
  });
  beforeEach(() => {
    console.log("beforeEach");
  });
  afterEach(() => {
    console.log("afterEach");
  });
  it("sum with positive numbers", () => {
    assert.equal(sum(2, 2), 4);
    expect(sum(1, 1)).to.equal(2);
    sum(5, 5).should.equal(10);
  });
  it("sum with negative numbers", () => {
    assert.equal(sum(-1, -5), -6);
    expect(sum(-5, -3)).to.equal(-8);
    sum(-1, -3).should.to.equal(-4);
  });
  it("sum with string", () => {
    assert.throw(() => sum("ggg", 55), TypeError, "nums only");
    expect(() => sum("hh", "kkk")).throw(TypeError, "nums only");
    (() => sum("hhh", "uuu")).should.Throw(TypeError, "nums only");
  });
});

describe("test convertToArray function", () => {
  it("convertToArray with assert", () => {
    //? assert does not allow chaining
    assert.isArray(convertToArray(2, 5, 8));
    assert.lengthOf(convertToArray(5, 6, 8), 3);
    assert.include(convertToArray(2, 8, 5), 2);
  });
  it("convertToArray with expect", () => {
    expect(convertToArray(5, 8, 7))
      .to.be.an("array")
      .to.have.lengthOf(3)
      .that.includes(8);
  });
  it("convertToArray with should", () => {
    convertToArray(5, 8, 1)
      .should.to.be.an("array")
      .to.have.lengthOf(3)
      .that.includes(1);
  });
});

//& TDD
describe("TDD study", () => {
  it("checkPositivity with pos param", () => {
    expect(checkPositivity(5)).equal(true);
  });
});
*/




describe.only('capitalizeText function', () => {
  before(() => {
    console.log("before");
  });
  after(() => {
    console.log("after");
  });
  beforeEach(() => {
    console.log("beforeEach");
  });
  afterEach(() => {
    console.log("afterEach");
  });

  //test that the function takes a string  it will return a string 
  it('should take a string and return a string', () => {
         expect(capitalizeText('hello')).to.be.a('string');

         assert.equal(typeof capitalizeText('rehab'),'string')

         capitalizeText('rehab').should.to.be.a('string');
  });
  
  //test that the function takes a string and return it after capitalize it
  it('should take a string and return it capitalized', () => {
    expect(capitalizeText('rehab')).to.be.a('string');
    expect(capitalizeText('rehab')).to.equal('REHAB');

    assert.strictEqual(typeof capitalizeText('rehab'), 'string');//compare return true if have same value and type
    capitalizeText('rehab').should.equal('REHAB');

  });

  

  //test if the function takes number it will throw type error says parameter should be string
  it('should throw a TypeError if the parameter is not a string', () => {
    assert.throws(() => capitalizeText(123), TypeError, 'parameter should be string');
    expect(() => capitalizeText(123)).throw(TypeError, "parameter should be string");
    (() => capitalizeText(123)).should.Throw(TypeError, "parameter should be string");

  });


});


describe('createArray test Function',()=>{
  //test that the return value of type array
  it("test is array or not",()=>{
    expect(createArray(5)).to.be.an("array");
   assert.isArray(createArray(5));
   createArray(5).should.to.be.an('array');


  });
//test if we pass 3 it will return array of length 3 and test it's include 1
it("test if we pass 3 it will return array of length 3 and test it's include 1",()=>{
  expect(createArray(3)).to.be.an("array").to.have.lengthOf(3).that.includes(1);
  
  createArray(3).should.to.be.an("array").to.have.lengthOf(3).that.includes(1);
})

})


setTimeout(() =>{
  run()
}, 5000);
//npm test -- delay