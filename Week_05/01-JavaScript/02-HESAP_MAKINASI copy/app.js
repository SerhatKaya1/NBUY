const display = DocumentSelector('.calculator-input');
const keys = document.querySelector('.calculator-keys');

let displayValue='0';

updateDisplay();

function updateDisplay(){
    display.value='0';
}

keys.addEventListener('click', function(event){
    const element = event.target;
    if(!element.matches('button')) return;
    console.log(element.value);
    if (element.classList.contains('operator')) {
        console.log(('Bir operatore tıklandı!'));
    }else if (element.classList.contains('decimal')){
        console.log('ondalık sayı yazmak üzere . işaretine tıklandı');
    }else if (element.classList.contains('clear')){
        console.log('temizlenme bütonuna tıklandı');
    }else{
        console.log('bir rakama tıklandı');
    }
    
});