# Vonage ASP.NET MVC Application and .NET 6.0 Sample

This repository shows you how to use the Vonage SMS API with a real-world application using ASP.NET MVC Application and .NET 6.0. For more information, please see the blog post at [HERE](https://developer.vonage.com/en/blog/build-an-asp-net-mvc-app-to-send-sms-messages).

* [Requirements](#requirements)
* [Installation and Usage](#installation-and-usage)
  * [API Credentials](#api-credentials)
  * [Running the Application](#running-the-application)
* [Contributing](#contributing)
* [License](#license)

![Vonage Config](./demo.png)
*Listing 1: The completed web application that we are building*

## Requirements

This application requires that you have the following installed locally:

* [Visual Studio Community Edition or higher](https://visualstudio.microsoft.com/)
* [Vonage .NET SDK 6.03 or higher](https://www.nuget.org/packages/Vonage/)

Additionally, to test the application, you must have a Vonage account. You can create a Vonage account for free or manage your Vonage account details at the [Vonage Dashboard](https://developer.vonage.com).

## Installation and Usage

You can run this application by first cloning this repository locally and opening in Visual Studio or using the built-in source management tooling inside of Visual Studio. 

Once you have downloaded a local copy, change into the directory of the application and you can now set up the API credentials for your Vonage account.

### API Credentials

Inside the `Domain` folder, you'll see a file named `Configuration.cs`. Add your Vonage API key to the string values for `APIKey` and `APISecret`. 

As always, make sure not to commit your sensitive API credential data to any public version control. 

### Setting the Phone Numbers

You'll need to set the `To` and `From` phone numbers that the application uses. You can find this by going to the `Controllers` folder and editing line 33 and 34 in the `HomeController.cs` file. 

### Running the Application

Once you have your API credentials incorporated and your desired phone numbers, you can go ahead and press F5 within Visual Studio to load the app. 

Once the web application loads, you can test that everything is setup correctly by entering a phone number and a message. If everything works successfully, then you'll see **"Message sent successfully! An agent will contact you shortly."** otherwise, you'll see **Message Failure. Please try your request again.**

## Contributing

We ❤️ contributions from everyone! If you see something that needs fixed, then please follow the [GitHub Flow](https://guides.github.com/introduction/flow/index.html) and we'll try to incorporate it.

## License

This project is under the [Apache 2.0 License](LICENSE)


