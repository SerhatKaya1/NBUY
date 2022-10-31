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
            <div class="dropdown">
  <button class="btn btn-secondary dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
  <i class="fa-solid fa-ellipsis"></i>
  </button>
  <ul class="dropdown-menu">
    <li><a onlick="removeTask(${gorev.id})" class="dropdown-item" href="#"<i class="fa-solid fa-trash-can-arrow-up"></i>>Sil</a></li>
    <li><a class="dropdown-item" href="#"<i class="fa-solid fa-pen"></i>>Düzenle</a></li>
    
  </ul>
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
    let btn btn-remove 
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
function remove(id){
    let deleted;
    
    // for (const gorevIndex of gorevListesi) {
    //     if (gorevListesi[gorevIndex].id==id) {
    //         deletedId=gorevIndex;
    //     }
    // }

    //Alternatif Java Script yöntemleri
    // deletedId=gorevListesi.findIndex(function(gorev)){
    //     return gorev.id==id; 

    // };

    // deletedId = gorevListesi.findIndex(gorev=> gorev.id==id);


    //Artık gorevlistesi dizisinden kaçıncı sıradaki elenamnın silineceğini biliyoruz. deletedId'nci sıradaki elemanı sileceğiz.

    gorevListesi.splice(deletedId,1);
    displayTasks();
}
displayTasks();
