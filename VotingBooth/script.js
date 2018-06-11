var apiUrl = "http://voteapi.empower2018.us";

function bindClickEvent(){
  $("#running-tally").click(function(){
    $.get(apiUrl + '/tally', function(data){
      var voteData = "";
      for(var i=0; i < data.length; i++){
        voteData += "<p><strong>API: </strong>" + data[i].api_name + " <strong>=</strong> " + data[i].vote_count + "</p>";
      };
      $("#data-container").html(voteData);
    });
  });

  $("#API-types").click(function(){
    $.get(apiUrl + '/apis', function(data){
      var optionData = "";
      for(var i=0; i < data.length; i++){
        optionData += "<p><strong>API Name: </strong>" + data[i].name + " <strong>ID Number: </strong>" + data[i]._id + "</p>";
      };
      $("#data-container").html(optionData);
    });
  });

  $("#cast-my-vote").click(function(){
    $.post(apiUrl + '/ashleywilson2/vote', {"api_name": "Spotify"}, function(data){
      console.log(data);
    });
  });

  $("#show-vote").click(function(){
    $.get(apiUrl + "/ashleywilson2/vote", function(vote){
      if (vote && vote.success){
        $("#data-container").html('You voted for: ' + vote.message.api_name + "!");
      }
      else {
        $("#data-container").html("You have not yet voted!!");
      }
    });
  });

  $("#reset-vote").click(function(){
    var options = {
      url: apiUrl + "/ashleywilson2/vote",
      type: "DELETE",
      success: function(data){
        console.log(data);
      }
    };
    $.ajax(options);
  });
};
