using System;
using Foundation;

namespace IosBinding
{
	// @interface TestClass : NSObject
	[BaseType (typeof(NSObject))]
	interface TestClass
	{
		// -(NSString * _Nonnull)DebugLogWithMessage:(NSString * _Nonnull)message __attribute__((warn_unused_result("")));
		[Export ("DebugLogWithMessage:")]
		string DebugLogWithMessage (string message);

		// -(void)DebugLog2WithMessage:(NSString * _Nonnull)message completionHandler:(void (^ _Nonnull)(NSString * _Nonnull))completionHandler;
		[Export ("DebugLog2WithMessage:completionHandler:"), Async]
		void DebugLog2WithMessage (string message, Action<NSString> completionHandler);
	}
}
