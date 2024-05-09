// vendor-list.js
"use strict";
document.addEventListener('DOMContentLoaded', function () {
    // Check if the success message is present in the URL
    var urlParams = new URLSearchParams(window.location.search);
    var successMessage = urlParams.get('successMessage');

    if (successMessage) {
        // Display the success message
        var successMessageContainer = document.getElementById('successMessageContainer');
        successMessageContainer.innerHTML = '<div class="alert alert-success" role="alert">' + successMessage + '</div>';

        // Optionally, you can hide the message after a few seconds
        setTimeout(function () {
            successMessageContainer.innerHTML = '';
        }, 2500); // 5000 milliseconds (adjust as needed)
    }
});
