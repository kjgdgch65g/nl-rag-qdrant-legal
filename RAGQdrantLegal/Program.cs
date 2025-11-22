namespace RAG_Qdrant_Legal
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Legal Document RAG Q&A Demo with QDrant and Ollama");
            Console.WriteLine(new string('=', 50));

            try
            {
                var app = new LegalDocRagApp();
                await app.RunAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Please ensure QDrant is running on port 6333 and Ollama on port 11434");
                Console.WriteLine("Also ensure you have pulled the required models:");
                Console.WriteLine($"  ollama pull {LegalDocConfig.EmbeddingModel}");
                Console.WriteLine($"  ollama pull {LegalDocConfig.ChatModel}");
            }
        }
    }
}

 
