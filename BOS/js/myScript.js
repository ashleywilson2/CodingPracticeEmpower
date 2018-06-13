// JavaScript source code
var rootURL = 'https://www.timeanddate.com/moon/phases/usa';

function initMoonPhase(){


  $('#moon-phases').click(function(){
    var locationRaw = $("#location").val();
    var location = encodeURIComponent(locationRaw);
    var locationURL = rootURL + '/' + location;
    $.get(locationURL, function(data){
      var text = $($.parseHTML(data)).find('#mn-cyc').html();
      var cleanHTML = text.replace(/\/\/c.tadst.com/g, 'https://c.tadst.com');
      $("#display-here").html(cleanHTML);
      $("#location").val("");
    });
  });

};


//$(imageUrl).replace('c.tadst.com', 'www.timeanddate.com');
