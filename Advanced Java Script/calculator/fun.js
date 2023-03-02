(function(){
    let screen =document.querySelector('.screen');
    let buttons =document.querySelectorAll('.b');
    let clear =document.querySelector('.bclear');
    let equal =document.querySelector('.beq');

    buttons.forEach(function(button){
        button.addEventListener('click',function(e){
            let value=e.target.dataset.num;
            screen.value +=value;
        })
    });
    equal.addEventListener('click',function(e){
        if(screen.value===''){
            screen.value="";
        }else{
            let ans=eval(screen.value);
            screen.value=ans;
        }
    });
    clear.addEventListener('click',function(e){
        screen.value="";
    });

})();