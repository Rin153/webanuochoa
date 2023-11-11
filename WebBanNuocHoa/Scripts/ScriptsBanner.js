$(document).ready(function () {
    function runBannerAnimation() {
        $(".banner").animate({ left: "100%" }, 5000, "linear", function () {
            $(this).css("left", "-100%");
            runBannerAnimation();
        });
    }

    runBannerAnimation();
});