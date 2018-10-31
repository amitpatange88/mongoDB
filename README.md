<h1>MongoDB</h1>

<br>
<b>Below are the few common commands and parameters to set : </b><br>

<b>//set params</b>
mongod --directoryperdb --dbpath C:\mongoDB\data\db --logpath C:\mongoDB\log\mongo.log  --logappend  --install

<b>//to start mongoDB service.</b>
net start MongoDB

mongo

<b>//Few other cmds</b>
1. show dbs
2. db
3. use mycustomers

db.createUser({
user:"amit",
pwd:"12345",
roles:["readWrite", "dbAdmin"]
});

<b>//create collection.</b>
db.createCollection('customers');

show collections

db.customers.insert({first_name:"John", last_name:"Doe"});
db.customers.insert([{first_name:"John", last_name:"Doe"},{first_name:"Steven", last_name:"Smith"}]);
db.customers.insert({first_name:"Roy", last_name:"Miller", gender :"Male"});

db.customers.find();
db.customers.find().pretty();

db.customers.update({first_name:"John"}, {first_name:"John", last_name:"Doe", gender:"Male"});

db.customers.update({first_name:"Steven"}, {$set:{gender:"male"}});

<b>//Only add/set the new fields.</b>
db.customers.update({first_name:"Steven"}, {$set:{age:45}});

<b>//Increment the fields by.</b>
db.customers.update({first_name:"Steven"}, {$inc:{age:5}});

<b>//Remove the fields.</b>
db.customers.update({first_name:"Steven"},{$unset:age:1}});

<b>//upsert : if not found then insert</b>
db.customers.update({first_name:"Mary"}, {first_name:"Mary", last_name:"Kom"}, {upsert:true});

<b>//rename or alter the column</b>
db.customers.update({first_name:"Steven", {$rename:{"gender":"sex"}}});

<b>//Remove the records.</b>
db.customers.remove({first_name:"Steven"});

<b>//Remove the only one record.</b>
db.customers.remove({first_name:"Steven"}, {justOne:true});


