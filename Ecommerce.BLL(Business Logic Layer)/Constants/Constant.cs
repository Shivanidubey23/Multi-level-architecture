/*******************************************************************************

Name:         Constant.cs
Author:       Shivani Dubey, Chrome Infotech
Date:         12/20/2023
Description:  Ecommerce

 Copyright © 2023 ChromeInfotech Corporation.  All Rights Reserved

Revisions:
12/20/2023 1.0.0   SD  Created

*******************************************************************************/

namespace ECommerce
{
    public class Constant
	{
		public class Messages
		{
			public const string WelcomeToChrome = "Welcome to Chrome!";
			public const string SuccessMessage = "If you want to know about success , Let`s join us.";
			public const string Chrome = "© 2023 Chrome";
			public const string DontHaveAccount = " Dont have an account yet?";
			public const string EnterUserNameAndPassword = "Enter your username and password";
			public const string UserName = "Please enter username";
			public const string Details = "Enter your details to create your account";
			public const string Agree = "I Agree to the";
			public const string TermsAndCondition = "terms and conditions";
			public const string ForgotMessage = "Enter your email to reset your password";
            public const string UserNameErrorMessage = "Please enter a username.";
            public const string UserNamelengthError = "Username must be between {2} and {1} characters long.";
            public const string PasswordErrorMessage = "Please enter a password.";
            public const string ConfirmPasswordErrorMessage = "Confirm Password is required";
            public const string PasswordConfirmationErrorMessage = "The password and confirmation password do not match.";
			public const string PasswordLengthErrorMessage = "The password must be at least {2} characters long.";
            public const string FullNameErrorMessage = "Please enter your full name.";
            public const string FullNameLengthErrorMessage = "Full name must be between {2} and {1} characters long.";
            public const string EmailErrorMessage = "Please enter an email.";
            public const string InvalidEmailErrorMessage = "Please enter a valid email address.";
            public const string SignupErrorMessage = "An error occurred while signing up. Please try again later.";
			public const string SignInErrorMessage = "An error occurred while signing in.";
            public const string AgreeError = "The password and confirmation password do not match.";
			public const string UserDoesntExist = "User doesn't exist.";
			public const string IncorrectPassword = "Incorrect password.";
			public const string SignupSuccess = "Signup successful!";
			public const string UserExist = "Username already exists. Please choose a different username.";
			public const string EmailAlreadyExist = "Email already exists. Please use a different email.";
			public const string InvalidCredential = "Invalid username or password. Please try again.";
			public const string CategoryAdded = "Category updated successfully!";
			public const string CategoryExist = "Category already exists. Please choose a different name.";
			public const string CategoryUpdated = "Category updated successfully.";
			public const string CategoryDeleted = "Category deleted successfully.";
			public const string VendorNameError = "Vendor Name is required";
			public const string BrandNameError = "Brand Name is required";
			public const string ContactError = "Contact Number is required";
			public const string BussinessTypeError = "Business Type is required";
			public const string AddressRequired = "Address Line 1 is required";
			public const string CountryError = "Country is required";
			public const string StateError = "State is required";
			public const string CityError = "City is required";
			public const string PincodeError = "Pincode is required";
			public const string SelectCategory = "At least one category is required";
			public const string VendorDetail = "Enter vendor details and submit";
			public const string VendorPersonalInfo = "Vendor's Personal Information";
			public const string VendorDeleted = "Vendor deleted successfully.";
			public const string VendorUpdated = "Vendor Edited Successfully";
			public const string PincodeNumericError = " Only Numbers allowed";
			public const string ContactNumberNumericError = "Contact Number should only have numeric value";
			public const string EnterAddress = "Please enter your Address.";
			public const string EnterPostcode = "Please enter your Postcode.";
			public const string EnterState = "Please enter your State.";
			public const string SelectvendorCategory = "Vendor Category selection:";
			public const string ListOfAllVendor = "List of all vendors";
			public const string VendorAddedSuccessfull = "Vendor added successfully.";
			public const string storedproceduremessage = "Vendor Email Address already exists.";
			public const string Errormessage = "Duplicate email address. Vendor with this email address already exists.";







        }
		
		public class Layout
		{
			public const string layout = "~/Views/Shared/_Layout.cshtml";
			public const string CommonLayout = "~/Views/Shared/_HomeLayout.cshtml";

        }
        public class Controller
        {
            public const string HomePage = "HomePage";
			public const string Category = "Category";
			public const string Vendor = "Vendor";
        }
        public class Action
        {
            public const string Dashboard = "Dashboard";
			public const string AddCategory = "AddCategory";
			public const string Category = "Category";
			public const string AddVendor = "AddVendorForm";
			public const string VendorList = "VendorList";
        }
        public class Text
		{
			public const string Layout = "Layout";
			public const string HomeLayout = "Home Layout";
			public const string Dashboard = "Dashboard";
            public const string Sigin = " Signin";
			public const string Signup = "Signup";
			public const string SNumber = "S.number";

