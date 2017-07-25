var choicesLeft = $('#numberOfChoices').val();
var rootImage = "/Images/hangman-";
var imageIndex = 7 - choicesLeft;
var image = rootImage + imageIndex + ".png";
$("img").attr('src', image);