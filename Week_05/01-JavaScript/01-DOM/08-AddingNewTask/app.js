'use strict';
let gorevListesi = [
    { 'id': 1, 'gorevAdi': 'Görev 1' },
    { 'id': 2, 'gorevAdi': 'Görev 2' },
    { 'id': 3, 'gorevAdi': 'Görev 3' },
    { 'id': 4, 'gorevAdi': 'Görev 4' },
    { 'id': 5, 'gorevAdi': 'Görev 5' },
];

function displayTasks() {
    let ul = document.getElementById('task-list');
    ul.innerHTML='';
    for (const gorev of gorevListesi) {
        let li = `
        <li class="task list-group-item">
            <div class="form-check">
                <input type="checkbox" id="${gorev.id}" class="form-check-input">
                <label for="${gorev.id}" class="form-check-label">${gorev.gorevAdi}</label>
            </div>
        </li>
    `;
        ul.insertAdjacentHTML('beforeend', li);
    }
}

let btnAdd = document.getElementById('btnAddNewTask');
let txtTaskName = document.getElementById('txtTaskName');
btnAdd.addEventListener('click', newTask);

function newTask(event){
    event.preventDefault();
    
    console.log(txtTaskName.value[0]);
    let ilkHar = txtTaskName.value[0].toLocalUpperCase();
    let geriKalan = txtTaskName.value.slice(1);
    console.log(ilkHarf);
    if (isFull(txtTaskName.value=='')) {
        alert('Lütfen boş bırakmayınız!')
        
    }else{
        gorevListesi.push(
            {
                'id': gorevListesi.length + 1,
                'gorevAdi': txtTaskName.value  //Her kelimenim ilk harfini büyütecek bir fonsksiyon hazırlayın.//

            }
        );
        displayTasks();
    }

    txtTaskName.value='';
    txtTaskName.focus();
};

function isFull(value) {
    if (value!='') {
        return false;
    }
        return true
};

function ilkHarfiBuyut(value){
    let ilkHar = value[0].toLocalUpperCase();
    let geriKalan = value.slice(1);
    return ilkHarf + geriKalan;
}

displayTasks();
