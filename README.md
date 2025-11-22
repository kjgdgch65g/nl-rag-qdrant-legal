# nl-rag-qdrant-legal

A sample application demonstrating Retrieval-Augmented Generation (RAG) for legal document Q&A using local vector search with QDrant, Ollama-hosted AI models, and Microsoft KernelMemory. Intended for legal, compliance, and technical professionals seeking to explore next-gen semantic search in the legal domain using C# and .NET 9.0.

## Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- [QDrant](https://qdrant.tech/) installed and running locally (via Docker or binary)
- [Ollama](https://ollama.ai/) installed and running locally
- Required AI models downloaded in Ollama:
  - `nomic-embed-text:latest` (for embeddings)
  - `gemma3:1b` (for legal Q&A/chat)

## Installation

1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/nl-rag-qdrant-legal.git
   cd nl-rag-qdrant-legal
   ```

2. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

## Setup

1. **Start QDrant (Vector Database):**
   - The easiest way is via Docker:
     ```bash
     docker run -p 6333:6333 -p 6334:6334 qdrant/qdrant
     ```
   - QDrant will run at [http://localhost:6333](http://localhost:6333)

2. **Install and Start Ollama:**
   - Download Ollama from [ollama.ai](https://ollama.ai/), install and launch it.
   - Download and prepare required models:
     ```bash
     ollama pull nomic-embed-text:latest
     ollama pull gemma3:1b
     ```
   - Ollama will run at [http://localhost:11434](http://localhost:11434)

3. **Verify Model & Service Configuration:**
   - Ensure both services are running on their default endpoints:
     - QDrant: `http://localhost:6333`
     - Ollama: `http://localhost:11434`
   - Check the config in `LegalDocConfig.cs` for model versions and endpoints if you change ports/models.

## Usage

Run the console application to start the legal RAG Q&A example:

```bash
cd RAGQdrantLegal
# Restore and build
dotnet restore
# (optional, if not yet run)
dotnet build
# Run
dotnet run
```

You will see interactive output and will be prompted to ask legal questions against the database. Example prompts:

- "What are the key confidentiality clauses in the NDA?"
- "How can I terminate the employment contract as per the document?"
- "What is the defined uptime in the SLA?"
- "Who is responsible for breach notification according to the DPA?"

## Example Flow

1. **Legal Document Import:**
   - The app loads a set of sample legal documents, processes them into semantic embeddings using `nomic-embed-text`, and stores them in a QDrant vector collection.
2. **Semantic Search & Q&A:**
   - You enter your legal query; the app uses KernelMemory to search for the most relevant text chunks using vector similarity and the QDrant engine.
   - The app uses the `gemma3:1b` model (locally via Ollama) to generate a context-aware answer, optionally showing relevant sources from the vector DB.

## Legal Document Types Included

- Non-Disclosure Agreement (NDA)
- Employment Contract
- Data Processing Addendum (DPA)
- Service Level Agreement (SLA)
- (Plus other sample agreements for demonstration - see `LegalDocumentData.cs`)

## Key Technologies

- **.NET 9.0** (C# Console App)
- **QDrant** (Vector similarity search)
- **Ollama** (Local AI model runtime)
- **Microsoft KernelMemory** (`Microsoft.KernelMemory.Core`)
- **nomic-embed-text:latest** (Nomic AI, for embeddings)
- **gemma3:1b** (Google, for chat/QA)

## Dependencies

NuGet packages required (see `.csproj`):
```xml
<PackageReference Include="Microsoft.KernelMemory.Core" Version="0.98.250508.3" />
<PackageReference Include="Microsoft.KernelMemory.MemoryDb.Qdrant" Version="0.98.250508.3" />
<PackageReference Include="Microsoft.KernelMemory.AI.Ollama" Version="0.98.250508.3" />
<PackageReference Include="Microsoft.SemanticKernel" Version="1.61.0" />
<PackageReference Include="Qdrant.Client" Version="1.15.0" />
<PackageReference Include="Microsoft.Extensions.VectorData.Abstractions" Version="9.7.0" />
<PackageReference Include="Microsoft.Extensions.AI" Version="9.7.1" />
```

## Project Structure

- `LegalDocRagApp.cs`: Orchestrates initialization, import, and chat
- `Program.cs`: Entry point
- `LegalDocumentImporter.cs`: Imports legal documents into the semantic memory
- `LegalDocumentData.cs`: Sample legal document database
- `ChatService.cs`: Interactive Q&A loop
- `LegalDocConfig.cs`: Contains configuration for endpoints and models

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome! Please submit an issue or open a Pull Request if you find a bug or have an enhancement idea.