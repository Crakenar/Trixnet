function horloge() {

    var emplacement = document.getElementById("time");
    var date = new Date();
    var heure = date.getHours();
    var minutes = date.getMinutes();
    var secondes = date.getSeconds();

    emplacement.innerHTML = heure + " : " + minutes + " : " + secondes;
    
}

setInterval(horloge, 1000);