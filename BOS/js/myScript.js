// JavaScript source code
var rootURL = 'https://www.timeanddate.com/moon/phases';

function initMoonPhase(){

  $('#moon-phases').click(function(){

    var locationRawCity = $("#location-city").val();
    var locationRawCountry = $('#location-country').val();
    $("#city-country").html(locationRawCity + ", " + locationRawCountry);
    var locationCity = encodeURIComponent(locationRawCity);
    var locationCountry = encodeURIComponent(locationRawCountry);
    var locationURL = rootURL + '/' + locationCountry + '/' + locationCity;
    $.get(locationURL, function(data){
      var text = $($.parseHTML(data)).find('#mn-cyc').html();
      var cleanHTML = text.replace(/\/\/c.tadst.com/g, 'https://c.tadst.com');
      $("#display-here").html(cleanHTML);
      $("#location-city").val("");
      $("#location-country").val("");
    });
  });

};


//$(imageUrl).replace('c.tadst.com', 'www.timeanddate.com');
