var result = $('#result');
button = $(':button');
calcHistory = $('#calcHistory');
var curent = '0';
var number = "";
var newnumber = "";
var operator = "";

(button).click(function () {
    var buttonVal = $(this).val(),
        value = result.val();
            //if (buttonVal == '+') {
            //   // operator = "+";
            //    if (curent != 0 && operator != "") {
            //        curent = compute();

            //    } else {
            //        curent = parseFloat(value, 10);
            //    }

            //    operator = "+";
            //    value += buttonVal
            //    calcHistory.val(calcHistory.val() + value);
            //    result.val('');

            //} else
                if (buttonVal == '-') {
                   // operator = "-";
                    if (curent != 0 && operator != "") {
                        curent = compute();

                    } else {
                        curent = parseFloat(value, 10);
                    }

                    operator = "-";
                    value += buttonVal
                    calcHistory.val(calcHistory.val() + value);
                    result.val('');

                } else
                    if (buttonVal == 'X') {
                       
                        if (curent != 0 && operator != "") {
                            curent = compute();
                            
                        } else {
                            curent = parseFloat(value, 10);
                        }

                        operator = "X";
                        value += buttonVal
                        calcHistory.val(calcHistory.val() + value);
                        result.val('');

                    } else
                        if (buttonVal == '/') {
                           
                            if (curent != 0 && operator != "") {
                                curent = compute();
                                
                            } else {
                                curent = parseFloat(value, 10);
                            }

                            operator = "/";
                            value += buttonVal
                            calcHistory.val(calcHistory.val() + value);
                            result.val('');

                        } else {
                            if (buttonVal != "=" && buttonVal != "back") {
                                value += buttonVal;
                                result.val(value);
                            }

                        }
});



$('#clear').click(function () {
    result.val('');
});

$('#clearH').click(function () {
    calcHistory.val('');
    curent = '0';
    number = "";
    newnumber = "";
    operator = "";
});

$('#add').click(function () {
            if (curent != 0 && operator != "") {
                curent = compute();

            } else {
                curent = parseFloat(value, 10);
            }

            operator = "+";
            value += buttonVal
            calcHistory.val(calcHistory.val() + value);
            result.val('');

        
});


$('#point').click(function () {
    result.val(".");
});

$('#back').click(function () {
    var num = result.val();
    var backs = num.length - 1;
    var newValue = num.substring(0, backs);
    result.val(newValue);

});
$("#neg").click(function () {
    var bigNum = parseInt(result.val());
    var negative = bigNum * -1;
    result.val(negative);
});

$('#equal').click(function () {
    var value = result.val();
    calcHistory.val(calcHistory.val() + value);
    curent = compute();
    operator = "";
});

function compute() {

    newnumber = result.val();
    if (operator === "+") {
        number = (curent + parseFloat(newnumber, 10));
    } else if (operator === "-") {
        number = (curent - parseFloat(newnumber, 10));
    } else if (operator === "/") {
        number = (curent / parseFloat(newnumber, 10));
    } else if (operator === "X") {
        number = (curent * parseFloat(newnumber, 10));
    }

    result.val(number);
    return number;

}