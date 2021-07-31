function initialize(Denuncias) {
    var latlngRepDom = new google.maps.LatLng(18.735693, -70.162651);

    var options = {
        zoom: 4, center: latlngRepDom,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map"), options);

    Denuncias.forEach((Denuncia) => {
        if (Denuncia.Latitud && Denuncia.Longitud) {
            var marker = new google.maps.Marker({
                position: new google.maps.LatLng(Denuncia.Latitud, Denuncia.Longitud),
                map: map,
            });
        }
    })
}
