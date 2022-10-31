// function selamVer (){
//     console.log('Merhaba Java Script');
// }

// selamVer();


// function selamVer(isim='Dünya'){
//     console.log('Merhaba' + isim);
// }
// selamVer('Engin');
// selamVer('Zeynep');
// selamVer('Sema ve arkadaşları');
// selamVer();

// function yasHesapla(dogumYili){
//    return new Date().getFullYear() - dogumYili;
// }
// console.log(yasHesapla(1975));
// let yas = yasHesapla(1975);
// if ( yas<30) {
//     console.log('Yasınız uygun değildir');
// } else

// console.log('Kabul edildiniz');

// function kdvHesapla(tutar) {
//     let sonuc = tutar * 0.18;
//     sonuc = sonuc.toFixed(2);
//     return sonuc;

// }

// console.log(kdvHesapla(117));
// console.log(kdvHesapla(4875));

// function kdvHesapla(){
//     for (let i = 0; i < arguments.length; i++) {
//         console.log(arguments[i] * 0.18)
        
//     }
// }

// kdvHesapla(100,200,1800);

//Kendisine gönderilecek tutar bilgilerini kullanarak kdv'leri hesaplayıp , geriye hesaplanmış kdv'leri içinde barındıran bir dizi döndüren function

function kdvHesapla() {
    let sonuc = []
    for (let i = 0; i < arguments.length; i++) {
        kdv = arguments[i] * 0.18;
        kdv = kdv.toFixed(2);
        sonuc.[i]=kdv;
    }
    return sonuc;
}
    console.log(kdvHesapla(100,450,1000));

    
