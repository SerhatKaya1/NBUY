'use strict';
let btnAdd = document.getElementById('btnAddNewTask');
let txtTaskName = document.getElementById('txtTaskName');
btnAdd.addEventListener('click', newTask);
txtTaskName.addEventListener('keypress', function(event){
    if (event.key=='Enter') {
        event.preventDefault();
        btnAdd.click();
    }
});






