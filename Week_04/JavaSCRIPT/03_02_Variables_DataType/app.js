/*Değikener tanımlanırken 3 farklı keyword kullanılabilir.
1-) var :
2-) let :
3-) const(sabit)

-ES6 ile birikte artık Modern JavaScript tabiri kulanılmaya başlanmıtır.Bu süreçte lest ve const kulanın, var kulanmaktan kaçının.

-JS'de değişken tanımanırken tip belirlenmez.
-Bu, değişkenlerin tipi olmadığı anlamına gelmez .
-JS motoru bir değişkene değer ataması esnasında o değere göre tabi belirler.
-Eğer henüz bir değişkene değer atanmamışsa undifined olarak beirlenir.

*/ 

// let yas = 20;
// console.log(yas)

// let ad = 'Geç kalan Sema'
// let sodad = 'Geç kalan Harun';


// console.log(ad);
// console.log(yas);
// console.log(ad,soyad);

// let firstName='Serhat'
// let lastName="Kaya"
// console.log(firstName + '' + lastName)


// let sayi1 = 15;
// let sayi2 = 25;
// let sayi3 = 35;

// let s1 = 15, s2= 45, s3=55;

// let say1 =25;
// let say2 =55;
// let say3 =48;


// let durum = true;

// sayi1=125;
// console.log(sayi1);
// let toplam=0;    
// toplam = toplam + sayi1;
 


// const benimDogumYilim = 1975;
// console.log('Benim doğum yılım:'+ benimDogumYilim);

/*
-Bildiğiniz değişken isimlendirme yöntemlerini burada da kullanabilirsiniz. Değikenleri genellikle camelCase ile isimlendiriniz.
-Deiken isimlerinde harf, rakam, $ ve _ olbilir.
-Reserved Keyword'ler değişken adı olarak kullanılmaz.


-Const sabit değereri tutmak için kullanılır.Genelliikle tamamen büyük harf ile isimlendirilir.
*/


// const PI_SAYISI = 3.14;
// const _PI_SAYISI = 3.14;

// const RENK 1 = 'Sarı'
// const RENK 2 = 'Lacivert';
// let renk_3 = 'Yeşil';

// console.log(RENK_1, renk_3, RENK_2);


//DATA TYPES

//1-NUMBER
// let sayi1=100;
// console.log(sayi1);
// console.log(typeof sayi1);
// console.log(type(sayi1));

// let sayi2= 17.5;
// console.log(sayi2);
// console.log(typeof sayi2);


// let sayi3 = 25/0;
// console.log(sayi3, typeof(sayi3));
// let sayi4 = 'Okul' / 25;
// console.log(sayi4, typeof(sayi4));

// let sayi5 = 565645656551515666431658425n;
// console.log(sayi5, typeof(sayi5));

// let sayi6 = sayi5 *
// 9999999999999999999999999999999999999999999999999999999999999;
// console.log(sayi6, typeof(sayi6));

//STRING
// String ifadeler üç farkı şekilde ifade edilebilir . 

// 1-) Tek tırnak ile 
// 2-) Çift tırnak ile ("")
// 3-) Backtics (``)

    /*
    let ad = 'Engin'
    let soyad = 'Niyazi';
    let adSoyad = ad + "" + soyad;
    console.log(adSoyad);

    */ 

    // let adres = 'Halitağa Mah.\n\t Sütlü Nuriye Sok. Candaş Ap. No:21 \n\t Beşiktaş';
    // console.log(adres)

    // let adSoyad= 'SERHAT';
    // let yas = 47;
    // let kanGrubu = 'ARh+';
    // let kilo = 47;
    // let cinsiyet = 'sanane';

    // console.log('Sayın' + adSoyad + ', ' +yas+'kanGrubu..'\nKilo: '+kilo + '\nYaş: 'yas' '\nCinsiyet: '+ cinsiyet + 'n\n\n\');
    // console.log();
    // console.log();

    // console.log('Sayın ${adSoyad}, ${yas} yaşındasınız.
    // Kio : ${kilo}
    // Kan Grubu: ${kanGrubu}
    // cinsiyet: ${cinsiyet}'
    // );

//    //BOOLEN
//     let durum = true;
//     console.group(durum, typeof(durum));
//     let ad = 'Halil'
//     console.log(ad,typeof(ad));

//     //null, undefined
//     let yas;
//     yas = nul;
//     yas= n12/0;
//     console.log(yas);

    //JavaScripte CHAR diye bir tip yoktur.

    //CONVERT DATA TYPES
    // let durum = true;
    // console.log(durum, typeof durum);

    // let metin = 'Durumunuz ' + durum + 'şeklindedir';
    // console.log(metin, typeof metin);

    // let durumMetin = String(durum);
    // console.log(durumMetin, typeof durumMetin)

    //     let sayi = 25;
    //     let metin2 = sayi + 'yaşındasınız';
    //     console.log(metin2, typeof metin2);
    //     let sayiMetin = String (sayi);
    //     console.log(sayiMetin, typeof sayiMetin);

    //     let metinSayi = '455';
    //     console.log(metinSayi,typeof metinSayi);
    //     let metinSayiNumber = Number(metinSayi);
    //     console.log(metinSayiNumber, typeof metinSayiNumber);

        // let sayiMetin = '      145        ';
        // console.log(sayiMetin, typeof sayiMetin);
        // comsole.log(sayi, typeof sayi);
        //number--> 2 üzeri 53-1


        // let sayi=12345n;
        // console.log(sayi, typeof sayi);
        // console.log(Number(true));
        // console.log(Number(false));

        // console.log(Boolean(0));
        // console.log(Boolean(1));
        // console.log(Boolean('0'));

               let a;
               a = '' -1 + 0; console.log(a,typeof a); 
               a = '' -1 + 0 ; console.log(a,typeof); 
               a true + false; console.log(a,typeof a);
               a = 6 / '3'; console.log(a, typeof a);
               a= 4 + 5 + 'px'; console.log(a, typeof a);
               a='$' + 4 + 5 ; console.log(a, typeof a);
               a='4px' - 2 ; console.log(a, typeof a);
               a = '  -9   ' +5; console.log(a, typeof a);
               a = null +1













