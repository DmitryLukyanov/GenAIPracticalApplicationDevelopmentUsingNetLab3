﻿using Lab3.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SemanticKernel;

namespace Lab3.Services;

public class OllamaService : IOllamaService
{
    private readonly Kernel _kernel;
    
    public OllamaService([FromKeyedServices("KernelWithOllama")] Kernel kernel)
    {
        _kernel = kernel;
    }
    public async Task<string> GetSelfHostedAnswer(string question)
    {
        throw new NotImplementedException();
        // [Add code here]
    }
}