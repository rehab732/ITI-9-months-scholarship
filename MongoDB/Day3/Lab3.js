use FacultySystemV2

/*
Create student collection that has (FirstName, lastName,
IsFired, FacultyID, array of objects, each object has
CourseID, grade). 
*/
db.createCollection("student",{
    validator:{
        $jsonSchema:{
            bsonType:"object",
            properties: {
               FirstName:{
                   bsonType:"string"
               },
               LastName:{
                   bsonType:"string"
               },
               IsFired:{
                   bsonType:"bool"
                   
               },
               FacultyID:{
                   bsonType:"number"
                   
               },
               Courses:{
                   bsonType:"array",
                   additionalProperties:false,
                   items:{
                       bsonType:"object",
                       additionalProperties:false,
                       properties:{
                           CourseID:{
                               bsonType:"number",
                           },
                           Grade:{
                               bsonType:"number"
                           }
                       }
                       
                   }
               }
            }//prop
            
        }//schema
    }//validator
})




// Create Faculty collection that has (Faculty Name,Address). 
db.createCollection("Faculty",{
    validator:{
        $jsonSchema:{
            bsonType:"object",
            properties:{
                FacultyName:{
                    bsonType:"string"
                },
                Address:{
                    bsonType:"string"
                }
            }//prop
            
        }//schema
    }//validator
});

//Create Course collection, which has (Course Name, Final Mark).
db.createCollection("Course",{
    validator:{
        $jsonSchema:{
              bsonType:"object",
              properties:{
                 CourseName:{
                     bsonType:"string"
                 },
                 FinalMark:{
                     bsonType:"number"
                 } 
              }//prop
        }//schema
    }//validator
});


//• Insert some data in previous collections. 

//insert in course doc
db.Course.insert([{_id:1,CourseName:"NoSQL",FinalMark:100},{_id:2,CourseName:"HTML",FinalMark:100},{_id:3,CourseName:"API",FinalMark:100}]);
db.Course.find();
//insert in faculty doc
db.Faculty.insert([{_id:1,FacultyName:"FCAI",Address:"Giza"},{_id:2,FacultyName:"FCI",Address:"Helwan"},{_id:3,FacultyName:"XYZ",Address:"Cairo"}])
db.Faculty.find()

//insert in student doc
db.student.insert([{FirstName:"Rehab",LastName:"Zaki",IsFired:false,FacultyID:1,Courses:[{CourseID:2,Grade:100},{CourseID:1,Grade:80}]}]);
db.student.insert([{FirstName:"Nada",LastName:"Mostafa",IsFired:true,FacultyID:2,Courses:[{CourseID:3,Grade:100},{CourseID:1,Grade:80}]}]);
db.student.find()



/*
2. Display each student Full Name along with his average
grade in all courses. $concat
*/
        db.student.aggregate([
        {
            $match:{
                $or:[{FirstName:{$exists:true}},{LastName:{$exists:true}}]
            }
        }//match
        ,
        {
            $project:{
                FullName:{$concat:["$FirstName"," ","$LastName"]},
                Grade:"$Courses.Grade"
            }
        },//project
        {
            //Deconstructs an array field from the input documents to output a document for each element. Each output document is the input document with the value of the array field replaced by the element.
            //You can pass a field path operand or a document operand to unwind an array field.
            $unwind:{
                path:"$Grade"
            }
        }
        ,
        {
            $group:{
                _id:"$FullName",
                AvarageGrades:{
                    $avg:"$Grade"
                }
            }
        }//groub
        ])
        
        
//3)Using aggregation display the sum of final mark for all courses in Course collection.

        db.Course.aggregate([{
            $group:{
                _id:"null",
                Summition:{
                    $sum:"$FinalMark"
                }
            }
        }])
        
/*
4)Implement (one to many) relation between Student and
Course, by adding array of Courses IDs in the student object.
• Select specific student with his name, and then display
his courses. 
*/
    
        db.student.aggregate([{
            $match:{
                FirstName:"Rehab"
                
            }},{
                $lookup:{
                    from:"Courses",
                    localField:"Courses.CourseID",
                    foreignField:"_id",
                    as:"StudentsCourses"
                }
              
        }])
        
/*
.Implement relation between Student and faculty by adding
the faculty object in the student using _id Relation using
$Lookup.
• Select specific student with his name, and then display
his faculty
*/
    //test something
     db.student.find({FirstName:"Nada"})
    
    
    db.student.aggregate([{
        $match:{
            FirstName:"Nada"
            
        }},{
            $lookup:{
                from:"Faculty",
                localField:"FacultyID",
                foreignField:"_id",
                as:"FacultyCourses"
            }
    }])
    
   