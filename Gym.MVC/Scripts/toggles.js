$(document).ready(function () {
    inicializarToggles();
});

function inicializarToggles()
{
    $(".titulo-toggle").off("click");
    $(".titulo-toggle").click(function () {
        if ($(this).closest(".grupo").find(".detalle-toggle").is(":visible")) {
            $(this).find(".chevron").removeClass("glyphicon-chevron-down");
            $(this).find(".chevron").addClass("glyphicon-chevron-right");
            $(this).closest(".grupo").find(".detalle-toggle").fadeOut();
        } else {
            $(this).find(".chevron").removeClass("glyphicon-chevron-right");
            $(this).find(".chevron").addClass("glyphicon-chevron-down");
            $(this).closest(".grupo").find(".detalle-toggle").fadeIn();
        }
        return false;
    });
}

function toggleOff(item)
{
    $(item).find(".chevron").removeClass("glyphicon-chevron-down");
    $(item).find(".chevron").addClass("glyphicon-chevron-right");
    $(item).closest(".grupo").find(".detalle-toggle").fadeOut();
}

function mostrarSeccion(checkBoxId, seccionClass)
{
    if ($("#" + checkBoxId).prop("checked")) {
        $("." + seccionClass).fadeIn("slow");
    } else {
        $("." + seccionClass).fadeOut();
    }
}