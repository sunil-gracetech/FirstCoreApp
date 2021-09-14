$(document).ready(function () {
    $("#frm-create").on("submit", function () {
        if ($(".name").val() == "") {
            alert("name must required !")
            return false;
        }
        else {
            return true
        }
    })
})
