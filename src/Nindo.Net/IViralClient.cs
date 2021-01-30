﻿using System.Threading.Tasks;
using Nindo.Net.Models;
using Refit;

namespace Nindo.Net
{
    public interface IViralClient
    {
        [Get("/")]
        Task<ApiResponse<Viral[]>> GetViralsAsync();
    }
}