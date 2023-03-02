//problem 1
function List(start, end, step) {
  var data = [];
  (function Fill() {
    for (i = start; i <= end; i += step) data.push(i);
  })();

  Object.defineProperties(this, {
    pop: {
      value: function () {
        if (data.length == 0) throw "empty List";
        return data.pop();
      },
    },
    Display: {
      value: function () {
        for (i = 0; i < data.length; i++) console.log(data[i]);
      },
    },
    push: {
      value: function (val) {
        if (data.includes(val)) throw "repeated value ";
        else if (
          val <= data[data.length - 1] ||
          val - data[data.length - 1] != step
        )
          throw "data not in seq";
        else data.push(val);
      },
    },
    Prepend: {
      value: function (val) {
        if (data.includes(val)) throw "repeated value  ";
        else if (val >= data[data.length - 1]) throw "data not in seq";
        else data.splice(0, 0, val);
      },
    },
    Dequeue: {
      value: function () {
        if (data.length == 0) throw "empty Lidt";
        return data.splice(0, 1);
      },
    },
  });
}
List.prototype.toString = function () {
  this.Display();
};

//problem 2
Object.defineProperty(book, "booksObjCounts", {
  value: 0,
  writable: true,
});

Object.defineProperty(book, "getBooksObjCounts", {
  value: function () {
    return book.booksObjCounts;
  },
});

function book(title, chaptersNum, author, pagesNum, publisher, copiesNum) {
  Object.defineProperties(this, {
    title: {
      value: title,
    },
    numOfChapters: {
      value: chaptersNum,
    },
    author: {
      value: author,
    },
    numOfPages: {
      value: pagesNum,
    },
    publisher: {
      value: publisher,
    },
    numOfCopies: {
      value: copiesNum,
      writable: true,
    },
  });

  book.booksObjCounts++;
}

function box(height, width, length, material) {
  Object.defineProperties(this, {
    height: {
      value: height,
    },
    width: {
      value: width,
    },
    length: {
      value: length,
    },
    material: {
      value: material,
    },
    content: {
      value: [],
      writable: true,
      enumerable: true,
    },
  });

  for (var i = 4; i < arguments.length; i++) {
    this.content.push(arguments[i]);
  }

  Object.defineProperty(this, "booksCount", {
    value: function () {
      for (var b = 0; b < this.content.length; b++) {
        sum += this.content[b].numOfCopies;
        i++;
      }
      return sum;
    },
  });

  Object.defineProperty(this, "deleteBook", {
    value: function (title) {
      var index = -1;
      for (var b = 0; b < this.content.length; b++) {
        index++;
        if (this.content[b].title == title) {
          if (this.content[b].numOfCopies == 1) {
            this.content.splice(index, 1);
          } else {
            this.content[b].numOfCopies--;
          }
          this.booksCount--;
        }
      }
    },
  });
}
var book1 = new book("Javascript", 30, "Hassan", 400, "pub1", 2);
var book2 = new book("HTML", 20, "Ahmed", 300, "pub2", 3);
var book3 = new book("CSS", 25, "Mahmoud", 600, "pub3", 7);
var book4 = new book("python", 20, "Mohamed", 200, "pub3", 5);

var box1 = new box(20, 30, 10, "wood", book3, book4);
var box2 = new box(10, 30, 5, "plastic", book1, book2);

box.prototype.valueOf = function () {
  return this.booksCount();
};

box.prototype.toString = function () {
  return (
    "width: " +
    this.width +
    "height: " +
    this.height +
    "length: " +
    this.length +
    "#books: " +
    this.booksCount()
  );
};

console.log(book.booksObjCounts);
console.log(box1.booksCount());
console.log(box2.booksCount());
box1.deleteBook("python");
console.log(box1.booksCount());
box2.deleteBook("Javascript");
console.log(box2.booksCount());
box2.deleteBook("Javascript");
console.log(box2.booksCount());
console.log(box2);
console.log(box1.toString());
console.log(box2.toString());
console.log(box1 + box2);
