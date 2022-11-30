// See https://aka.ms/new-console-template for more information
//See https://marketplace.zoom.us/docs/sdk/native-sdks/auth/#3-pass-zak-token-to-the-sdk for code reference
using System;
using static ZoomHelper;

namespace  DOTNET_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(GetSignature(97220310061));
        }
    }
}
