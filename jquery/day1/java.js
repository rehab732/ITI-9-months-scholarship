$(function(){
    $("#about").click(function(){
        $("#aboutt").show();
        $(".res").hide();
        $(".comm").hide();
        $("#div").hide();
        $("#dropdown").hide();

    })
    $("#ser").click(function(){
        $("#aboutt").hide();
        $(".res").hide();
        $(".comm").hide();
        $("#div").hide();
        $("#dropdown").show();


    })
    var gall=['Images/2.jpg','Images/3.jpg','Images/4.jpg','Images/5.jpg','Images/6.jpg','Images/7.jpg','Images/8.jpg'];
    var i = 1;  
    $("#right").click(function () {
      if (i >= gall.length) i = 0;//circular
      i++;
      $("#image")[0].src = gall[i];
    });
    $("#left").click(function () {
      if (i <= 1) i = gall.length//circular
      i--;
      $("#image")[0].src =gall[i];
    });
    $("#gal").click(function(){
        $("#div").show();
        $("#dropdown").hide();
        $("#aboutt").hide();
        $(".res").hide();
        $("..comm").hide();
      
    })
    $("#com").click(function(){
        $(".comm").show();
        $("#dropdown").hide();
        $("#aboutt").hide();
        $(".res").hide();
      
        $("#div").hide();
    })
    $("#send").click(function(){
        $("#sname").html(" " + $("#name").val());
      $("#semail").html(" " + $("#email").val());
      $("#scom").html(" " + $("#complain")[0].value);
      $("#soho").html(" " + $("#phone").val());
        $(".comm").hide();
        $(".res").show();
        $("#dropdown").hide();
        $("#aboutt").hide();
     
     
        $("#div").hide();
    })
    $("#back").click(function(){
        $(".res").hide();
        $(".comm").show();
        $("#dropdown").hide();
        $("#aboutt").hide();
        $(".res").hide();
      
        $("#div").hide();
        
    })
    
})
