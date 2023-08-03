# Sentiment Analysis 

This project has been developed using Google.Cloud.Language.V1, the .NET library for Google Cloud Natural Language API. It performs sentiment analysis on the text entered through a .NET Core Web API project. It returns three parameters: sentiment score, sentiment magnitude, and the detected language.

## Requirements

- Google.Cloud.Language.V1 Nuget package

## Installation

1. After downloading the project, you need to add the JSON file you obtained from the Google platform for authorization into the project directory and reference it in the code.

## Installation Guide
1. Sign-in to the Google Cloud Console and create a new project or reuse an existing one. If you don't already have a Gmail or Google Workspace account, you must create one.
2. Next, you'll need to enable billing in the Cloud Console to use Cloud resources/APIs. Running through this codelab won't cost much, if anything at all. To shut down resources to avoid incurring billing beyond this tutorial, you can delete the resources you created or delete the project. New Google Cloud users are eligible for the $300 USD Free Trial program.
3. For authentication  you can authenticate by downloading a service account JSON file and setting the GOOGLE_APPLICATION_CREDENTIALS environment variable to refer to it. This will tell your code to use the credentials in the JSON file to authenticate your API calls.
   1. Go to the Google Cloud Platform Console: https://console.cloud.google.com/.
   2. Click the Credentials tab.
   3. Click the Create credentials button and select Service account key.
   4. Select the JSON key type and click the Create button.
   5. Download the JSON file to your computer.
   6. Set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of the JSON file.

## Usage

- ![Alt text](/img/output-sample.png)

## Related Projects

- [Using the Natural Language API with C# on Google Cloud](https://codelabs.developers.google.com/codelabs/cloud-natural-language-csharp) - Example project.
- [.Net Documentation For Google Cloud Language](https://cloud.google.com/dotnet/docs/reference/Google.Cloud.Language.V1/latest)- .NET Documentation for Google Cloud Language.

## Credits
- Berk Turgut
## License

[MIT](LICENSE) © [berkturgut](https://github.com/berkturgut)
