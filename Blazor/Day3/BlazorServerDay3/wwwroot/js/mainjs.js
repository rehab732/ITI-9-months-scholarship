function GetName() {
    alert("My Name is Rehab :)");
}

function giveMeRandomInt() {
    DotNet.invokeMethodAsync('BlazorServerDay3', 'GenerateRandomInt')
        //GeneraterandomInt ==>function in c# "Invokable"
        .then(result=> {
        document.getElementById('randomNumSpan').innerText=result
    });
}
