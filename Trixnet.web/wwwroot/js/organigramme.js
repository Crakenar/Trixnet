google.charts.load('current', { packages: ["orgchart"] });
google.charts.setOnLoadCallback(drawChart);


function drawChart() {
    var nom = document.getElementById('nom').value;
    var fonction = document.getElementById('fonction').value;
    var superieur = document.getElementById('superieur').value;

    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Name');
    data.addColumn('string', 'Manager');
    data.addColumn('string', 'ToolTip');

    // For each orgchart box, provide the name, manager, and tooltip to show.
    data.addRows([
        [{ 'v': 'Mike', 'f': 'Mike<div style="color:red; font-style:italic">President</div>' },
            'MonChef', 'jsp'],
        [{ 'v': 'Jim', 'f': 'Jim<div style="color:red; font-style:italic">Vice President</div>' },
            'Mike', 'VP'],
        ['Alice', 'Mike', ''],
        ['Bob', 'Jim', 'Bob Sponge'],
        ['Carol', 'Bob', ''],
        [{ 'v': nom, 'f': nom + '<div style=color:red; font-style:italic>' + fonction + '</div>' }, superieur, ''],
    ]);

    var arr = [];
    //soit on fait un objet d'un objet pour ensuite simplement le réutiliser soit on le décompose pour l'array et on créera l'objet lors du load du json
    //arr.push([{'v':nom,'f':nom+'<div style=color:red; font-style:italic>'+fonction+'</div>'},superieur,'']);
    arr.push({ "nom": nom, "fonction": fonction, "superieur": superieur });
    var jsonArray = JSON.stringify(arr);
    //console.log(jsonArray);

    //Essayons de l'envoyer dans un localstorage


    //On regarde s'il y a déjà des données sauvegardées
    var myJSON = JSON.stringify(localStorage.getItem('OrganigrammeHSE'));
    console.log("données déjà sauvegardées:" + myJSON);
    var nouvelleArray = [];
    nouvelleArray.push({ "nom": nom, "fonction": fonction, "superieur": superieur });
    nouvelleArray.push(JSON.parse(myJSON));
    console.log("nouvelle donnees:" + nouvelleArray);
    localStorage.setItem('OrganigrammeHSE', nouvelleArray);
    console.log("Au final on a : ", Object.values(nouvelleArray));


    // Create the chart.
    var chart = new google.visualization.OrgChart(document.getElementById('chart_div'));
    // Draw the chart, setting the allowHtml option to true for the tooltips.
    chart.draw(data, { 'allowHtml': true });
}

function addUser() {
    google.charts.load('current', { packages: ["orgchart"] });
    google.charts.setOnLoadCallback(drawChart);
}