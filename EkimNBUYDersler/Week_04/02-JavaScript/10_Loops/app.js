//While
// let i=0;
// while (i<=10) {
    
//     i++;
//     console.log(i + '.JavaScript');

// }

//do while
// let i=0;
// do {
//     i++;
//     console.log(i + '.JavaScript');
// } while (i < 10 );

// for (let i = 0; i < 10; i++) {
//     console.log(i + 1 + '.Java Script');
    
// }

// let toplam = 0;
// let i = 1;
// while (i<=10) {
//     toplam += i;
//     i++;
// }
// console.log('While ile : ' + toplam);


// let toplam2 = 0;
// for (let i = 1; i <=10 ; i++) {
//     toplam2 +=i;
// }
// console.log'For ile: ' + toplam2);




// let toplam = 0;

// for (let i = 1; i <= 3; i++) {
//     girilenSayi= Number(prompt)(i + '.sayı: '));
//     toplam += girilenSayi;
// }
// console.log('Toplam: ' + toplam);

// let toplam = 0;
// let girilenSayi;

// do {
//     girilenSayi = Number(prompt(i + '.sayı '));
//     toplam += girilenSayi;
//     i++;
// } while (girilenSayi !=0);


//SON ÖRNEKTEKİ GİRİLEN SAYILARIDA SONUÇTA YAZDIRALIM.
// 1.sayı : 20
// 2.sayı: 10 
// 3.sayı : 30
// Toplam : 60


// let toplam = 0;
// let girilenSayilar= [];
// let i = 0;
// do {
//     girilenSayilar[i] = Number(prompt(i + '1.sayı '));
//     toplam += girilenSayilar[i];
//     i++;
//  while (girilenSayi[i] !=0);

// } while (girilenSayilar[i - 1] !=0);
// i++;
// for (let i = 0; i < girilenSayilar.length; i++) {
//     console.log(i + 1 + 'Sayi:\t' + girilenSayilar[i]);
// }
// console.log('Toplam' + toplam);


// Kullanıcının istediği kadar sayı girmesini isteyin . Sayı girişi bitişi için 0'a basılması gereksin.
//0'a basılıp sayı girişi bittiğinde kullanıcıya şu soruyu sorun : Tek mi çift mi?
//Kullanıcı tek derse : tek sayıları ve toplamlarını
//Çift derse çift sayıları ve toplamları yazdırın.


// let sayilar = [];
// do{
//     sayilar[i]=Number(prompt(i + 1 + '.sayı: '));
//     i++;
// } while (say[i - 1] !=0);


let sonucDizi = [];
let cevap = prompt('Tek mi çift mi?');
console.log(cevap);
if (cevap.toLocaleLowerCase == 'tek') {


    for (let i = 0; i < sayilar.length; i++) {
        if (sayilar[i] % 2 === 1) {
            sonucDizi.push(sayilar[i]);
            toplam += sayilar[i];
        }
        
    }
    console.log("Tek dedin");
}
else if(cevap.toLocaleLowerCase() == 'Çift') {
    console.groupEnd("Çift dein");
}else {
    console.log('Lütfen tek ya da "Çift yaz"!');
}


console.log(sayilar);
console.log(tur + ' Sayılar: ' + sonucDizi);
console.log(tur + ' Sayıların Toplamı: ' + toplam);