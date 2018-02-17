// Write your JavaScript code.
(function ($) {
    $(function () {
        $(".case").on("click", function () {
            window.location = $("a.details", this).attr("href");
        });
    });
})(jQuery);