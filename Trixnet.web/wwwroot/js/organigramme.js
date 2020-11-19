google.charts.load('current', { packages: ["orgchart"] });
google.charts.setOnLoadCallback(drawChart);

var arr = [];
var x;
function drawChart() {
    var nom = document.getElementById('nom').value;
    var fonction = document.getElementById('fonction').value;
    var superieur = document.getElementById('superieur').value;

    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Name');
    data.addColumn('string', 'Manager');

    arr.push([{ 'v': nom, 'f': nom + '<div style=color:red; font-style:italic>' + fonction + '</div>' }, superieur]);
    //probleme de duplication d'objets
    data.addRows(arr);
    //console.log(data);
    // Create the chart.
    var chart = new google.visualization.OrgChart(document.getElementById('chart_div'));
    // Draw the chart, setting the allowHtml option to true for the tooltips.
    chart.draw(data, { 'allowHtml': true, });
    x = arr;
}

function addUser() {
    google.charts.load('current', { packages: ["orgchart"] });
    google.charts.setOnLoadCallback(drawChart);    
}

function sauvegarderOrganigramme() {
    $.ajax({
        type: "post",
        url: "/SetDataOrganigramme",
        data: JSON.stringify("yo"),
        dataType: "json",
        succes: function (reponse) {
            console.log(reponse);
        },
        error: function (response) {
            console.log(response);
        }
    });
}

function afficherOrganigramme() {
    $.ajax({
        type: "get",
        url: "/GetDataOrganigramme",      
        success: function (response) {
            for (var i = 0; i < response.length; i++) {
                console.log(response[i].superieur);
                arr.push([{ 'v': response[i].v, 'f': response[i].f + '<div style=color:red; font-style:italic>' + response[i].fonction + '</div>' }, response[i].superieur]);
            }
        },
        error: function (response) {
            console.log(response.responseText);
        }
    });
}