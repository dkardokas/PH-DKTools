$(function() {
    $("#jq-output").html("<p>JQuery is ready for action...</p>");
    $("a.dkt-api-action").click(function () {

        $.get($(this).attr("data-action"), null, function (data, status, xhr) {
            alert(data);
        });
        $(this).hide();
        
        
    });
});