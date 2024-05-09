"use strict";

// Function to handle add category form submission
// Function to handle add category form submission
function handleAddCategoryForm() {
    // Intercept the form submission
    $("#categoryForm").submit(function (e) {
        e.preventDefault(); // Prevent the default form submission

        // Perform an AJAX post to submit the form data
        $.ajax({
            url: $(this).attr("action"),
            type: $(this).attr("method"),
            data: $(this).serialize(),
            success: function (data) {
                if (data.success) {
                    // Clear the form
                    $("#categoryForm")[0].reset();

                    // Display the success message on the page
                    $(".success-message").removeClass("error").addClass("success").text(data.message).show();

                    // Reload the page after a successful update
                    location.reload();
                } else {
                    // Display the error message on the page or show a default message
                    var errorMessage = data && data.message ? data.message : "An error occurred while processing your request. Please try again.";
                    alert(errorMessage);
                }
            },
            error: function () {
                // Handle the case where an error occurs during the AJAX request
                alert("An error occurred while form submission processing your request. Please try again.");
            }
        });
    });
}

// Call the function to handle add category form
handleAddCategoryForm();

// Other functions for edit and delete
$(document).ready(function () {
    // Inline editing
    $("table").on("click", ".edit-category", function () {
        // ... (existing edit code)
        var categoryName = $(this).closest("tr").find(".category-name").text().trim();
        var categoryId = $(this).data("category-id");

        // Set the category name in the input field
        $("#category_field").val(categoryName);

        // Change the form action to the UpdateCategory action
        $("#categoryForm").attr("action", "/Category/UpdateCategory/" + categoryId);
    });

    // Inline deleting
    $("table").on("click", ".delete-category", function () {
        // ... (existing delete code)
         var categoryId = $(this).data("category-id");

        // Display a confirmation dialog
        if (confirm("Are you sure you want to delete this category?")) {
            // Perform an AJAX post to delete the category
            $.ajax({
                url: "/Category/DeleteCategory/" + categoryId,
                type: "DELETE",
                success: function (data, textStatus, xhr) {
                    if (xhr.status === 200) {


                        // Reload the page after a short delay
                        setTimeout(function () {
                            location.reload();
                        }, 1000); // 1000 milliseconds (1 second)
                    } else {
                        // Handle the case where the server did not return HTTP status 200
                        alert("Failed to delete the category. Please try again.");
                    }
                },
                error: function () {
                    // Handle the case where an error occurs during the AJAX request
                    alert("An error occurred while processing your Delete request. Please try again.");
                }
            });
        }
    });
});
