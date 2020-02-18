// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
    $(document).ready(function () {
        ratcal();
            $("#prot").change(function () {ratcal(); });
            $("#carb").change(function () {ratcal(); });
            $("#fat").change(function () {ratcal(); });
});


        function ratcal() {
        console.log("RatCal");
    var agg = (parseFloat($("#prot").val()) + parseFloat($("#carb").val()));
            if (agg == 0) {agg = 1};
    console.log(agg);
    $("#Ratio").text(($("#fat").val() / agg).toFixed(2));
    $("#Calories").text((($("#prot").val()) * 4 + ($("#carb").val() * 4) + ($("#fat").val() *9)).toFixed(2));
};