const express = require("express");
const app = express();

app.get('/', (req, res)=>{
    res.status(200).send("Hello get Hassan");
});

app.post('/test', (req, res)=>{
    res.status(200).send("Hello post Hassan");
});

var server = app.listen(3000);
module.exports = server;