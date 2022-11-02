const display = document.querySelector('.calculator-input');
const keys = document.querySelector('.calculator-keys');

let displayValue = '0';
let firstValue = null;
let operator = null;
let waitingForSecondValue = false;
updateDisplay();

function updateDisplay() {
    display.value = displayValue.replace('.',',')    //Noktaları virgüle çevir.//
}

keys.addEventListener('click', function (event) {
    const element = event.target;
    const value = element.value;
    if (!element.matches('button')) return;
    switch (value) {
        case '+':
        case '-':
        case '*':
        case '/':
        case '=':
            handleOperator(value);
            break;

            case '.':
                inputDecimal();
                break;

                case 'clear':
                clearDisplay();
                break;
        default:
            inputNumber(value);
      }
      
    

    // if (element.classList.contains('operator')) {
    //     handleOperator(element.value);
    //     updateDisplay();
    //     return;
    // }
    // if (element.classList.contains('decimal')) {
    //     inpurDecimal();
    //     updateDisplay();
    //     return;
    // }
    // if (element.classList.contains('clear')) {
    //     clearDisplay();
    //     updateDisplay();
    //     return;
    // }
    // inputNumber(element.value);
});

function inputNumber(num) {
    // displayValue +=num;
    // displayValue += num;
    if (waitingForSecond) {
        displayValue = num;
        updateDisplay();
        waitingForSecondValue = false;
    }
    displayValue = displayValue == '0' ? num : displayValue + num;
}

function inputDecimal() {
    if (!displayValue.includes('.')) {
        displayValue += '.';
        updateDisplay();
    }

}

function clearDisplay() {
    firstValue = null;
    operator = null;
    waitingForSecondValue = false;
    displayValue = '0';
    updateDisplay();
}

function handleOperator(nextOperator) {
    let value = parseFloat(displayValue);
    if (operator && waitingForSecondValue) {
        operator = nextOperator;
        return;
    }
    if (operator) {
        operator = nextOperator;
        return;
    }
    if (firstValue == null) {
        firstValue = value;

    } else if (operator) {
        //Hesaplama işlemleri yapılabilir.
        const result = calculate(firstValue, operator, value);
        displayValue = String(result);
        firstValue = result;
    }
    waitingForSecondValue = true;
    operator = nextOperator;
    console.log(firstValue, nextOperator, operator, value, result);
}
function calculate(num1, op, num2) {
    if (op === '+') return num1 + num2;
    if (op === '-') return num1 - num2;
    if (op === '*') return num1 * num2;
    if (op === '/') return num1 / num2;
    return num2;
}