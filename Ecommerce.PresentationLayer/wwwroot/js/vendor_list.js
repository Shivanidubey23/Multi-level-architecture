"use strict";

$(document).ready(function () {
    // Attach a click event listener to elements with the "delete-vendor" class
    $(".delete-vendor").on("click", function (e) {
        e.preventDefault(); // Prevent the default behavior of the anchor tag

        // Extract the vendorId from the data attribute
        var vendorId = $(this).data("vendor-id");

        // Confirm the delete action
        if (confirm("Are you sure you want to delete this vendor?")) {
            // Make an Ajax request to delete the vendor
            $.ajax({
                url: "/Vendor/DeleteVendor",
                type: "DELETE",
                data: { vendorId: vendorId },
                success: function (result) {
                    if (result.success) {
                        // Display the success message (assuming you have an element with id="success-message")
                        $("#success-message").text("Vendor deleted successfully");

                        // Reload the page after a short delay
                        setTimeout(function () {
                            location.reload();
                        }, 2000); // 2000 milliseconds (2 seconds)
                    } else {
                        // Handle the case where the delete was not successful
                        alert("Error deleting vendor: " + result.message);
                    }
                },
                error: function (xhr, status, error) {
                    console.log("Error: ", xhr.responseText);
                    alert("Error deleting vendor. Please try again.");
                }
            });
        }
    });

    // Attach a click event listener to elements with the "edit-vendor" class
    $(".edit-vendor").on("click", function (e) {
        e.preventDefault(); // Prevent the default behavior of the anchor tag

        // Extract the vendorId from the data attribute
        var vendorId = $(this).data("vendor-id");

        // Redirect the user to the EditVendor action with the vendor ID
        window.location.replace("/Vendor/EditVendor?id=" + vendorId);
    });
});
