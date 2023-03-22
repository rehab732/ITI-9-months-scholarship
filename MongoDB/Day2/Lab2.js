
/*let instructorsArray=[{_id:6,firstName:"noha",lastName:"hesham",
                age:21,salary:3500,
                address:{city:"cairo",street:10,building:8},
                courses:["js","mvc","signalR","expressjs"]},
                
                {_id:7,firstName:"mona",lastName:"ahmed",
                age:21,salary:3600,
                address:{city:"cairo",street:20,building:8},
                courses:["es6","mvc","signalR","expressjs"]},
                
                {_id:8,firstName:"mazen",lastName:"mohammed",
                age:21,salary:7040,
                address:{city:"Ismailia",street:10,building:8},
                courses:["asp.net","mvc","EF"]},
                
                {_id:9,firstName:"ebtesam",lastName:"hesham",
                age:21,salary:7500,
                address:{city:"mansoura",street:14,building:3},
                courses:["js","html5","signalR","expressjs","bootstrap"]}
               
		
		];
		db.instructors.insertMany(instructorsArray)*/
		
//1- run following queries on instructors collection:
//a- Display all documents in instructors collection

      db.instructors.find()
      
//b- Display all instructors with salaries greater than 4000 (only show firstName and salary)
        db.instructors.find({salary:{$gt:4000}},{firstname:1,salary:1})
        
//c- Display all instructors with ages less than or equal 25

        db.instructors.find({age:{$lte:25}})
        
//d- Display all instructors with city mansoura and sreet number 10 or 14 only display (firstname,address,salary)

         db.instructors.find(
         {
             $and:[
             {"address.city":"mansoura"},
             {"address.street":{$in:[10,14]}},
             ],
             },
             {firstname:1,address:1,salary:1}
             );
             
             
//e- Display all instructors who have js and jquery in their courses (both of them not one of them)
            db.instructors.find({courses:{$all:["jquery","js"]}}) //wala wa7ed

            
//f- Display number of courses for each instructor and display first name with number of courses.
              db.instructors.find({courses:{$exists:true}}).forEach((elem) => {
                  print(
                  ` ${elem.firstName} : ${elem.courses.length}`
                  );
                  });
/*
g- Write mongodb query to get all instructors that have firstName and
lastName properties , sort them by firstName ascending then by
lastName descending and finally display their data FullName and age
Note: use mongoDb sort method not javascript array method
*/
           db.instructors.find
           (
           { firstName: { $exists:true}, lastName: { $exists:true } },
           {firstName: 1 , lastName: 1, age: 1}
           ).sort({firstName:1,lastName:-1}).forEach((elem)=>{
               print(`FullName : ${elem.firstName} ${elem.lastName} === Age : ${elem.age}`)
           });

           
//h- Find all instructors that have fullName that contains “mohammed”.
          db.instructors.find({$or:[{firstName:"mohammed"},{lastName:"mohammed"}]})
              
          
//i- Delete instructor with first name “ebtesam” and has only 5 courses in courses array
          db.instructors.deleteOne({firstName:"ebtesam",courses:{$size:5}})
          
          //test
          db.instructors.find()
          
          
//j- Add active property to all instructors and set its value to true

          db.instructors.updateMany({},{$set:{active:true}},{upsert:true})
          //test
          db.instructors.find()
          
//k- Change “EF” course to “jquery” for “mazen mohammed” instructor

         db.instructors.updateMany(
         {firstName:"mazen",lastName:"mohammed",courses:"EF"},
         {$set:{"courses.$":"jquery"}}
         );
           
         //test
         db.instructors.findOne({firstName:"mazen"})
         
//Add jquery course for “noha hesham”.
            
            db.instructors.updateMany(
            {$and:[{firstName:"noha"},{lastName:"hesham"}]},
            {$addToSet:{courses:"jquery"}}
            );
            //test
         db.instructors.findOne({firstName:"noha"})
         
         
//m- Remove courses property for “ahmed mohammed ” instructor

              db.instructors.updateMany(
              {$and:[{firstName:"ahmed"},{lastName:"mohammed"}]},
              {$unset:{courses:40}}
              );
              
              //test
          db.instructors.findOne({firstName:"ahmed"})
          db.instructors.findOne()
          
//n- Decrease salary by 500 for all instructors that has only 3 courses in their list ($inc)
               
               db.instructors.updateMany(
               {courses:{$size:3}},
               {$inc:{salary:-500}}
               );
               //test
               db.instructors.find()
               
               
//o- Rename address field for all instructors to fullAddress.

         db.instructors.updateMany({},{$rename:{address:"fullAddress"}})
         //test
         db.instructors.find()
         
 
 
 //p- Change street number for noha hesham to 20
           
           db.instructors.update(
           {$and:[{firstName:"noha"},{lastName:"hesham"}]},
           {$set:{"fullAddress.street":20}}
           );
           
           //test
           db.instructors.find({firstName:"noha"})
           
           

