document.addEventListener("DOMContentLoaded", function () {
    let featuredArtist = document.getElementById("fa");
    let featured = document.getElementById("Feature");
    if (featured.checked) {
        featuredArtist.style.visibility = "visible";
    } else {
        featuredArtist.style.visibility = "hidden";
    }
    featured.addEventListener("change", function () {
        if (featured.checked) {
            featuredArtist.style.visibility = "visible";
        } else {
            featuredArtist.style.visibility = "hidden";
        }
    })
});