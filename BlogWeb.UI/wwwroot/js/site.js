(function () {
    var reformatTimeStamps = function () {
        var timeStamps = document.querySelectorAll(".timeStampValue");
        for (var ts of timeStamps) {
            var thisTimeStamp = ts.getAttribute("data-value");
            var date = new Date(thisTimeStamp);
            ts.textContent = moment(date).format('lll');
        }
    }
    reformatTimeStamps();
})();

jQuery(document).ready(function () {
    var currentUrl = document.location.href;
    var btns = jQuery(".nav-item > a");
    btns.each(function (i, v) {
        if (currentUrl.includes(v.pathname)) {
            jQuery(v).addClass("active");
        }
    });
});