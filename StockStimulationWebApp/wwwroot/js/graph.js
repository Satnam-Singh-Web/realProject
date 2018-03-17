var a;
var yearMonthclosearray = [];
var realTimedata = [];
var yearMonthDataArray = [];
var yearMonthDataReverseArray = [];
var j = 0;
var yearMonthCloseReverseArray = [];
var k = 0;

$(document).ready(function () {
    var table = $('table');

    $('th').click(function () {
        var table = $(this).parents('table').eq(0)
        var rows = table.find('tr:gt(0)').toArray().sort(comparer($(this).index()))
        this.asc = !this.asc
        if (!this.asc) {
            rows = rows.reverse()
        }
        for (var i = 0; i < rows.length; i++) {
            table.append(rows[i])
        }
    });
    function comparer(index) {
        return function (a, b) {
            var valA = getCellValue(a, index), valB = getCellValue(b, index)
            return $.isNumeric(valA) && $.isNumeric(valB) ? valA - valB : valA.localeCompare(valB)
        }
    }
    function getCellValue(row, index) { return $(row).children('td').eq(index).html() }


});
var stockData = $('#data').val();
//$.getJSON("https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY&symbol="+symbol+"&apikey=demo", function (json) {
//    stockData = json;
var jsonStockData = JSON.parse(stockData);// JSON.stringify(obj);
var yearMonthData = jsonStockData["Monthly Time Series"];

var count = 0;
for (var dat in yearMonthData) {
    if (yearMonthData.hasOwnProperty(dat)) {
        yearMonthDataArray[count] = dat;
        count++;
    }
}
for (var i = yearMonthDataArray.length - 1; i >= 0; i-- , j++) {
    yearMonthDataReverseArray[i] = yearMonthDataArray[j];

}
var counter = 0;

for (var dat in yearMonthData) {
    yearMonthclosearray[counter] = Object.values(yearMonthData[dat])[3]; counter++;
}
for (var i = yearMonthDataArray.length - 1, k = 0; i >= 0; i-- , k++) {
    yearMonthCloseReverseArray[i] = yearMonthclosearray[k];

}

var data = [];
$.each(yearMonthDataArray, function (i) {
    data.push({ 'date': yearMonthDataReverseArray[i], 'value': yearMonthCloseReverseArray[i] });
});
realTimedata = data;

var chart = AmCharts.makeChart("chartdiv", {
    "type": "serial",
    "theme": "light",
    "marginRight": 40,
    "marginLeft": 40,
    "autoMarginOffset": 20,
    "mouseWheelZoomEnabled": true,
    "dataDateFormat": "YYYY-MM-DD",
    "valueAxes": [{
        "id": "v1",
        "axisAlpha": 0,
        "position": "left",
        "ignoreAxisWidth": true
    }],
    "balloon": {
        "borderThickness": 1,
        "shadowAlpha": 0
    },
    "graphs": [{
        "id": "g1",
        "balloon": {
            "drop": true,
            "adjustBorderColor": false,
            "color": "#ffffff"
        },
        "bullet": "round",
        "bulletBorderAlpha": 1,
        "bulletColor": "#FFFFFF",
        "bulletSize": 5,
        "hideBulletsCount": 50,
        "lineThickness": 2,
        "title": "red line",
        "useLineColorForBulletBorder": true,
        "valueField": "value",
        "balloonText": "<span style='font-size:18px;'>[[value]]</span>"
    }],
    "chartScrollbar": {
        "graph": "g1",
        "oppositeAxis": false,
        "offset": 30,
        "scrollbarHeight": 80,
        "backgroundAlpha": 0,
        "selectedBackgroundAlpha": 0.1,
        "selectedBackgroundColor": "#888888",
        "graphFillAlpha": 0,
        "graphLineAlpha": 0.5,
        "selectedGraphFillAlpha": 0,
        "selectedGraphLineAlpha": 1,
        "autoGridCount": true,
        "color": "#AAAAAA"
    },
    "chartCursor": {
        "pan": true,
        "valueLineEnabled": true,
        "valueLineBalloonEnabled": true,
        "cursorAlpha": 1,
        "cursorColor": "#258cbb",
        "limitToGraph": "g1",
        "valueLineAlpha": 0.2,
        "valueZoomable": true
    },
    "valueScrollbar": {
        "oppositeAxis": false,
        "offset": 50,
        "scrollbarHeight": 10
    },
    "categoryField": "date",
    "categoryAxis": {
        "parseDates": true,
        "dashLength": 1,
        "minorGridEnabled": true
    },
    "export": {
        "enabled": true
    },
    "dataProvider": realTimedata
});




chart.addListener("rendered", zoomChart);
zoomChart();
function zoomChart() {
    chart.zoomToIndexes(chart.dataProvider.length - 40, chart.dataProvider.length - 1);
}

$(".amcharts-export-menu").remove();



// Executes when complete page is fully loaded, including
// all frames, objects and images
console.log("Window is loaded");

/*var jqxhr = $.getJSON("example.json", function () {
    console.log("success");
})
    .done(function () {
        console.log("second success");
    })
    .fail(function () {
        console.log("error");
    })
    .always(function () {
        console.log("complete");
    });


   
*/



/*
{
  "iisSettings": {
    "windowsAuthentication": false,
    "anonymousAuthentication": true,
    "iisExpress": {
      "applicationUrl": "http://localhost:34410/",
      "sslPort": 0
    }
  },
  "profiles": {
    "IIS Express": {
      "commandName": "IISExpress",
      "launchBrowser": true,
      "environmentVariables": {
        "ASPNETCORE_ENVIRONMENT": "Development"
      }
    },
    "StockStimulationWebApp": {
      "commandName": "Project",
      "applicationUrl": "http://localhost:5000"
    }
  }
}
*/