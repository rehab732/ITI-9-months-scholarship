
const request = require("request");
const async = require("async");

describe("test get / end point", ()=>{

    var server;
    var dataGet = {};
    var dataPost={};

    beforeAll((done)=>{
        
        server = require("../app");
        async.waterfall([
                
            (cb)=>{
                request.get("http://localhost:3000/", (error, res, body)=>{
                    dataGet.status = res.statusCode;
                    dataGet.body = body;
                    cb();
                })
            },
            (cb)=>{
                request.post("http://localhost:3000/test", {json:true}, (error, res, body)=>{
                dataPost.status = res.statusCode;
                dataPost.body = body;
                cb();
               })
            }
        ], done);
    });

    afterAll(()=>{
        server.close();
    });

    it("get test status code", ()=>{
        expect(dataGet.status).toEqual(200);
    });

    it("get test body", ()=>{
        expect(dataGet.body).toEqual("Hello get Hassan");
    });

    it("post test status code", ()=>{
        expect(dataPost.status).toEqual(200);
    });

    it("post test body", ()=>{
        expect(dataPost.body).toEqual("Hello post Hassan");
    });
});