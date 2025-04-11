using Light.Lazada.Common;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public static class ResultExtensions
    {
        public static async Task<LazResult<T>> Read<T>(this HttpResponseMessage response)
        {
            try
            {
                var result = await response.Content.ReadFromJsonAsync<LazResult<T>>();

                if (result is null)
                    return LazResult<T>.Failed("Error when read HttpResponseMessage");

                return result;
            }
            catch (Exception ex)
            {
                return LazResult<T>.Failed(ex.Message);
            }

        }

        public static async Task<LazResult<T>> ReadData<T>(this HttpResponseMessage response)
        {
            try
            {
                var result = await response.Content.ReadFromJsonAsync<LazData<T>>();

                if (result is null)
                    return LazResult<T>.Failed("Error when read LazResult.Data from HttpResponseMessage");

                return new LazResult<T>
                {
                    Type = result.Type,
                    Code = result.Code,
                    Message = result.Message,
                    RequestId = result.RequestId,
                    Result = result.Data
                };
            }
            catch (Exception ex)
            {
                return LazResult<T>.Failed(ex.Message);
            }
        }

        public static async Task<LazResult<List<Detail>>> ReadDetail(this HttpResponseMessage response)
        {
            try
            {
                var lazResult = await response.Content.ReadFromJsonAsync<LazResultDetail>();

                if (lazResult is null)
                    return LazResult<List<Detail>>.Failed("Error when read LazResult.Detail from HttpResponseMessage");

                return new LazResult<List<Detail>>
                {
                    Type = lazResult.Type,
                    Code = lazResult.Code,
                    Message = lazResult.Message,
                    RequestId = lazResult.RequestId,
                    Result = lazResult.Detail
                };
            }
            catch (Exception ex)
            {
                return LazResult<List<Detail>>.Failed(ex.Message);
            }
        }
    }
}
