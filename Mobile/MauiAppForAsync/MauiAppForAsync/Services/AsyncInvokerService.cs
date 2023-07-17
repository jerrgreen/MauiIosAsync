namespace MauiAppForAsync.Services
{
    public partial class AsyncInvokerService : IAsyncInvokerService
    {
        public partial Task<string> DebugLog(string message);
    }
}
