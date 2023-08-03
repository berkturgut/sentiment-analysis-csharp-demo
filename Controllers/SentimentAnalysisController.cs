using Google.Cloud.Language.V1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace sentiment_analysis_csharp_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentimentAnalysisController : ControllerBase
    {
        private readonly ILogger<SentimentAnalysisController> _logger;
        public SentimentAnalysisController(ILogger<SentimentAnalysisController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "GetSentimentAnalysis")]
        public List<string> GetSentimentAnalysis([FromBody]string text)
        {
            
            _logger.LogInformation("Analyzing text: {text}", text);

            string pathToJsonFile = ".\\key.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", pathToJsonFile);

            LanguageServiceClient client = LanguageServiceClient.Create();
            Document document = Document.FromPlainText(text);
            AnalyzeSentimentResponse response = client.AnalyzeSentiment(document);
      
            List<string> sentimentResult = new List<string>();
            sentimentResult.Add($"Detected language: {response.Language}");
            sentimentResult.Add($"Sentiment score: {response.DocumentSentiment.Score}");
            sentimentResult.Add($"Sentiment magnitude: {response.DocumentSentiment.Magnitude}");

            // Log the sentiment results.
            _logger.LogInformation("Sentiment results: {sentimentResult}", sentimentResult);

            return sentimentResult;
        }

    }
}
