
/*
 * Fonction anonyme qui permet à tout les tag <a> ayant la classe popAnchor d'avoir un popover et d'afficher le contenu de data-content
 * */
$(function () {
    $('.popAnchor').popover({
        html: true,
        content: function () {
            return '<div class="popover-message"' > +$(this).data("message") + '</div>';
        },
        container: $('#espaceHandicap')
    })
});