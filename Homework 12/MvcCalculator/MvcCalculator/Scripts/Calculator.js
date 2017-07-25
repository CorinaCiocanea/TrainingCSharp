var result = $('#result'),
button = $(':button');
calcHistory = $('#calcHistory')
var curent = '0';
var number = "";
var newnumber = "";
var operator = "";

(button).click(function () {
    var buttonVal = $(this).val(),
        value = result.val();
    if (buttonVal == 'C') {
        result.val('');
    }
    else
        if (buttonVal == 'CE') {
            calcHistory.val('');
        }

        else
            if (buttonVal == '+') {
                operator = "+";
                if (curent != 0 && operator != "") {
                    curent = compute();

                } else {
                    curent = parseFloat(value, 10);
                }

                operator = "+";
                value += buttonVal
                calcHistory.val(calcHistory.val() + value);
                result.val('');

            } else
                if (buttonVal == '-') {
                    operator = "-";
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
                        operator = "X";
                        if (curent != 0 && operator != "") {
                            curent = compute();
                            window.alert(curent);
                        } else {
                            curent = parseFloat(value, 10);
                        }

                        operator = "X";
                        value += buttonVal
                        calcHistory.val(calcHistory.val() + value);
                        result.val('');

                    } else
                        if (buttonVal == '/') {
                            operator = "/";
                            if (curent != 0 && operator != "") {
                                curent = compute();
                                window.alert(curent);
                            } else {
                                curent = parseFloat(value, 10);
                            }

                            operator = "/";
                            value += buttonVal
                            calcHistory.val(calcHistory.val() + value);
                            result.val('');

                        } else {
                            if (buttonVal != "=") {
                                value += buttonVal;
                                result.val(value);
                            }

                        }
});

$('#plus').click(function () {
    result.val(".");
});
$('#back').click(function () {
    var num = result.val();
    var backs = num.length - 1;
    result.val(backs);

});
$("#neg").click(function () {
    var bigNum = parseInt(result.val());
    var negative = bigNum * -1;
    result.val(negative);
});

$('#equal').click(function () {
    var value = result.val();
    calcHistory.val(calcHistory.val() + value);
    compute();

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