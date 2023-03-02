let success=new Audio('assets/success-fanfare-trumpets-6185.mp3');
let error=new Audio('assets/beep-beep-6151.mp3');
let imgs = [
    'assets/1.gif',
    'assets/2.gif',
    'assets/3.gif',
    'assets/4.gif',
    'assets/5.gif',
    'assets/6.gif'
];
let main = document.getElementById('main');
let alldivs = document.getElementsByTagName('div');
function drowbox() {
    for (let i = 0; i < imgs.length; i++) {
        main.innerHTML += '<div><img src="' + imgs[i] + '"></div>';

    }
}
drowbox();
drowbox();
var flag = true;
var arr=[];

for (let i = 0; i < alldivs.length; i++) {
    alldivs[i].addEventListener('click', function () {
        //console.log(this);
        if (flag) {
             this.firstChild.style.opacity = '1';
             //take first 2 clicks
             if(arr.length==0)
             {
                arr[0]=this;
             }else if(arr.length==1)
             {
                arr[1]=this
             }
             if(arr.length==2)
             {
                flag=false;
                setTimeout(check,200);
                
            
             }else{return;}
            }

    })}

function check(){
    //check if 2 images are equal
                //compare by src
                if(arr[0].firstChild.getAttribute('src')==arr[1].firstChild.getAttribute('src'))
                {
                   success.play();
                }else{
                    //return 2 image with opacity 0
                    error.play();
                    arr[0].firstChild.style.opacity=0;
                    arr[1].firstChild.style.opacity=0;
                }
                arr=[];
                flag=true;
             }

            