            public const string Forgot = " Forgot";
			public const string Category = "Category";
			public const string AddVendor = "Add Vendor";
			public const string VendorList = "Vendor List";
			public const string NewVendor = "New Vendor";
			public const string Profile = "Profile";
			public const string CategoryManagement = "Category Management";
            public const string Submit = "Submit";
			public const string ForgotPassword = "Forgot Password?";
			public const string SignIn = "Sing In";
			public const string Cancel = "Cancel";
			public const string LoginTitle = "Metronic | Login Page";
			public const string SignUp = "Sign Up!";
			public const string Forgotten = "Forgot Password ";
			public const string Exception = "Exception";
			
            public const string SignInStatus = "SignInStatus";
			public const string StatusMessage = "StatusMessage";

			

			public const string Id ="Id";
			public const string Name ="Name";
			public const string CategoryNameParameter = "@CategoryName";
			public const string CategoryIdParameter = "@CategoryId";

            public const string Error = "Error";
            public const string ErrorMessage = "Error Message";
            public const string SignUpSucess = "SignUpSuccess";
			public const string UsernameExist = "UsernameExists";
			public const string EmailExist = "EmailExists";
			public const string Success = "Successful";
			public const string IncorrectPass = "IncorrectPassword";
			public const string Usernotfound = "UserNotFound";
			public const string CategoryList = "Category list";
			public const string Action = "Action";
			public const string ProductManagement = "Product Management";
			public const string  ManageCategory = " Manage Category";
			public const string AddProduct = "Add Product";
			public const string ProductList = "Product List";
			public const string SignOut = "Sign out";
			public const string UserName = "Shivani Dubey";
			public const string UserEmailLayout = "Shivanid@Chromeinfotech.com";
			public const string FooterNum = "2020©";
			public const string FooterName = "Keenthemes";
			public const string Shivani = "Shivani";
			public const string Hi = "Hi,";
			public const string SuccessMessage = "SuccessMessage";
			public const string Categories = "Categories";
			public const string BusinessTypes = "BusinessTypes";

			//vendor form 
			public const string VendorName = "Vendor Name";
			public const string BrandName = "Brand Name";
			public const string ContactPhone = "Contact Phone";
			public const string EmailAddress = "Email Address";
			public const string BusinessType = "Business Type";
			public const string AddressLine1 = "Address Line 1";
			public const string AddressLine2 = "Address Line 2";
			public const string City = "City";
			public const string Country = "Country";
			public const string State = "State";
			public const string Postcode = "Postcode";
			public const string CreatedDate = "Created Date";


		}
		public class Keys
		{
			public const string Title = "Title";
			public const string Username = "Username";
		    public const string Password = "Password";
			public const string Fullname = "FullName";
			public const string EmailId = "EmailId";
            public const string CreatedAt = "CreatedAt";
			public const string NameParameter = "@Name";
			public const string BrandNameParameter = "@BrandName";
			public const string ContactNumberParameter = "@ContactNumber";
			public const string BusinessTypeParameter = "@BusinessType";
			public const string EmailAddressParameter = "@EmailAddress";
			public const string AddressLine1Parameter = "@AddressLine1";
            public const string AddressLine2Parameter = "@AddressLine2";
			public const string CountryParameter = "@Country";
			public const string StateParameter = "@State";
			public const string CityParameter = "@City";
			public const string PincodeParameter = "@Pincode";
			public const string CategoryIdParameter = "@CategoryId";
			public const string VendorIdParameter = "@VendorId";
			public const string UpdateAtParameter = "@UpdatedAt";



		}
		
        public class  Placeholder 
        {
            public const string Email = "Email";
			public const string Password = "Password";
			public const string User = "Username";
			public const string ConfirmPass = "Confirm Password";
			public const string FullName = "Fullname";
			public const string Phone = "Phone";
        }
        public class MinimumLength
		{
			public const int FullNameLength = 3;
			public const int UserNameLength = 3;
			public const int PasswordNameLength = 6;	
		}
		public class StoredProcedure
		{
			//stored procedures
			public const string spGetAllCategory = "spGetAllCategories";
			public const string spAddCategory = "spAddCategory";
			public const string spUpdateCategory = "spUpdateCategory";
			public const string spDeleteCategory = "spDeleteCategory";
			public const string spAddVendor = "spAddVendor";
			public const string spDeleteVendor = "spDeleteVendor";
			public const string spUpdateVendor = "spUpdateVendor";
            public const string spSignInUser = "spSignInUser";
            public const string spSignUpuser = "spSignUpUser";

        }
	}
}
