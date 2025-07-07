using Light.Lazada.Common;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Light.Lazada
{
    public static class ResultExtensions
    {
        public static async Task<ILazResponse<T>> ReadData<T>(this HttpResponseMessage response)
        {
            try
            {
                var result = await response.Content.ReadFromJsonAsync<LazData<T>>();

                if (result is null)
                    return LazData<T>.Failed("Error when read LazResponse.Data from HttpResponseMessage");

                return result;
            }
            catch (Exception ex)
            {
                return LazData<T>.Failed(ex.Message);
            }

        }

        public static async Task<ILazResponse<T>> ReadResult<T>(this HttpResponseMessage response)
        {
            try
            {
                var result = await response.Content.ReadFromJsonAsync<LazResult<T>>();

                if (result is null)
                    return LazResponse<T>.Failed("Error when read LazResponse.Result from HttpResponseMessage");

                return new LazData<T>
                {
                    Type = result.Type,
                    Code = result.Code,
                    Message = result.Message,
                    RequestId = result.RequestId,
                    Data = result.Data
                };
            }
            catch (Exception ex)
            {
                return LazResponse<T>.Failed(ex.Message);
            }
        }

        public static async Task<ILazResponse<T>> ReadDetail<T>(this HttpResponseMessage response)
        {
            try
            {
                var result = await response.Content.ReadFromJsonAsync<LazDetail<T>>();

                if (result is null)
                    return LazResponse<T>.Failed("Error when read LazResult.Detail from HttpResponseMessage");

                return new LazData<T>
                {
                    Type = result.Type,
                    Code = result.Code,
                    Message = result.Message,
                    RequestId = result.RequestId,
                    Data = result.Data
                };
            }
            catch (Exception ex)
            {
                return LazResponse<T>.Failed(ex.Message);
            }
        }
    }
}
