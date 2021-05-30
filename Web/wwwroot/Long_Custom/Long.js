function openWin(url, w, h) {
    var left = (screen.width / 2) - (w / 2);
    var top = (screen.height / 2) - (h / 2);
    var new_left = window.screenX + (((window.outerWidth / 2) - (w / 2)));
    var new_top = window.screenY + (((window.outerHeight / 2) - (w / 2)));
    window.open(url, '', 'width=' + w + ', height=' + h + ', top=' + new_top + ', left=' + new_left + ',toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, copyhistory=no');
}
function initMap() {
    // The location of Uluru
    const uluru = { lat: 10.776530, lng: 106.700980 };
    // The map, centered at Uluru
    const map = new google.maps.Map(document.getElementById("map"), {
        zoom: 10,
        center: uluru,
    });
    return map;
}
//function point_Giao_Nhan(test1, test2) {
//    console.log(test1);
//    console.log(test2);
//    const map = initMap();
//    var arr = [
//        {
//            position: new google.maps.LatLng(test1.lat, test1.long),
//            title: `${test1.so_Phieu_Giao}`,
//            message: `${test1.dia_Chi}`,
//        },
//        {
//            position: new google.maps.LatLng(test2.lat, test2.long),
//            title: `${test2.so_Phieu_Nhan}`,
//            message: `${test2.dia_Chi}`,
//        },
//    ];
//    for (let i = 0; i < arr.length; i++) {
//        const marker = new google.maps.Marker({
//            position: arr[i].position,
//            map: map,
//            title: arr[i].title,
//        });
//        var infowindow = new google.maps.InfoWindow();
//        marker.addListener('click', function () {
//            const contentString = '<h3>' + arr[i].title + '</h3>' + '<br>' + arr[i].message;
//            infowindow.setContent(contentString);
//            infowindow.open(map, marker);
//        });
//    }
//}
function point_Giao_Nhan(test1, test2) {
    const directionsService = new google.maps.DirectionsService();
    const directionsRenderer = new google.maps.DirectionsRenderer();
    const map = initMap();
    directionsRenderer.setMap(map);
    var start = `${test1.lat}` + ', ' + `${test1.long}`;
    var end = `${test2.lat}` + ', ' + `${test2.long}`;
    calculateAndDisplayRoute(directionsService, directionsRenderer, start, end);
}
function calculateAndDisplayRoute(directionsService, directionsRenderer, start, end) {
    directionsService.route(
        {
            origin: {
                query: start,
            },
            destination: {
                query: end,
            },
            travelMode: google.maps.TravelMode.DRIVING,
        },
        (response, status) => {
            if (status === "OK") {
                directionsRenderer.setDirections(response);
            } else {
                window.alert("Directions request failed due to " + status);
            }
        }
    );
}
