using Lab3.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;
namespace Lab3.Services;

public class HuggingFaceService : IHuggingFaceService
{
    private readonly Kernel _kernel;
    
    public HuggingFaceService([FromKeyedServices("KernelWithHuggingFace")] Kernel kernel)
    {
        _kernel = kernel;
    }
    public async Task<string> GetHuggingFaceAnswer(string question)
    {
        throw new NotImplementedException();
        // [Add code here]
    }
}