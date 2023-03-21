db.createCollection("instructors")
show collections
db.instructors.insertOne({_id:1,firstname:"Rehab",lastname:"Zaki"})
db.instructors.find()
let instructorsArray=[{_id:6,firstName:"noha",lastName:"hesham",
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
		
		db.instructors.insertMany(instructorsArray)//insert data
		
		
		//Display all documents for instructors collection
		db.instructors.find()
		
		
		//Display all instructors with fields firstName, lastName and address 
		
		db.instructors.find({},{firstname:1,lastname:1,address:1})
		
		
		//Display firstName and city(not full address) for instructors with age 21.
		db.instructors.find({age:21},{firstname:1 , address:{city:1}})
		
		
		
		//Display firstName and age for instructors live in Mansoura city
		
		db.instructors.find({"address.city":"Mansoura"},{firstname:1,age:1})
		
		
		//Try to run these commands
		db.instructors.find({firstName:"mona"},{lastName:"ahmed"},{firstName:1,lastName:1})
		
		
		db.instructors.find({courses:"mvc"},{firstName:1,courses:1})
		
		
		