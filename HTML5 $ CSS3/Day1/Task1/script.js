var vid = document.getElementsByTagName("video");
document.getElementById("play").addEventListener("click", function(){
    vid[0].play();
})

document.getElementById("stop").addEventListener("click", function(){
    vid[0].pause();
})

document.getElementById("first").addEventListener("click", function(){
    vid[0].currentTime = 0;
    vid[0].play();
})

document.getElementById("prev").addEventListener("click", function(){
    vid[0].currentTime -= 10;
    vid[0].play();
})

document.getElementById("next").addEventListener("click", function(){
    vid[0].currentTime += 10;
    vid[0].play();
})
document.getElementById("last").addEventListener("click", function(){
    vid[0].currentTime = vid[0].duration;
    vid[0].play();
})

document.getElementById("mute").addEventListener("click", function(){
    vid[0].volume = 0;
})

document.getElementById("speed").addEventListener("input", function(){
    vid[0].playbackRate = speed.value
})

document.getElementById("duration").max = vid[0].duration;
document.getElementById("duration").addEventListener("mouseover", function(){
    setInterval(function(){
        document.getElementById("duration").value = vid[0].currentTime
        document.getElementById("time").innerText = vid[0].currentTime.toFixed(2) + "/" + vid[0].duration.toFixed(2);
    },200)
})


document.getElementById("fullscreen").addEventListener("click", function(){
    vid[0].requestFullscreen();
})

document.getElementById("volume").addEventListener("input", function(){
    vid[0].volume = (document.getElementById("volume").value)/100;
})
