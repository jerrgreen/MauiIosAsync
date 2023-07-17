using IosBinding;

namespace MauiAppForAsync.Services
{
    public partial class AsyncInvokerService
    {
        public partial async Task<string> DebugLog(string message)
        {
            var testClass = new TestClass();

            // This works
            Console.WriteLine("Printing first message");
            Console.WriteLine($"ECHO: {testClass.DebugLogWithMessage(message)}");

            // This does not (Microsoft.iOS: Unsupported type encoding: "NSString"16@?<v@?@"NSString">24)
            Console.WriteLine("Printing second message");
            Console.WriteLine($"ECHO: {await testClass.DebugLog2WithMessageAsync(message)}");

            return "";
        }
    }
}
