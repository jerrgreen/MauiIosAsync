namespace MauiAppForAsync.Services
{
    public interface IAsyncInvokerService
    {
        Task<string> DebugLog(string message);
    }
}
