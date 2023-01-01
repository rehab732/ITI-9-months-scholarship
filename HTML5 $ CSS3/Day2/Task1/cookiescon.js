


conditionizr.add('Cookie',function(){
    return !window.cookie;
});

conditionizr.polyfill("/cookies.js",['Cookie']);

