let ders =  'Bahçeşhir Üniversitesi Wissen Akademie Iğdır'
let sonuc;

sonuc = ders.toLocaleLowerCase();
sonuc = ders.toLocaleUpperCase();
sonuc = ders.toUpperCase();
sonuc = ders.toLocaleUpperCase();

sonuc= ders.length;
sonuc= ders[0];
sonuc= ders[29];
sonuc= ders[44];

sonuc = ders.slice(0,10);
sonuc = ders.slice(20,25);
sonuc = ders.slice(10);

sonuc = ders.substring(0,10);
sonuc = ders.substring(20,5);
sonuc = ders.substring(20,25);
sonuc = substring(25,20)

sonuc = ders.replace('Iğdır','İstanbul');
sonuc= ders.replace('','-')

sonuc = ders.trim();
sonuc = ders.trimStart();
sonuc = ders.trimEnd();

sonuc = ders.indexOf('A');
sonuc = ders.toLocaeUpperCase().indexOf('A');

sonuc = ders.split(' ');
console.log(sonuc[3]);

//Kullanıcının girdiği bir cümlenin ka. sözcükten oluştuğunu bulunuz.

sonuc = ders.includes('Akadamie');
sonuc = ders.startsWith('H');
sonuc= ders.endsWith('Iğdır');





console.log(ders);
console.log(sonuc);


// let cümle =prompt('Lütfen bir cümle girniz..');
// let sozcukDizisi = cumle.split(' ');
// console.log(sozcukDizisi.length);