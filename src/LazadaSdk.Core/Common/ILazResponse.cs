namespace Light.Lazada.Common
{
    public interface ILazResponse<T>
    {
        string Type { get; }

        string Code { get; }

        string Message { get; }

        string RequestId { get; }

        T Data { get; set; }

        bool IsSuccess { get; }
    }
}