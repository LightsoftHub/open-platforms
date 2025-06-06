﻿using Light.Contracts;
using Light.Tiki.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Light.Tiki
{
    public class AuthApiClient : IAuthClient
    {
        private readonly HttpClient _httpClient;

        public AuthApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateTikiClient();
        }

        public async Task<Result<AccessTokenResponse>> GetTokenAsync(string clientId, string clientSecret)
        {
            var url = "/sc/oauth2/token";

            var requestContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("client_id", clientId),
                new KeyValuePair<string, string>("client_secret", clientSecret),
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
            });

            var req = new HttpRequestMessage(HttpMethod.Post, url) { Content = requestContent };
            var res = await _httpClient.SendAsync(req);

            var responseStr = await res.Content.ReadAsStringAsync();

            if (res.IsSuccessStatusCode)
            {
                var dto = JsonSerializer.Deserialize<AccessTokenResponse>(responseStr);
                if (dto != null)
                {
                    return Result<AccessTokenResponse>.Success(dto);
                }
            }

            if (string.IsNullOrEmpty(responseStr))
            {
                return Result<AccessTokenResponse>.Error($"{(int)res.StatusCode} {res.StatusCode}: Empty response");
            }

            var error = JsonSerializer.Deserialize<ErrorResult>(responseStr);
            if (error != null)
            {
                return error.ToResult<AccessTokenResponse>();
            }

            return Result<AccessTokenResponse>.Error(responseStr);
        }
    }
}
