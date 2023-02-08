/*
Task 1
apply default parameter
true if 1)pass all param
2) one or two
3) mb3atsh 7aga 
*/
function Defaultparameter(obj) {
    var defaultObj = {
        courseName: "ES6",
        courseDuration: "3Days",
        courseOwner: "Javascript",
    };
    var keys=Object.keys(obj);
    if(keys.length>3) throw "Can't pass more than 3 parameter";

    for(var key in obj)
    {
        if(!defaultObj.hasOwnProperty(key)) throw "Enter valid name";
    }
    var Obj = Object.assign({}, defaultObj, obj);

    return `
            Course Name ${Obj.courseName}
            Course Owner ${Obj.courseOwner}
            Course Duration ${Obj.courseDuration}
            `;
}
console.log(Defaultparameter({ courseName: "C#", courseDuration: "Month", courseOwner: "Ay7aga" }));
console.log(Defaultparameter({ courseName: "java", courseDuration: "year" }));
console.log(Defaultparameter({ courseName: "Wpf" }));
console.log(Defaultparameter({}));
console.log(Defaultparameter({ courseName: "C#", courseDuration: "Month", courseOwner: "Ay7aga" ,ay7aga:45}));











