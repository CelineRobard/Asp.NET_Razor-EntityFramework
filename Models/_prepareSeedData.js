
const Doglist = ["Azawakh","Bulldog","Chow-Chow","Dogue Argentin", "Eurasier", "Fila Brasileiro","Golden retriver", "Hokkaido", "Irish Terrier","Jack russell terrier","Komondor","Léonberg","Malmute","Norfolk-terrier","Otterhound","Podenco d\'Ibiza","Qimmiq","Roltweiler","Sharpei","Teckels","Urugayen Cimarron","Volpino Italien","Welsh corgi cardigan","Xoloitzcuintle","Yokshire-terrier","Zwergpinscher"];

let dogName;
let picture;
let path;

Doglist.forEach(dog => {
    dogName = `"${dog}"`;
    picture = dog.replace(/-/,"").replace(/ /,"").replace(/ /,"").replace(/'/,"").replace(/é/,"e").toLowerCase();
    path = `"/img/${picture}.jpg"`
    console.log( `new Dog { Name = ${dogName}, Picture = ${path} },`);
});
