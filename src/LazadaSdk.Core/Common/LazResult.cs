﻿using System.Text.Json.Serialization;

namespace Light.Lazada.Common
{
    public class LazResult<T> : LazResponse<T>, ILazResponse<T>
    {
        [JsonPropertyName("result")]
        public override T Data { get; set; }
    }
}
