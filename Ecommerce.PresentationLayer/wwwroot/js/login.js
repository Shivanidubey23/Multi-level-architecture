"use strict";

// Class Definition
var KTLoginGeneral = function () {

    var login = $('#kt_login');

    var showErrorMsg = function (form, type, msg) {
        var alert = $('<div class="mb-10 alert alert-custom alert-light-' + type + ' alert-dismissible" role="alert">\
			<div class="alert-text font-weight-bold ">'+ msg + '</div>\
			<div class="alert-close">\
                <i class="ki ki-remove" data-dismiss="alert"></i>\
            </div>\
		</div>');

        form.find('.alert').remove();
        alert.prependTo(form);
        /* KTUtil.animateClass(alert[0], 'fadeIn animated');*/
        alert.find('span').html(msg);
    }

    // Private Functions
    var displaySignUpForm = function () {
        login.removeClass('login-forgot-on');
        login.removeClass('login-signin-on');
        console.log("Sign Up links clicked");
        login.addClass('login-signup-on');
        /*KTUtil.animateClass(login.find('.login-signup')[0], 'flipInX animated');*/
    }

    var displaySignInForm = function () {
        login.removeClass('login-forgot-on');
        login.removeClass('login-signup-on');

        login.addClass('login-signin-on');
        /*KTUtil.animateClass(login.find('.login-signin')[0], 'flipInX animated');*/
        //login.find('.login-signin').animateClass('flipInX animated');
    }

    var displayForgotForm = function () {
        login.removeClass('login-signin-on');
        login.removeClass('login-signup-on');

        login.addClass('login-forgot-on');
        //login.find('.login-forgot-on').animateClass('flipInX animated');
        /* KTUtil.animateClass(login.find('.login-forgot')[0], 'flipInX animated');*/

    }

    var handleFormSwitch = function () {
        $(document).on('click', '#kt_login_forgot', function (e) {
            e.preventDefault();
            displayForgotForm();
        });

        $(document).on('click', '#kt_login_forgot_cancel', function (e) {
            e.preventDefault();
            displaySignInForm();
        });

        $(document).on('click', '#kt_login_signup', function (e) {
            e.preventDefault();
            console.log("Sign Up link clicked");
            displaySignUpForm();
        });

        $(document).on('click', '#kt_login_signup_cancel', function (e) {
            e.preventDefault();
            displaySignInForm();
            console.log("Sign Up link clicked");
        });
    };

  
     

return {
    // Public functions
    init: function () {
        handleFormSwitch();
      
    }
};
}(); // End of KTLoginGeneral
$(function () {
        KTLoginGeneral.init();
 });
