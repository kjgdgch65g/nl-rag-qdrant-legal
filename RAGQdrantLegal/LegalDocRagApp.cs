using Microsoft.KernelMemory;
using Microsoft.KernelMemory.AI.Ollama;

namespace RAG_Qdrant_Legal
{
    public class LegalDocRagApp
    {
        public async Task RunAsync()
        {
            // Setup Ollama configuration
            var ollamaConfig = new OllamaConfig()
            {
                TextModel = new OllamaModelConfig(LegalDocConfig.ChatModel) { MaxTokenTotal = 125000, Seed = 42 },
                EmbeddingModel = new OllamaModelConfig(LegalDocConfig.EmbeddingModel) { MaxTokenTotal = 2048 },
                Endpoint = LegalDocConfig.OllamaUrl
            };

            // Build KernelMemory with Ollama and QDrant
            Console.WriteLine("Initializing KernelMemory with Ollama and QDrant...");
            var memoryBuilder = new KernelMemoryBuilder()
                .WithOllamaTextGeneration(ollamaConfig)
                .WithOllamaTextEmbeddingGeneration(ollamaConfig)
                .WithQdrantMemoryDb(LegalDocConfig.QdrantUrl)
                .WithSearchClientConfig(new SearchClientConfig() { AnswerTokens = 4096 });

            var memory = memoryBuilder.Build(new KernelMemoryBuilderBuildOptions
            {
                AllowMixingVolatileAndPersistentData = true
            });

            // Import legal document data
            var importer = new LegalDocumentImporter();
            await importer.ImportLegalDocumentData(memory);

            // Start chat loop
            var chatService = new ChatService();
            await chatService.StartChatLoop(memory);
        }
    }
}

