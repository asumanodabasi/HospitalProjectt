$(document).ready(function () {
    // İl seçildiğinde ilçeleri getir
    $("#il").change(function () {
        var ilId = $(this).val();
        $("#ilce").empty();
        $("#hastane").empty();
        if (ilId) {
            $.get("/api/Appointment/GetIlceler/" + ilId, function (data) {
                $.each(data, function (index, ilce) {
                    $("#ilce").append("<option value='" + ilce.id + "'>" + ilce.name + "</option>");
                });
            });
        }
    });

    // İlçe seçildiğinde hastaneleri getir
    $("#ilce").change(function () {
        var ilceId = $(this).val();
        $("#hastane").empty();
        if (ilceId) {
            $.get("/api/Appointment/GetHastaneler/" + ilceId, function (data) {
                $.each(data, function (index, hastane) {
                    $("#hastane").append("<option value='" + hastane.id + "'>" + hastane.name + "</option>");
                });
            });
        }
    });


    //hastane seçildiğinde klinik gelir
    $("#hastane").change(function () {
        var hastaneId = $(this).val();
        $("#klinik").empty();
        if (hastaneId) {
            $.get("/api/Appointment/GetKliniks/" + hastaneId, function (data) {
                $.each(data, function (index, klinik) {
                    $("#klinik").append("<option value='" + klinik.id + "'>" + klinik.name + "</option>");
                });
            });
        }
    });

    //klinik seçildiğinde doktor getir
    $("#klinik").change(function () {
        var klinikId = $(this).val();
        $("#doctor").empty();
        if (klinikId) {
            $.get("/api/Appointment/GetDoctors/" + klinikId, function (data) {
                $.each(data, function (index, doctor) {
                    $("#doctor").append("<option value='" + doctor.id + "'>" + doctor.name + "</option>");
                });
            });
        }
    });


    //doktor secildiginde saatlerini getir
    $("#doctor").change(function () {
        var doktorId = $(this).val();
        $("#saat").empty();
        if (doktorId) {
            $.get("/api/Appointment/GetHours/" + doktorId, function (data) {
                $.each(data, function (index, saat) {
                    $("#saat").append("<option value='" + saat.id + "'>" + saat.startTime + "</option>");
                });
            });
        }
    });




    
});
    //randevu

$("#randevuAl").click(function () {
    var selectedIl = $("#il").val();
    var selectedIlce = $("#ilce").val();
    var selectedHastane = $("#hastane").val();
    var selectedKlinik = $("#klinik").val();
    var selectedDoctor = $("#doctor").val();
    var selectedSaat = $("#saat").val();

    // Verileri bir nesne olarak hazırla
    var randevuData = {
        ilId: selectedIl,
        countyId: selectedIlce,
        hastaneId: selectedHastane,
        klinikId: selectedKlinik,
        doctorId: selectedDoctor,
        workHourId: selectedSaat
        // Diğer verileri de ekleyebilirsiniz
    };

    // Veriyi JSON formatına çevir
    var randevu = JSON.stringify(randevuData);

    // Veriyi sunucuya gönder
    $.ajax({
        url: "/api/Appointment/RandevuEkle/",
        type: "POST",
        contentType: "application/json",
        data: randevu,
        success: function (response) {
            console.log("Randevu başarıyla kaydedildi.");
            // Başka bir işlem yapabilirsiniz, örneğin kullanıcıya bir bildirim gösterebilirsiniz.
        },
        error: function (error) {
            console.error("Randevu kaydedilirken bir hata oluştu.");
            // Hata durumunda kullanıcıya bir bildirim gösterebilirsiniz.
        }
    });
});

