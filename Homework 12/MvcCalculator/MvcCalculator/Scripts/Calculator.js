﻿var result = $('#result'),
	    button = $(':button');
// var result = 0;


$(button).click(function () {
    var buttonVal = $(this).val(),
        value = result.val();

    value += buttonVal;
    result.val(value);
});



//$('#equal').click(function () {
//    var sum = result.val();

//    result.val('');
//    result.val(eval(sum));


//});
//$('#C').click(function () {
//    result.val('0');
//});




//$(document).ready(function(e) {
//    $('#1,#2,#3,#4,#5,#6,#7,#8,#9,#0').click(function(){
//        var v = $(this).val();
//        $('#result').val($('#result').val() + v);	
//    });
//   window.alert("heloo");
//    $('C').click(function(){
//        $('#result').val('');
//        $('#operation').val('');
//        $('#operation').removeClass('activeAnswer');
//        $('#equals').attr('onclick','');
//    });

//    <script type="text/javascript">
//    $(".calculator").on('click',function(){
//    if($(this).attr('data-role')!='operator'){
//        $(".result").val($(".result").val() + $(this).val());
//    }
//    else{
//        if ($(".result").val() != '') {
//            $(".result").val($(".result").val() + $(this).val());
//        }
//    }
//});

//windows.alert("ds");
//$(document).ready(function () {
//    var result = 0;
//    var prevEntry = 0;
//    var operation = null;
//    var currentEntry = '0';
//    updateScreen(result);

//    $(':button').on('click', function (evt) {
//        var buttonPressed = $(this).html();
//        console.log(buttonPressed);
//        windows.alert();
//        if (buttonPressed === "C") {
//            result = 0;
//            currentEntry = '0';
//        } else if (buttonPressed === "CE") {
//            currentEntry = '0';
//        } else if (buttonPressed === "back") {

//        } else if (buttonPressed === "+/-") {
//            currentEntry *= -1;
//        } else if (buttonPressed === '.') {
//            currentEntry += '.';
//        } else if (isNumber(buttonPressed)) {
//            if (currentEntry === '0') currentEntry = buttonPressed;
//            else currentEntry = currentEntry + buttonPressed;
//        } else if (isOperator(buttonPressed)) {
//            prevEntry = parseFloat(currentEntry);
//            operation = buttonPressed;
//            currentEntry = '';
//        } else if (buttonPressed === '%') {
//            currentEntry = currentEntry / 100;
//        } else if (buttonPressed === 'sqrt') {
//            currentEntry = Math.sqrt(currentEntry);
//        } else if (buttonPressed === '1/x') {
//            currentEntry = 1 / currentEntry;
//        } else if (buttonPressed === 'pi') {
//            currentEntry = Math.PI;
//        } else if (buttonPressed === '=') {
//            currentEntry = operate(prevEntry, currentEntry, operation);
//            operation = null;
//        }

//        updateScreen(currentEntry);
//    });
//});

//updateScreen = function (displayValue) {
//    var displayValue = displayValue.toString();
//    $('.result').html(displayValue.substring(0, 10));
//};

//isNumber = function (value) {
//    return !isNaN(value);
//}

//isOperator = function (value) {
//    return value === '/' || value === '*' || value === '+' || value === '-';
//};

//operate = function (a, b, operation) {
//    a = parseFloat(a);
//    b = parseFloat(b);
//    console.log(a, b, operation);
//    if (operation === '+') return a + b;
//    if (operation === '-') return a - b;
//    if (operation === '*') return a * b;
//    if (operation === '/') return a / b;
//}