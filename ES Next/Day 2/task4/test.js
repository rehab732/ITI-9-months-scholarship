  /**
   * Task 4
   * Handle Symbol.Iterator
   */
  var myObject = {
    username: "Rehab",
    age: 30,
    address: "helwan",
    generator: function * () {
      var keys = Object.keys(this);
      for (var key of keys) {
        typeof this[key] === "function" ? null : yield { key, value: this[key] };
      }
    },
  };
  
  for (var elem of myObject.generator()) {
    console.log(elem);
  }