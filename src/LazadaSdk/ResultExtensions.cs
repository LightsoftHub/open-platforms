using Light.Lazada.Common;
using Light.Lazada.Models.Products;
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

        [Obsolete("Use Read<T> instead.")]
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

        public static async Task<LazResult> ReadDetail(this HttpResponseMessage response)
        {
            try
            {
                var lazResult = await response.Content.ReadFromJsonAsync<LazResultDetail>();

                if (lazResult is null)
                    return LazResult<List<UploadStockResponse>>.Failed("Error when read LazResult.Detail from HttpResponseMessage");

                return lazResult;
            }
            catch (Exception ex)
            {
                return LazResult<List<UploadStockResponse>>.Failed(ex.Message);
            }
        }

        public static async Task<T> ReadDetail<T>(this HttpResponseMessage response)
            where T : LazResult
        {
            var lazResult = await response.Content.ReadFromJsonAsync<T>();

            return lazResult;
        }
    }
}
