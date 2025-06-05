using Light.Contracts;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Light.Tiki.Models
{
    public class ErrorResult
    {
        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyName("error_description")]
        public string ErrorDescription { get; set; }

        [JsonPropertyName("error_hint")]
        public string ErrorHint { get; set; }

        [JsonPropertyName("error_debug")]
        public string ErrorDebug { get; set; }

        [JsonPropertyName("status_code")]
        public int StatusCode { get; set; }

        public Result ToResult()
        {
            var result = new Result
            {
                Code = StatusCode.ToString(),
                Message = $"{Error} - {ErrorDescription} - {ErrorHint} - {ErrorDebug}",
            };

            return result;
        }

        public Result<T> ToResult<T>()
        {
            var result = new Result<T>
            {
                Code = StatusCode.ToString(),
                Message = $"{Error} - {ErrorDescription} - {ErrorHint} - {ErrorDebug}",
            };

            return result;
        }
    }


    public class Meta
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }
    }

    public class ErrorBody
    {
        [JsonPropertyName("errors")]
        public List<string> Errors { get; set; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }
    }

    public class CodeResult
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }
    }

    public class StateResult
    {
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}