$(function () {
    var band = $("#band")
    var artist = $("#artist")
  
    var data = []
  
    band.change(function (e) {
      var getArtist = data[e.target.value]
      artist.empty()
      artist.append($('<option>Please Select :</option>'));
  
      for (var i = 0; i < getArtist.length; i++) {
        artist.append($('<option>', {
          value: getArtist[i].value,
          text: getArtist[i].name
        }));
      }
    })
    artist.change(function (e) {
      //console.log(e.target.value);
      window.open(e.target.value, "", "width=500,height=500")
    })
  
  
    $.ajax({
      type: "GET",
      url: "rockbands.json",
      success: function (res) {
        data = res;
       // console.log(data);
        var artists = Object.keys(res);
       // console.log(artist);
        for (var i = 0; i < artists.length; i++) {
          band.append($('<option>', {
            value: artists[i],
            text: artists[i]
          }));
        }
      }
    });
  })