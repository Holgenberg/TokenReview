using OpenAI_API;
using OpenAI_API.Chat;

namespace TokenReview
{
	public static class ReviewGeneration
	{
		public static async Task<string> GenerateReview()
		{
			const string openAIToken = "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";
			string businessName = "Starbucks";

			var openAIAPI = new OpenAIAPI(openAIToken);

			var chat = openAIAPI.Chat.CreateConversation();
			chat.AppendUserInput($"Write a positive review for {businessName}");
			string response = await chat.GetResponseFromChatbotAsync();
			return response;
		}
	}
}
