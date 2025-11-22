using Microsoft.KernelMemory;

namespace RAG_Qdrant_Legal
{
    public class ChatService
    {
        public async Task StartChatLoop(IKernelMemory memory)
        {
            var chatHistory = new ChatHistory();

            Console.WriteLine("\nChat with your legal document database! (type 'exit' to quit)");
            Console.WriteLine("Now using REAL nomic-embed-text embeddings for semantic search!");
            Console.WriteLine("Try asking: 'What is the confidentiality obligation in the NDA?' or 'What is the response time for a critical incident as per the SLA?' or 'Show me the main termination conditions in the employment contract.'");
            Console.WriteLine(new string('-', 70));

            while (true)
            {
                Console.Write("\nYou: ");
                var userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput) || userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                try
                {
                    // Use conversation history for context
                    var fullQuery = chatHistory.GetHistoryAsContext() + "\nUser: " + userInput;

                    Console.WriteLine($"Searching for: '{userInput}'");

                    // Ask KernelMemory with real semantic search using nomic-embed-text
                    var answer = await memory.AskAsync(fullQuery, index: LegalDocConfig.IndexName, minRelevance: 0.3f);

                    // Debug: Show what was actually retrieved from QDrant
                    Console.WriteLine($"Debug: Found {answer.RelevantSources.Count()} relevant sources from QDrant");

                    // Update chat history
                    chatHistory.AddUserMessage(userInput);
                    chatHistory.AddAssistantMessage(answer.Result);

                    Console.WriteLine($"AI: {answer.Result}");

                    // Show relevant sources if any were found
                    if (answer.RelevantSources.Any())
                    {
                        Console.WriteLine("\nSources from QDrant:");
                        foreach (var source in answer.RelevantSources.Take(5))
                        {
                            Console.WriteLine($"  Source Name: {source.SourceName}");
                            Console.WriteLine($"  Link: {source.Link ?? "N/A"}");
                            Console.WriteLine($"  Partition: {source.Partitions?.FirstOrDefault()?.Text?[..Math.Min(100, source.Partitions.FirstOrDefault()?.Text?.Length ?? 0)] ?? "N/A"}...");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNo relevant sources found. This might indicate:");
                        Console.WriteLine("The embedding search didn't find matching content");
                        Console.WriteLine("Try using different keywords or phrasing");
                        Console.WriteLine("The legal document data might not contain the requested information");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing query: {ex.Message}");
                }
            }
        }
    }

    public class ChatHistory
    {
        private readonly System.Collections.ObjectModel.Collection<string> _messages = [];
        public void AddUserMessage(string message) => _messages.Add($"User: {message}");
        public void AddAssistantMessage(string message) => _messages.Add($"Assistant: {message}");
        public string GetHistoryAsContext(int maxMessages = 6) =>
            string.Join("\n", _messages.TakeLast(maxMessages));
    }
}

