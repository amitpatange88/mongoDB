<img src="https://cdn.iconverticons.com/files/png/4eae13c7686cb54d_256x256.png"><h1>MongoDB</h1><br>

<br>
//set params
mongod --directoryperdb --dbpath C:\mongoDB\data\db --logpath C:\mongoDB\log\mongo.log  --logappend  --install

//to start mongoDB service.
net start MongoDB

mongo

//Few other cmds
1. show dbs
2. db
3. use mycustomers

db.createUser({
user:"amit",
pwd:"1234",
roles:["readwrite", "dbadmin"]
});

db.createcollection('customers');

show collections

db.customers.insert({first_name:"John", last_name:"Doe"});
db.customers.insert([{first_name:"John", last_name:"Doe"},{first_name:"Steven", last_name:"Smith"}]);
db.customers.insert({first_name:"Roy", last_name:"Miller", gender :"Male"});

db.customers.find();
db.customers.find().pretty();

db.customers.update({first_name:"John"}, {first_name:"John", last_name:"Doe", gender:"Male"});

db.customers.update({first_name:"Steven"}, {$set:{gender:"male"}});

//Only add/set the new fields.
db.customers.update({first_name:"Steven"}, {$set:{age:45}});

//Increment the fields by.
db.customers.update({first_name:"Steven"}, {$inc:{age:5}});

//Remove the fields.
db.customers.update({first_name:"Steven"},{$unset:age:1}});

//upsert : if not found then insert
db.customers.update({first_name:"Mary"}, {first_name:"Mary", last_name:"Kom"}, {upsert:true});

//rename or alter the column
db.customers.update({first_name:"Steven", {$rename:{"gender":"sex"}}});

//Remove the records.
db.customers.remove({first_name:"Steven"});

//Remove the only one record.
db.customers.remove({first_name:"Steven"}, {justOne:true});


