$(function () {
    $('#accordion').accordion({
        header: 'h3',
        change: function (event, ui) {
            var newIndex = $(ui.newHeader).index('h3');
            if (jQuery.inArray(newIndex, available_indexes) == -1) {
                var oldIndex = $(ui.oldHeader).index('h3');
                $(this).accordion("activate", oldIndex);
                alert('That panel is not yet available');
            }
        }
    });

    $("#tabs").tabs();

    //$("#myPanel").panel("open");
});