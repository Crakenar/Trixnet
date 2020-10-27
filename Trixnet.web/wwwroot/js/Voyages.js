/*$('[data-toggle=dropdown]').hover(function (e) {
    $(this).click();
})*/
$(document).ready(function () {
    $(".dropdown").mouseenter(function () {
        $(this).click();
    });

/*    $(".dropdown-menu").mouseleave(function () {
        $(this).click();
    });
*/
});
